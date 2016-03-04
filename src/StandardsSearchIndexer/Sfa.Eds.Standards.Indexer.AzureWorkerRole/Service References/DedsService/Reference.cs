﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sfa.Eds.Das.Indexer.AzureWorkerRole.DedsService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.imservices.org.uk/dcft/deds/1.0", ConfigurationName="DedsService.IDedsSearchService")]
    public interface IDedsSearchService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetDataSet", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetDataSetResponse")]
        Sfa.Infrastructure.DedsService.DataSetDescriptor GetDataSet(System.Guid dataSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetDataSet", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetDataSetResponse")]
        System.Threading.Tasks.Task<Sfa.Infrastructure.DedsService.DataSetDescriptor> GetDataSetAsync(System.Guid dataSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetDataSetByCode", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetDataSetByCodeResp" +
            "onse")]
        Sfa.Infrastructure.DedsService.DataSetDescriptor GetDataSetByCode(string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetDataSetByCode", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetDataSetByCodeResp" +
            "onse")]
        System.Threading.Tasks.Task<Sfa.Infrastructure.DedsService.DataSetDescriptor> GetDataSetByCodeAsync(string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverDataSetVersi" +
            "ons", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverDataSetVersi" +
            "onsResponse")]
        Sfa.Infrastructure.DedsService.DataSetVersionDescriptor[] DiscoverDataSetVersions(Sfa.Infrastructure.DedsService.DiscoverDataSetVersionsCriteria discoverDataSetVersionsCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverDataSetVersi" +
            "ons", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverDataSetVersi" +
            "onsResponse")]
        System.Threading.Tasks.Task<Infrastructure.DedsService.DataSetVersionDescriptor[]> DiscoverDataSetVersionsAsync(Infrastructure.DedsService.DiscoverDataSetVersionsCriteria discoverDataSetVersionsCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverQueries", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverQueriesRespo" +
            "nse")]
        Infrastructure.DedsService.QueryDescriptor[] DiscoverQueries(Infrastructure.DedsService.DiscoverQueriesCriteria discoverQueriesCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverQueries", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverQueriesRespo" +
            "nse")]
        System.Threading.Tasks.Task<Infrastructure.DedsService.QueryDescriptor[]> DiscoverQueriesAsync(Infrastructure.DedsService.DiscoverQueriesCriteria discoverQueriesCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverFiles", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverFilesRespons" +
            "e")]
        Infrastructure.DedsService.FileDescriptor[] DiscoverFiles(Infrastructure.DedsService.DiscoverFilesCriteria discoverFilesCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverFiles", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverFilesRespons" +
            "e")]
        System.Threading.Tasks.Task<Infrastructure.DedsService.FileDescriptor[]> DiscoverFilesAsync(Infrastructure.DedsService.DiscoverFilesCriteria discoverFilesCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverFilesCount", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverFilesCountRe" +
            "sponse")]
        long DiscoverFilesCount(Infrastructure.DedsService.DiscoverFilesCriteria discoverFilesCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverFilesCount", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverFilesCountRe" +
            "sponse")]
        System.Threading.Tasks.Task<long> DiscoverFilesCountAsync(Infrastructure.DedsService.DiscoverFilesCriteria discoverFilesCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/ExecuteQuery", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/ExecuteQueryResponse" +
            "")]
        Infrastructure.DedsService.QueryResults[] ExecuteQuery(System.Guid queryId, Infrastructure.DedsService.QueryExecution queryExecution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/ExecuteQuery", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/ExecuteQueryResponse" +
            "")]
        System.Threading.Tasks.Task<Infrastructure.DedsService.QueryResults[]> ExecuteQueryAsync(System.Guid queryId, Infrastructure.DedsService.QueryExecution queryExecution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetTotalCount", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetTotalCountRespons" +
            "e")]
        long GetTotalCount(System.Guid queryId, Infrastructure.DedsService.QueryExecution queryExecution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetTotalCount", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetTotalCountRespons" +
            "e")]
        System.Threading.Tasks.Task<long> GetTotalCountAsync(System.Guid queryId, Infrastructure.DedsService.QueryExecution queryExecution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/ExecuteQueryByCode", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/ExecuteQueryByCodeRe" +
            "sponse")]
        Infrastructure.DedsService.QueryResults[] ExecuteQueryByCode(System.Guid dataSetVersionId, string queryCode, Infrastructure.DedsService.QueryExecution queryExecution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/ExecuteQueryByCode", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/ExecuteQueryByCodeRe" +
            "sponse")]
        System.Threading.Tasks.Task<Infrastructure.DedsService.QueryResults[]> ExecuteQueryByCodeAsync(System.Guid dataSetVersionId, string queryCode, Infrastructure.DedsService.QueryExecution queryExecution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetTotalCountByCode", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetTotalCountByCodeR" +
            "esponse")]
        long GetTotalCountByCode(System.Guid dataSetVersionId, string queryCode, Infrastructure.DedsService.QueryExecution queryExecution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetTotalCountByCode", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetTotalCountByCodeR" +
            "esponse")]
        System.Threading.Tasks.Task<long> GetTotalCountByCodeAsync(System.Guid dataSetVersionId, string queryCode, Infrastructure.DedsService.QueryExecution queryExecution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetFile", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetFileResponse")]
        Infrastructure.DedsService.FileData GetFile(System.Guid fileId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetFile", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetFileResponse")]
        System.Threading.Tasks.Task<Infrastructure.DedsService.FileData> GetFileAsync(System.Guid fileId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetLatestPublishedDa" +
            "taSetVersion", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetLatestPublishedDa" +
            "taSetVersionResponse")]
        Infrastructure.DedsService.DataSetVersionDescriptor GetLatestPublishedDataSetVersion(string dataSetCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetLatestPublishedDa" +
            "taSetVersion", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetLatestPublishedDa" +
            "taSetVersionResponse")]
        System.Threading.Tasks.Task<Infrastructure.DedsService.DataSetVersionDescriptor> GetLatestPublishedDataSetVersionAsync(string dataSetCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetPublishedDataSetV" +
            "ersions", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetPublishedDataSetV" +
            "ersionsResponse")]
        Infrastructure.DedsService.DataSetVersionDescriptor[] GetPublishedDataSetVersions(string dataSetCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetPublishedDataSetV" +
            "ersions", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetPublishedDataSetV" +
            "ersionsResponse")]
        System.Threading.Tasks.Task<Infrastructure.DedsService.DataSetVersionDescriptor[]> GetPublishedDataSetVersionsAsync(string dataSetCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDedsSearchServiceChannel : Sfa.Eds.Das.Indexer.AzureWorkerRole.DedsService.IDedsSearchService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DedsSearchServiceClient : System.ServiceModel.ClientBase<Sfa.Eds.Das.Indexer.AzureWorkerRole.DedsService.IDedsSearchService>, Sfa.Eds.Das.Indexer.AzureWorkerRole.DedsService.IDedsSearchService {
        
        public DedsSearchServiceClient() {
        }
        
        public DedsSearchServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DedsSearchServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DedsSearchServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DedsSearchServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Infrastructure.DedsService.DataSetDescriptor GetDataSet(System.Guid dataSetId) {
            return base.Channel.GetDataSet(dataSetId);
        }
        
        public System.Threading.Tasks.Task<Infrastructure.DedsService.DataSetDescriptor> GetDataSetAsync(System.Guid dataSetId) {
            return base.Channel.GetDataSetAsync(dataSetId);
        }
        
        public Infrastructure.DedsService.DataSetDescriptor GetDataSetByCode(string code) {
            return base.Channel.GetDataSetByCode(code);
        }
        
        public System.Threading.Tasks.Task<Infrastructure.DedsService.DataSetDescriptor> GetDataSetByCodeAsync(string code) {
            return base.Channel.GetDataSetByCodeAsync(code);
        }
        
        public Infrastructure.DedsService.DataSetVersionDescriptor[] DiscoverDataSetVersions(Infrastructure.DedsService.DiscoverDataSetVersionsCriteria discoverDataSetVersionsCriteria) {
            return base.Channel.DiscoverDataSetVersions(discoverDataSetVersionsCriteria);
        }
        
        public System.Threading.Tasks.Task<Infrastructure.DedsService.DataSetVersionDescriptor[]> DiscoverDataSetVersionsAsync(Infrastructure.DedsService.DiscoverDataSetVersionsCriteria discoverDataSetVersionsCriteria) {
            return base.Channel.DiscoverDataSetVersionsAsync(discoverDataSetVersionsCriteria);
        }
        
        public Infrastructure.DedsService.QueryDescriptor[] DiscoverQueries(Infrastructure.DedsService.DiscoverQueriesCriteria discoverQueriesCriteria) {
            return base.Channel.DiscoverQueries(discoverQueriesCriteria);
        }
        
        public System.Threading.Tasks.Task<Infrastructure.DedsService.QueryDescriptor[]> DiscoverQueriesAsync(Infrastructure.DedsService.DiscoverQueriesCriteria discoverQueriesCriteria) {
            return base.Channel.DiscoverQueriesAsync(discoverQueriesCriteria);
        }
        
        public Infrastructure.DedsService.FileDescriptor[] DiscoverFiles(Infrastructure.DedsService.DiscoverFilesCriteria discoverFilesCriteria) {
            return base.Channel.DiscoverFiles(discoverFilesCriteria);
        }
        
        public System.Threading.Tasks.Task<Infrastructure.DedsService.FileDescriptor[]> DiscoverFilesAsync(Infrastructure.DedsService.DiscoverFilesCriteria discoverFilesCriteria) {
            return base.Channel.DiscoverFilesAsync(discoverFilesCriteria);
        }
        
        public long DiscoverFilesCount(Infrastructure.DedsService.DiscoverFilesCriteria discoverFilesCriteria) {
            return base.Channel.DiscoverFilesCount(discoverFilesCriteria);
        }
        
        public System.Threading.Tasks.Task<long> DiscoverFilesCountAsync(Infrastructure.DedsService.DiscoverFilesCriteria discoverFilesCriteria) {
            return base.Channel.DiscoverFilesCountAsync(discoverFilesCriteria);
        }
        
        public Infrastructure.DedsService.QueryResults[] ExecuteQuery(System.Guid queryId, Infrastructure.DedsService.QueryExecution queryExecution) {
            return base.Channel.ExecuteQuery(queryId, queryExecution);
        }
        
        public System.Threading.Tasks.Task<Infrastructure.DedsService.QueryResults[]> ExecuteQueryAsync(System.Guid queryId, Infrastructure.DedsService.QueryExecution queryExecution) {
            return base.Channel.ExecuteQueryAsync(queryId, queryExecution);
        }
        
        public long GetTotalCount(System.Guid queryId, Infrastructure.DedsService.QueryExecution queryExecution) {
            return base.Channel.GetTotalCount(queryId, queryExecution);
        }
        
        public System.Threading.Tasks.Task<long> GetTotalCountAsync(System.Guid queryId, Infrastructure.DedsService.QueryExecution queryExecution) {
            return base.Channel.GetTotalCountAsync(queryId, queryExecution);
        }
        
        public Infrastructure.DedsService.QueryResults[] ExecuteQueryByCode(System.Guid dataSetVersionId, string queryCode, Infrastructure.DedsService.QueryExecution queryExecution) {
            return base.Channel.ExecuteQueryByCode(dataSetVersionId, queryCode, queryExecution);
        }
        
        public System.Threading.Tasks.Task<Infrastructure.DedsService.QueryResults[]> ExecuteQueryByCodeAsync(System.Guid dataSetVersionId, string queryCode, Infrastructure.DedsService.QueryExecution queryExecution) {
            return base.Channel.ExecuteQueryByCodeAsync(dataSetVersionId, queryCode, queryExecution);
        }
        
        public long GetTotalCountByCode(System.Guid dataSetVersionId, string queryCode, Infrastructure.DedsService.QueryExecution queryExecution) {
            return base.Channel.GetTotalCountByCode(dataSetVersionId, queryCode, queryExecution);
        }
        
        public System.Threading.Tasks.Task<long> GetTotalCountByCodeAsync(System.Guid dataSetVersionId, string queryCode, Infrastructure.DedsService.QueryExecution queryExecution) {
            return base.Channel.GetTotalCountByCodeAsync(dataSetVersionId, queryCode, queryExecution);
        }
        
        public Infrastructure.DedsService.FileData GetFile(System.Guid fileId) {
            return base.Channel.GetFile(fileId);
        }
        
        public System.Threading.Tasks.Task<Infrastructure.DedsService.FileData> GetFileAsync(System.Guid fileId) {
            return base.Channel.GetFileAsync(fileId);
        }
        
        public Infrastructure.DedsService.DataSetVersionDescriptor GetLatestPublishedDataSetVersion(string dataSetCode) {
            return base.Channel.GetLatestPublishedDataSetVersion(dataSetCode);
        }
        
        public System.Threading.Tasks.Task<Infrastructure.DedsService.DataSetVersionDescriptor> GetLatestPublishedDataSetVersionAsync(string dataSetCode) {
            return base.Channel.GetLatestPublishedDataSetVersionAsync(dataSetCode);
        }
        
        public Infrastructure.DedsService.DataSetVersionDescriptor[] GetPublishedDataSetVersions(string dataSetCode) {
            return base.Channel.GetPublishedDataSetVersions(dataSetCode);
        }
        
        public System.Threading.Tasks.Task<Infrastructure.DedsService.DataSetVersionDescriptor[]> GetPublishedDataSetVersionsAsync(string dataSetCode) {
            return base.Channel.GetPublishedDataSetVersionsAsync(dataSetCode);
        }
    }
}
