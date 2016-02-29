namespace Sfa.Eds.Das.Tools.MetaDataCreationTool.Services.Interfaces
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using Sfa.Eds.Das.Tools.MetaDataCreationTool.Helper;
    using Sfa.Eds.Das.Tools.MetaDataCreationTool.Models;
    using Sfa.Eds.Das.Tools.MetaDataCreationTool.Models.Git;

    public class VstsClient : IVstsClient
    {
        private readonly ISettings _settings;
        private readonly IGitDynamicModelGenerator _gitDynamicModelGenerator;
        private readonly IHttpHelper _httpHelper;

        public VstsClient(ISettings settings, IGitDynamicModelGenerator gitDynamicModelGenerator, IHttpHelper httpHelper)
        {
            _settings = settings;
            _gitDynamicModelGenerator = gitDynamicModelGenerator;
            _httpHelper = httpHelper;
        }

        public void PushCommit(List<StandardObject> items)
        {
            var body = _gitDynamicModelGenerator.GenerateCommitBody(_settings.GitBranch, GetLatesCommit(), items);
            _httpHelper.Post(_settings.VstsGitPushUrl, body, _settings.GitUsername, _settings.GitPassword);
        }

        private string GetLatesCommit()
        {
            var commitResponse = _httpHelper.DownloadString(_settings.VstsGitAllCommitsUrl, _settings.GitUsername, _settings.GitPassword);
            var gitTree = JsonConvert.DeserializeObject<GitTree>(commitResponse);
            if (gitTree == null)
            {
                return string.Empty;
            }

            return gitTree.Value[0]?.CommitId;
        }

        public IEnumerable<string> GetAllFileContents(string path)
        {
            var blobs = GetAllBlobs(path);

            if (blobs == null)
            {
                return new List<string>();
            }

            var standardsAsJson = new List<string>();
            foreach (var blob in blobs)
            {
                var str = _httpHelper.DownloadString(blob.Url, _settings.GitUsername, _settings.GitPassword);
                standardsAsJson.Add(str);
            }

            return standardsAsJson;
        }

        public string GetFileContent(string path)
        {
            return GetSpecificBlob(path);
        }

        private IEnumerable<Entity> GetAllBlobs(string path)
        {
            var url = string.Format(_settings.VstsGitGetFilesUrlFormat, path);
            var folderTreeStr = _httpHelper.DownloadString(url, _settings.GitUsername, _settings.GitPassword);
            var tree = JsonConvert.DeserializeObject<GitTree>(folderTreeStr);

            return tree?.Value.Where(x => x.IsBlob);
        }

        private string GetSpecificBlob(string path)
        {
            var url = string.Format(_settings.VstsGitGetFilesUrlFormat, path);
            return _httpHelper.DownloadString(url, _settings.GitUsername, _settings.GitPassword);
        }
    }
}