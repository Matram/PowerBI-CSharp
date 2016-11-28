// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V1
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Datasets operations.
    /// </summary>
    public partial interface IDatasets
    {
        /// <summary>
        /// Returns the datasets
        /// </summary>
        /// <param name='collectionName'>
        /// The workspace collection name
        /// </param>
        /// <param name='workspaceId'>
        /// The workspace id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ODataResponseListDataset>> GetDatasetsWithHttpMessagesAsync(string collectionName, string workspaceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Post a new entity to datasets
        /// </summary>
        /// <param name='collectionName'>
        /// The workspace collection name
        /// </param>
        /// <param name='workspaceId'>
        /// The workspace id
        /// </param>
        /// <param name='dataset'>
        /// The entity to post
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> PostDatasetWithHttpMessagesAsync(string collectionName, string workspaceId, Dataset dataset, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Posts new data rows into the specified table
        /// </summary>
        /// <param name='collectionName'>
        /// The workspace collection name
        /// </param>
        /// <param name='workspaceId'>
        /// The workspace id
        /// </param>
        /// <param name='datasetKey'>
        /// The dataset id
        /// </param>
        /// <param name='tableName'>
        /// The table name
        /// </param>
        /// <param name='requestMessage'>
        /// The request message
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> PostRowsWithHttpMessagesAsync(string collectionName, string workspaceId, string datasetKey, string tableName, object requestMessage, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes all rows from the specified table
        /// </summary>
        /// <param name='collectionName'>
        /// The workspace collection name
        /// </param>
        /// <param name='workspaceId'>
        /// The workspace id
        /// </param>
        /// <param name='datasetKey'>
        /// The dataset id
        /// </param>
        /// <param name='tableName'>
        /// The table name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> DeleteRowsWithHttpMessagesAsync(string collectionName, string workspaceId, string datasetKey, string tableName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all tables within the specified dataset
        /// </summary>
        /// <param name='collectionName'>
        /// The workspace collection name
        /// </param>
        /// <param name='workspaceId'>
        /// The workspace id
        /// </param>
        /// <param name='datasetKey'>
        /// The dataset id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ODataResponseListTable>> GetTablesWithHttpMessagesAsync(string collectionName, string workspaceId, string datasetKey, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a schema and metadata for the specified table
        /// </summary>
        /// <param name='collectionName'>
        /// The workspace collection name
        /// </param>
        /// <param name='workspaceId'>
        /// The workspace id
        /// </param>
        /// <param name='datasetKey'>
        /// The dataset id
        /// </param>
        /// <param name='tableName'>
        /// The table name
        /// </param>
        /// <param name='requestMessage'>
        /// The request message
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> PutTableWithHttpMessagesAsync(string collectionName, string workspaceId, string datasetKey, string tableName, object requestMessage, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the dataset metadata for the specifeid dataset id
        /// </summary>
        /// <param name='collectionName'>
        /// The workspace collection name
        /// </param>
        /// <param name='workspaceId'>
        /// The workspace id
        /// </param>
        /// <param name='datasetKey'>
        /// The dataset id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Dataset>> GetDatasetByIdWithHttpMessagesAsync(string collectionName, string workspaceId, string datasetKey, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the dataset with the specified id
        /// </summary>
        /// <param name='collectionName'>
        /// The workspace collection name
        /// </param>
        /// <param name='workspaceId'>
        /// The workspace id
        /// </param>
        /// <param name='datasetKey'>
        /// The dataset id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> DeleteDatasetByIdWithHttpMessagesAsync(string collectionName, string workspaceId, string datasetKey, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of bound gateway datasources for the specified dataset
        /// </summary>
        /// <param name='collectionName'>
        /// The workspace collection name
        /// </param>
        /// <param name='workspaceId'>
        /// The workspace id
        /// </param>
        /// <param name='datasetKey'>
        /// The dataset id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ODataResponseListGatewayDatasource>> GetGatewayDatasourcesWithHttpMessagesAsync(string collectionName, string workspaceId, string datasetKey, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of datasource for the specified dataset
        /// </summary>
        /// <param name='collectionName'>
        /// The workspace collection name
        /// </param>
        /// <param name='workspaceId'>
        /// The workspace id
        /// </param>
        /// <param name='datasetKey'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ODataResponseListDatasource>> GetDatasourcesWithHttpMessagesAsync(string collectionName, string workspaceId, string datasetKey, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sets all connections for the specified dataset
        /// </summary>
        /// <param name='collectionName'>
        /// The workspace collection name
        /// </param>
        /// <param name='workspaceId'>
        /// The workspace id
        /// </param>
        /// <param name='datasetKey'>
        /// The dataset id
        /// </param>
        /// <param name='parameters'>
        /// The body
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> SetAllConnectionsWithHttpMessagesAsync(string collectionName, string workspaceId, string datasetKey, IDictionary<string, object> parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Bind dataset to gateway
        /// </summary>
        /// <param name='collectionName'>
        /// The workspace collection name
        /// </param>
        /// <param name='datasetKey'>
        /// The dataset id
        /// </param>
        /// <param name='bindToGatewayRequest'>
        /// The bind to gateway request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> BindToGatewayWithHttpMessagesAsync(string collectionName, string datasetKey, BindToGatewayRequest bindToGatewayRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
