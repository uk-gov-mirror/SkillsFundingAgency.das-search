﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using log4net;
using Nest;
using Sfa.Eds.Indexer.DedsService.Services;
using Sfa.Eds.Indexer.Indexer.Infrastructure.Configuration;
using Sfa.Eds.Indexer.Indexer.Infrastructure.Helpers;
using Sfa.Eds.Indexer.Indexer.Infrastructure.Models;
using Sfa.Eds.Indexer.Settings.Settings;

namespace Sfa.Eds.Indexer.StandardIndexer.Helpers
{
    public class StandardHelper : IStandardHelper
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IBlobStorageHelper _blobStorageHelper;
        private readonly IDedsService _dedsService;
        private readonly IElasticsearchClientFactory _elasticsearchClientFactory;
        private readonly IStandardIndexSettings _settings;
        private readonly IElasticClient _client;

        public StandardHelper(
            IDedsService dedsService,
            IBlobStorageHelper blobStorageHelper,
            IStandardIndexSettings settings,
            IElasticsearchClientFactory elasticsearchClientFactory)
        {
            _dedsService = dedsService;
            _blobStorageHelper = blobStorageHelper;
            _settings = settings;
            _elasticsearchClientFactory = elasticsearchClientFactory;

            _client = _elasticsearchClientFactory.GetElasticClient();
        }

        public bool CreateIndex(DateTime scheduledRefreshDateTime)
        {
            var indexName = GetIndexNameAndDateExtension(scheduledRefreshDateTime);
            var indexExistsResponse = _client.IndexExists(indexName);

            // If it already exists and is empty, let's delete it.
            if (indexExistsResponse.Exists)
            {
                Log.Info("Index already exists, deleting and creating a new one");

                _client.DeleteIndex(indexName);
            }

            // create index
            _client.CreateIndex(indexName, c => c.AddMapping<StandardDocument>(m => m.MapFromAttributes()));

            return _client.IndexExists(indexName).Exists;
        }

        public async Task IndexStandards(DateTime scheduledRefreshDateTime)
        {
            var standards = await GetStandardsFromAzureAsync();

            Log.Info("Uploading " + standards.Count() + " standard's PDF to Azure");

            await standards.ForEachAsync(UploadStandardPdf).ConfigureAwait(false);

            try
            {
                Log.Info("Indexing " + standards.Count() + " standards");

                var indexNameAndDateExtension = GetIndexNameAndDateExtension(scheduledRefreshDateTime);
                await IndexStandardPdfs(indexNameAndDateExtension, standards).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                Log.Error("Error indexing PDFs: " + e.Message);
            }
        }

        public bool IsIndexCorrectlyCreated(DateTime scheduledRefreshDateTime)
        {
            var indexName = GetIndexNameAndDateExtension(scheduledRefreshDateTime);

            return _client
                .Search<StandardDocument>(s => s.Index(indexName).From(0).Size(1000).MatchAll())
                .Documents
                .Any();
        }

        public void SwapIndexes(DateTime scheduledRefreshDateTime)
        {
            var indexAlias = _settings.StandardIndexesAlias;
            var newIndexName = GetIndexNameAndDateExtension(scheduledRefreshDateTime);

            if (!CheckIfAliasExists(indexAlias))
            {
                Log.Info("Alias doesn't exists, creating a new one...");

                CreateAlias(newIndexName);
            }

            var existingIndexesOnAlias = _client.GetIndicesPointingToAlias(indexAlias);
            var aliasRequest = new AliasRequest { Actions = new List<IAliasAction>() };

            foreach (var existingIndexOnAlias in existingIndexesOnAlias)
            {
                aliasRequest.Actions.Add(new AliasRemoveAction { Remove = new AliasRemoveOperation { Alias = indexAlias, Index = existingIndexOnAlias } });
            }

            aliasRequest.Actions.Add(new AliasAddAction { Add = new AliasAddOperation { Alias = indexAlias, Index = newIndexName } });
            _client.Alias(aliasRequest);
        }

        public void DeleteOldIndexes(DateTime scheduledRefreshDateTime)
        {
            var dateTime = scheduledRefreshDateTime.AddDays(-2);

            for (int i = 0; i < 23; i++)
            {
                var timeSpan = new TimeSpan(i, 0, 0);
                var dateTimeTmp = dateTime.Date + timeSpan;

                var indexName = GetIndexNameAndDateExtension(dateTimeTmp);

                var indexExistsResponse = _client.IndexExists(indexName);

                if (indexExistsResponse.Exists)
                {
                    _client.DeleteIndex(indexName);
                }
            }
        }

        private void CreateAlias(string indexName)
        {
            _client.Alias(a => a
                .Add(add => add
                    .Index(indexName)
                    .Alias(_settings.StandardIndexesAlias)
                )
            );
        }

        private bool CheckIfAliasExists(string aliasName)
        {
            var aliasExistsResponse = _client.AliasExists(aliasName);

            return aliasExistsResponse.Exists;
        }

        private string GetIndexNameAndDateExtension(DateTime dateTime)
        {
            return string.Format("{0}-{1}", _settings.StandardIndexesAlias, dateTime.ToUniversalTime().ToString("yyyy-MM-dd-HH")).ToLower(CultureInfo.InvariantCulture);
        }

        private async Task UploadStandardPdf(JsonMetadataObject standard)
        {
            await _blobStorageHelper.UploadPdfFromUrl(_settings.StandardPdfContainer, string.Format(standard.Id.ToString(), ".pdf"), standard.Pdf).ConfigureAwait(false);
        }

        private async Task<IEnumerable<JsonMetadataObject>> GetStandardsFromAzureAsync()
        {
            return (await _blobStorageHelper.ReadStandardsAsync(_settings.StandardJsonContainer)).OrderBy(s => s.Id);
        }

        private async Task IndexStandardPdfs(string indexName, IEnumerable<JsonMetadataObject> standards)
        {
            // index the items
            foreach (var standard in standards)
            {
                try
                {
                    var doc = await CreateDocument(standard);

                    _client.Index(doc, i => i.Index(indexName).Id(doc.StandardId));
                }
                catch (Exception e)
                {
                    Log.Info("Error indexing standard PDF: " + e.Message);
                    throw;
                }
            }
        }

        private async Task<StandardDocument> CreateDocument(JsonMetadataObject standard)
        {
            try
            {
                var attachment = new Attachment
                {
                    Content =
                        Convert.ToBase64String(
                            await
                                _blobStorageHelper.ReadStandardPdfAsync(_settings.StandardPdfContainer, string.Format(standard.Id.ToString(), ".pdf"))),
                    ContentType = _settings.StandardContentType,
                    Name = standard.PdfFileName
                };

                var doc = new StandardDocument
                {
                    StandardId = standard.Id,
                    Title = standard.Title,
                    NotionalEndLevel = _dedsService.GetNotationLevelFromLars(standard.Id),
                    PdfFileName = standard.PdfFileName,
                    PdfUrl = standard.Pdf,
                    File = attachment
                };

                return doc;
            }
            catch (Exception e)
            {
                Log.Error("Error creating document: " + e.Message);

                throw;
            }
        }
    }
}