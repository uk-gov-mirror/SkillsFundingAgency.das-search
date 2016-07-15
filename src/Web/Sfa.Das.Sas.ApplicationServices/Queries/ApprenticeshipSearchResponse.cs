﻿using System.Collections.Generic;
using Sfa.Das.Sas.ApplicationServices.Models;

namespace Sfa.Das.Sas.ApplicationServices.Queries
{
    public class ApprenticeshipSearchResponse
    {
        public enum ResponseCodes
        {
            Success,
            SearchFailed,
            SearchPageLimitExceeded,
            NoSearchResultsFound
        }

        public long TotalResults { get; set; }

        public int ResultsToTake { get; set; }

        public int ActualPage { get; set; }

        public int LastPage { get; set; }

        public string SearchTerm { get; set; }

        public string SortOrder { get; set; }

        public bool HasError { get; set; }

        public IEnumerable<ApprenticeshipSearchResultsItem> Results { get; set; }

        public Dictionary<int, long?> AggregationLevel { get; set; }

        public Dictionary<int, bool> ShortlistedStandards { get; set; }

        public Dictionary<int, bool> ShortlistedFrameworks { get; set; }

        public ResponseCodes StatusCode { get; set; }
        public List<int> SelectedLevels { get; set; }
    }
}
