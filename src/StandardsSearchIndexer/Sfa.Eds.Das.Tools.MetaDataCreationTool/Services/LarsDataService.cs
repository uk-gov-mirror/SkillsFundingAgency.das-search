﻿namespace Sfa.Eds.Das.Tools.MetaDataCreationTool.Services
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;

    using Newtonsoft.Json;

    using Sfa.Eds.Das.Tools.MetaDataCreationTool.Helper;
    using Sfa.Eds.Das.Tools.MetaDataCreationTool.Models;
    using Sfa.Eds.Das.Tools.MetaDataCreationTool.Models.GovLearn;
    using Sfa.Eds.Das.Tools.MetaDataCreationTool.Services.Interfaces;

    public sealed class LarsDataService : ILarsDataService
    {
        private readonly ISettings _settings;
        private readonly IReadStandardsFromCsv _csvService;
        private readonly IHttpHelper _httpHelper;
        private readonly IUnzipFiles _fileExtractor;

        public LarsDataService(ISettings settings, IReadStandardsFromCsv csvService, IHttpHelper httpHelper, IUnzipFiles fileExtractor)
        {
            _settings = settings;
            _csvService = csvService;
            _httpHelper = httpHelper;
            _fileExtractor = fileExtractor;
        }

        public IEnumerable<Standard> GetListOfCurrentStandards()
        {
            var zipFilePath = GetZipFilePath();
            var zipFile = _httpHelper.DownloadFile(zipFilePath, _settings.WorkingFolder);
            var extractedPath = _fileExtractor.ExtractFileFromZip(zipFile, _settings.CsvFileName);

            var csvFile = Path.Combine(extractedPath, _settings.CsvFileName);

            if (!File.Exists(csvFile))
            {
                Console.WriteLine($"Can't find file {csvFile}");

                return new List<Standard>();
            }

            var standards = _csvService.ReadStandardsFromFile(csvFile);

            return standards;
        }

        private string GetZipFilePath()
        {
            var json = _httpHelper.DownloadString(_settings.GovLearningUrl, null, null);
            var govLearnResponse = JsonConvert.DeserializeObject<GovLearnResponse>(json);

            if (govLearnResponse == null)
            {
                return string.Empty;
            }

            var govLearnResource = govLearnResponse.Resources.FirstOrDefault(m => m.Description.StartsWith("Current download"));

            return govLearnResource?.Url ?? string.Empty;
        }
    }
}
