﻿using System;
using System.Linq;
using Nest;
using Sfa.Das.ApplicationServices;
using Sfa.Das.ApplicationServices.Models;
using Sfa.Eds.Das.Core.Domain.Model;
using Sfa.Eds.Das.Core.Logging;

namespace Sfa.Eds.Das.Infrastructure.ElasticSearch
{
    using Core.Configuration;
    using Sfa.Das.ApplicationServices.Exceptions;
    public sealed class ElasticsearchProvider : ISearchProvider
    {
        private readonly IElasticsearchClientFactory _elasticsearchClientFactory;
        private readonly ILog _logger;
        private readonly IConfigurationSettings _applicationSettings;

        public ElasticsearchProvider(IElasticsearchClientFactory elasticsearchClientFactory, ILog logger, IConfigurationSettings applicationSettings)
        {
            _elasticsearchClientFactory = elasticsearchClientFactory;
            _logger = logger;
            _applicationSettings = applicationSettings;
        }

        public ApprenticeshipSearchResults SearchByKeyword(string keywords, int skip, int take)
        {
            var formattedKeywords = QueryHelper.FormatQuery(keywords);

            var client = _elasticsearchClientFactory.Create();
            var results = client.Search<ApprenticeshipSearchResultsItem>(s => s
                .Index(_applicationSettings.ApprenticeshipIndexAlias)
                .Type(Types.Parse("standarddocument,frameworkdocument"))
                .Skip(skip)
                .Take(take)
                .Query(q => q
                    .QueryString(qs => qs
                        .Fields(fs => fs
                            .Field(f => f.Title)
                            .Field(p => p.JobRoles)
                            .Field(p => p.Keywords)
                            .Field(p => p.FrameworkName)
                            .Field(p => p.PathwayName))
                        .Query(formattedKeywords))));

            return new ApprenticeshipSearchResults
            {
                TotalResults = results.Total,
                SearchTerm = formattedKeywords,
                Results = results.Documents,
                HasError = results.ApiCall.HttpStatusCode != 200
            };
        }

        public SearchResult<StandardProviderSearchResultsItem> SearchByStandardLocation(int code, Coordinate geoPoint)
        {
            var client = _elasticsearchClientFactory.Create();
            var qryStr = CreateStandardProviderRawQuery(code.ToString(), geoPoint);

            var results = client
                .Search<StandardProviderSearchResultsItem>(s => s
                .Index(_applicationSettings.ProviderIndexAlias)
                .From(0)
                .Size(1000)
                .Query(q => q
                    .Raw(qryStr))
                .Sort(ss => ss
                    .GeoDistance(g => g
                        .Field("locationPoint")
                        .PinTo(new GeoLocation(geoPoint.Lat, geoPoint.Lon))
                        .Unit(DistanceUnit.Miles)
                        .Ascending())));

            var documents = results.Hits.Select(hit => new StandardProviderSearchResultsItem
            {
                Id = hit.Source.Id,
                UkPrn = hit.Source.UkPrn,
                Address = hit.Source.Address,
                ContactUsUrl = hit.Source.ContactUsUrl,
                DeliveryModes = hit.Source.DeliveryModes,
                Email = hit.Source.Email,
                EmployerSatisfaction = hit.Source.EmployerSatisfaction * 10,
                LearnerSatisfaction = hit.Source.LearnerSatisfaction * 10,
                LocationId = hit.Source.LocationId,
                LocationName = hit.Source.LocationName,
                ApprenticeshipMarketingInfo = hit.Source.ApprenticeshipMarketingInfo,
                Name = hit.Source.Name,
                Phone = hit.Source.Phone,
                StandardCode = hit.Source.StandardCode,
                StandardInfoUrl = hit.Source.StandardInfoUrl,
                Website = hit.Source.Website,
                Distance = hit.Sorts != null ? Math.Round(double.Parse(hit.Sorts.DefaultIfEmpty(0).First().ToString()), 1) : 0
            }).OrderByDescending(x => x.DeliveryModes?.Contains("100PercentEmployer")).ToList();

            if (results.ApiCall?.HttpStatusCode != 200)
            {
                throw new SearchException($"Search returned a status code of {results.ApiCall?.HttpStatusCode}");
            }

            return new SearchResult<StandardProviderSearchResultsItem> { Hits = documents, Total = results.Total };
        }

        public SearchResult<FrameworkProviderSearchResultsItem> SearchByFrameworkLocation(int code, Coordinate geoPoint)
        {
            var client = _elasticsearchClientFactory.Create();
            var qryStr = CreateFrameworkProviderRawQuery(code.ToString(), geoPoint);

            var results = client
                .Search<FrameworkProviderSearchResultsItem>(s => s
                .Index(_applicationSettings.ProviderIndexAlias)
                .From(0)
                .Size(1000)
                .Query(q => q
                    .Raw(qryStr))
                .Sort(ss => ss
                    .GeoDistance(g => g
                        .Field("locationPoint")
                        .PinTo(new GeoLocation(geoPoint.Lat, geoPoint.Lon))
                        .Unit(DistanceUnit.Miles)
                        .Ascending())));

            var documents = results.Hits.Select(hit => new FrameworkProviderSearchResultsItem
            {
                Id = hit.Source.Id,
                UkPrn = hit.Source.UkPrn,
                Address = hit.Source.Address,
                ContactUsUrl = hit.Source.ContactUsUrl,
                DeliveryModes = hit.Source.DeliveryModes,
                Email = hit.Source.Email,
                EmployerSatisfaction = hit.Source.EmployerSatisfaction * 10,
                LearnerSatisfaction = hit.Source.LearnerSatisfaction * 10,
                LocationId = hit.Source.LocationId,
                LocationName = hit.Source.LocationName,
                ApprenticeshipMarketingInfo = hit.Source.ApprenticeshipMarketingInfo,
                Name = hit.Source.Name,
                Phone = hit.Source.Phone,
                FrameworkCode = hit.Source.FrameworkCode,
                PathwayCode = hit.Source.PathwayCode,
                StandardInfoUrl = hit.Source.StandardInfoUrl,
                Level = hit.Source.Level,
                Website = hit.Source.Website,
                Distance = hit.Sorts != null ? Math.Round(double.Parse(hit.Sorts.DefaultIfEmpty(0).First().ToString()), 1) : 0
            }).OrderByDescending(x => x.DeliveryModes?.Contains("100PercentEmployer")).ToList();

            if (results.ApiCall?.HttpStatusCode != 200)
            {
                throw new SearchException($"Search returned a status code of {results.ApiCall?.HttpStatusCode}");
            }

            return new SearchResult<FrameworkProviderSearchResultsItem> { Hits = documents, Total = results.Total };
        }

        private string CreateStandardProviderRawQuery(string code, Coordinate location)
        {
            return CreateFullQuery("standardCode", code, location);
        }

        private string CreateFrameworkProviderRawQuery(string code, Coordinate location)
        {
            return CreateFullQuery("frameworkId", code, location);
        }

        private string CreateFullQuery(string specificPart, string code, Coordinate location)
        {
            return string.Concat(
                @"{""filtered"": { ""query"": { ""match"": { """,
                specificPart,
                @""": """,
                code,
                @""" }}, ""filter"": { ""geo_shape"": { ""location"": { ""shape"": { ""type"": ""point"", ""coordinates"": [",
                location.Lon,
                ", ",
                location.Lat,
                "] }}}}}}");
        }
    }
}