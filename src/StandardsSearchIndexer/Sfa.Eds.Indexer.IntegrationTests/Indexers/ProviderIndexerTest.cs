﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using FluentAssertions;
using Nest;
using NUnit.Framework;
using Sfa.Eds.Indexer.Indexer.Infrastructure.Configuration;
using Sfa.Eds.Indexer.Indexer.Infrastructure.Models;
using Sfa.Eds.Indexer.ProviderIndexer.Helpers;
using Sfa.Eds.Indexer.ProviderIndexer.Services;
using Sfa.Eds.Indexer.Settings.Settings;
using Sfa.Eds.Standards.Indexer.AzureWorkerRole.DependencyResolution;
using StructureMap;

namespace Sfa.Eds.Indexer.IntegrationTests.Indexers
{
    [TestFixture]
    public class ProviderIndexerTest
    {
        private IContainer _ioc;
        private IProviderIndexSettings _providerSettings;
        private IProviderHelper _providerHelper;
        private IProviderIndexerService _sut;
        private IElasticClient _elasticClient;

        [SetUp]
        public void SetUp()
        {
            _ioc = IoC.Initialize();
            _providerSettings = _ioc.GetInstance<IProviderIndexSettings>();
            _providerHelper = _ioc.GetInstance<IProviderHelper>();

            var elasticClientFactory = _ioc.GetInstance<IElasticsearchClientFactory>();
            _elasticClient = elasticClientFactory.GetElasticClient();

            _sut = _ioc.GetInstance<IProviderIndexerService>();
        }

        [Test, Category("Integration")]
        public void ShouldCreateScheduledIndexAndMapping()
        {
            var scheduledDate = new DateTime(2000, 1, 1);
            var indexName = _providerHelper.GetIndexNameAndDateExtension(scheduledDate);

            DeleteIndexIfExists(indexName);
            _elasticClient.IndexExists(i => i.Index(indexName)).Exists.Should().BeFalse();
            _sut.CreateScheduledIndex(scheduledDate);
            _elasticClient.IndexExists(i => i.Index(indexName)).Exists.Should().BeTrue();

            var mapping = _elasticClient.GetMapping<Provider>(i => i.Index(indexName));
            mapping.Should().NotBeNull();

            _elasticClient.DeleteIndex(i => i.Index(indexName));
            _elasticClient.IndexExists(i => i.Index(indexName)).Exists.Should().BeFalse();
        }

        [Test, Category("Integration")]
        public void ShouldRetrieveProvider()
        {
            var scheduledDate = new DateTime(2000, 1, 1);
            var indexName = _providerHelper.GetIndexNameAndDateExtension(scheduledDate);

            var providersTest = GetProvidersTest();
            var expectedProviderResult = new Provider
                {
                    UkPrn = "10031241",
                    PostCode = "B4 7LR",
                    ProviderName = "ASPIRE ACHIEVE ADVANCE LIMITED",
                    VenueName = "3AAA BIRMINGHAM",
                    Radius = 30,
                    Coordinate = new Coordinate
                    {
                        Lat = 52.4819902,
                        Lon = -1.8923181
                    }
                };

            DeleteIndexIfExists(indexName);
            _elasticClient.IndexExists(i => i.Index(indexName)).Exists.Should().BeFalse();

            _providerHelper.CreateIndex(scheduledDate);
            _elasticClient.IndexExists(i => i.Index(indexName)).Exists.Should().BeTrue();

            _providerHelper.IndexProviders(scheduledDate, providersTest);

            Thread.Sleep(1000);

            var retrievedResult =_elasticClient.Search<Provider>(p => p
                .Index(indexName)
                .QueryString(expectedProviderResult.PostCode));
            var amountRetrieved = retrievedResult.Documents.Count();
            var retrievedProvider = retrievedResult.Documents.FirstOrDefault();

            _elasticClient.DeleteIndex(i => i.Index(indexName));
            _elasticClient.IndexExists(i => i.Index(indexName)).Exists.Should().BeFalse();

            Assert.AreEqual(1, amountRetrieved);
            Assert.AreEqual(expectedProviderResult.ProviderName, retrievedProvider.ProviderName);
        }

        private void DeleteIndexIfExists(string indexName)
        {
            var exists = _elasticClient.IndexExists(i => i.Index(indexName));
            if (exists.Exists)
            {
                _elasticClient.DeleteIndex(i => i.Index(indexName));
            }
        }

        private List<Provider> GetProvidersTest()
        {
            return new List<Provider>
            {
                new Provider
                {
                    UkPrn = "10003347",
                    PostCode = "CV21 2BB",
                    ProviderName = "INTEC BUSINESS COLLEGES",
                    VenueName = "INTEC BUSINESS COLLEGES",
                    Radius = 35,
                    Coordinate = new Coordinate
                    {
                        Lat = 52.3714464,
                        Lon = -1.2669471
                    }
                },
                new Provider
                {
                    UkPrn = "10001309",
                    PostCode = "CV32 4JE",
                    ProviderName = "COVENTRY & WARWICKSHIRE CHAMBER TRAINING (CWT)",
                    VenueName = "COVENTRY & WARWICKSHIRE CHAMBER TRAINING (CWT)",
                    Radius = 40,
                    Coordinate = new Coordinate
                    {
                        Lat = 52.290897,
                        Lon = -1.528915
                    }
                },
                new Provider
                {
                    UkPrn = "10031241",
                    PostCode = "B4 7LR",
                    ProviderName = "ASPIRE ACHIEVE ADVANCE LIMITED",
                    VenueName = "3AAA BIRMINGHAM",
                    Radius = 30,
                    Coordinate = new Coordinate
                    {
                        Lat = 52.4819902,
                        Lon = -1.8923181
                    }
                },
                new Provider
                {
                    UkPrn = "10005967",
                    PostCode = "B5 5SU",
                    ProviderName = "SOUTH & CITY COLLEGE BIRMINGHAM",
                    VenueName = "	Digbeth Campus",
                    Radius = 30,
                    Coordinate = new Coordinate
                    {
                        Lat = 52.4754573,
                        Lon = -1.8857531
                    }
                },
                new Provider
                {
                    UkPrn = "10007015",
                    PostCode = "DE24 8AJ",
                    ProviderName = "TRAINING SERVICES 2000 LTD",
                    VenueName = "TRAINING SERVICES 2000 LTD",
                    Radius = 30,
                    Coordinate = new Coordinate
                    {
                        Lat = 52.9106629,
                        Lon = -1.4467433
                    }
                },
                new Provider
                {
                    UkPrn = "10031241",
                    PostCode = "DE1 2JT",
                    ProviderName = "ASPIRE ACHIEVE ADVANCE LIMITED",
                    VenueName = "3AAA DERBY",
                    Radius = 60,
                    Coordinate = new Coordinate
                    {
                        Lat = 52.918635,
                        Lon = -1.4761639
                    }
                },
                new Provider
                {
                    UkPrn = "10031241",
                    PostCode = "WC1X 8QB",
                    ProviderName = "ASPIRE ACHIEVE ADVANCE LIMITED",
                    VenueName = "3AAA KINGS CROSS",
                    Radius = 30,
                    Coordinate = new Coordinate
                    {
                        Lat = 51.5292025,
                        Lon = -0.1202702
                    }
                },
                new Provider
                {
                    UkPrn = "10012834",
                    PostCode = "W6 7AN",
                    ProviderName = "SKILLS TEAM LTD",
                    VenueName = "EMPLOYERS WORK PLACE",
                    Radius = 30,
                    Coordinate = new Coordinate
                    {
                        Lat = 51.4938191,
                        Lon = -0.2236763
                    }
                },
                new Provider
                {
                    UkPrn = "10005264",
                    PostCode = "NG10 1LL",
                    ProviderName = "MILLBROOK MANAGEMENT SERVICES LIMITED",
                    VenueName = "PROSTART TRAINING",
                    Radius = 60,
                    Coordinate = new Coordinate
                    {
                        Lat = 52.8967801,
                        Lon = -1.2682401
                    }
                }
            };
        } 
    }
}