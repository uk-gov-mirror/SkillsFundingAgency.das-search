﻿namespace Sfa.Eds.Das.ProviderIndexer.Clients
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Sfa.Eds.Das.Indexer.Common.Extensions;
    using Sfa.Eds.Das.ProviderIndexer.Models;
    using Sfa.Eds.Das.ProviderIndexer.Settings;
    using Sfa.Eds.Das.Tools.MetaDataCreationTool.Services.Interfaces;

    public class FcsActiveProvidersClient : IActiveProviderClient
    {
        private readonly IVstsClient _vstsClient;

        private readonly ISettings _settings;

        public FcsActiveProvidersClient(IVstsClient vstsClient, ISettings settings)
        {
            _vstsClient = vstsClient;
            _settings = settings;
        }

        public async Task<IEnumerable<string>> GetProviders()
        {
            var path = CreatePath();
            var result = _vstsClient.GetFileContent(path);
            var records = result.FromCsv<FcsProviderRecord>();
            return records.Select(x => x.UkPrn);
        }

        private string CreatePath()
        {
            var path = $"fcs/{_settings.EnvironmentName}/fcs-active.csv";
            return string.Format(_settings.VstsGitGetFilesUrlFormat, path);
        }
    }
}