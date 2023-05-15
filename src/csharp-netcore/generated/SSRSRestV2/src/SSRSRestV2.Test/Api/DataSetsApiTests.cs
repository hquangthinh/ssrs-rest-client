/*
 * SQL Server 2017 Reporting Services REST API
 *
 * The SQL Server 2017 Reporting Services REST API provides programmatic access to the report server catalog.  For example, basic CRUD operations can be done on folders, reports, KPIs, data sources, datasets, refresh plans, subscriptions, etc.     The REST API can also be used to provide more advanced functionality, such as: * Navigate the folder hierarchy * Discover the contents of a folder * Download a report definition * Modify default report parameters * Change or execute a refresh plan * A whole lot more  The REST API is a RESTful successor to the legacy [SOAP API](https://msdn.microsoft.com/library/reportservice2010.reportingservice2010.aspx).  Happy coding!  __API samples:__ https://github.com/Microsoft/Reporting-Services  __Developer documentation:__ https://docs.microsoft.com/sql/reporting-services/reporting-services-developer-documentation  __Team Blog:__ https://blogs.msdn.microsoft.com/sqlrsteamblog  __Support forums:__ https://social.msdn.microsoft.com/Forums/en-US/home?forum=sqlreportingservices 
 *
 * The version of the OpenAPI document: 2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using SSRSRestV2.IApi;
using SSRSRestV2.Model;


/* *********************************************************************************
*              Follow these manual steps to construct tests.
*              This file will not be overwritten.
*  *********************************************************************************
* 1. Navigate to ApiTests.Base.cs and ensure any tokens are being created correctly.
*    Take care not to commit credentials to any repository.
*
* 2. Mocking is coordinated by ApiTestsBase#AddApiHttpClients.
*    To mock the client, use the generic AddApiHttpClients.
*    To mock the server, change the client's BaseAddress.
*
* 3. Locate the test you want below
*      - remove the skip property from the Fact attribute
*      - set the value of any variables if necessary
*
* 4. Run the tests and ensure they work.
*
*/


namespace SSRSRestV2.Test.Api
{
    /// <summary>
    ///  Class for testing DataSetsApi
    /// </summary>
    public sealed class DataSetsApiTests : ApiTestsBase
    {
        private readonly IApi.IDataSetsApi _instance;

        public DataSetsApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IApi.IDataSetsApi>();
        }


        /// <summary>
        /// Test AddDataSet
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task AddDataSetAsyncTest()
        {
            DataSet dataSet = default;
            var response = await _instance.AddDataSetAsync(dataSet);
            Assert.IsType<DataSet>(response);
        }

        /// <summary>
        /// Test DeleteDataSet
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task DeleteDataSetAsyncTest()
        {
            string id = default;
            await _instance.DeleteDataSetAsync(id);
        }

        /// <summary>
        /// Test GetDataSet
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDataSetAsyncTest()
        {
            string id = default;
            var response = await _instance.GetDataSetAsync(id);
            Assert.IsType<DataSet>(response);
        }

        /// <summary>
        /// Test GetDataSetAggregatedValue
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDataSetAggregatedValueAsyncTest()
        {
            string id = default;
            string columnName = default;
            string aggregation = default;
            DataSetAggregateValueParameters parameters = default;
            var response = await _instance.GetDataSetAggregatedValueAsync(id, columnName, aggregation, parameters);
            Assert.IsType<List<double>>(response);
        }

        /// <summary>
        /// Test GetDataSetAllowedActions
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDataSetAllowedActionsAsyncTest()
        {
            string id = default;
            var response = await _instance.GetDataSetAllowedActionsAsync(id);
            Assert.IsType<ODataAllowedActions>(response);
        }

        /// <summary>
        /// Test GetDataSetCacheOptions
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDataSetCacheOptionsAsyncTest()
        {
            string id = default;
            var response = await _instance.GetDataSetCacheOptionsAsync(id);
            Assert.IsType<CacheOptions>(response);
        }

        /// <summary>
        /// Test GetDataSetCacheRefreshPlans
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDataSetCacheRefreshPlansAsyncTest()
        {
            string id = default;
            var response = await _instance.GetDataSetCacheRefreshPlansAsync(id);
            Assert.IsType<ODataCacheRefreshPlans>(response);
        }

        /// <summary>
        /// Test GetDataSetContent
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDataSetContentAsyncTest()
        {
            string id = default;
            var response = await _instance.GetDataSetContentAsync(id);
            Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test GetDataSetData
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDataSetDataAsyncTest()
        {
            string id = default;
            DataSetDataParameters parameters = default;
            decimal? maxRows = default;
            var response = await _instance.GetDataSetDataAsync(id, parameters, maxRows);
            Assert.IsType<DataSetData>(response);
        }

        /// <summary>
        /// Test GetDataSetDataSource
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDataSetDataSourceAsyncTest()
        {
            string id = default;
            string dataSourceId = default;
            var response = await _instance.GetDataSetDataSourceAsync(id, dataSourceId);
            Assert.IsType<DataSource>(response);
        }

        /// <summary>
        /// Test GetDataSetDataSources
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDataSetDataSourcesAsyncTest()
        {
            string id = default;
            var response = await _instance.GetDataSetDataSourcesAsync(id);
            Assert.IsType<List<DataSource>>(response);
        }

        /// <summary>
        /// Test GetDataSetDependentItems
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDataSetDependentItemsAsyncTest()
        {
            string id = default;
            var response = await _instance.GetDataSetDependentItemsAsync(id);
            Assert.IsType<ODataDependentItems>(response);
        }

        /// <summary>
        /// Test GetDataSetParameterDefinitions
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDataSetParameterDefinitionsAsyncTest()
        {
            string id = default;
            var response = await _instance.GetDataSetParameterDefinitionsAsync(id);
            Assert.IsType<ODataReportParameterDefinitions>(response);
        }

        /// <summary>
        /// Test GetDataSetPolicies
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDataSetPoliciesAsyncTest()
        {
            string id = default;
            var response = await _instance.GetDataSetPoliciesAsync(id);
            Assert.IsType<List<ItemPolicy>>(response);
        }

        /// <summary>
        /// Test GetDataSetSchema
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDataSetSchemaAsyncTest()
        {
            string id = default;
            var response = await _instance.GetDataSetSchemaAsync(id);
            Assert.IsType<DataSetSchema>(response);
        }

        /// <summary>
        /// Test GetDataSets
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDataSetsAsyncTest()
        {
            int? top = default;
            int? skip = default;
            string filter = default;
            string count = default;
            string orderBy = default;
            string select = default;
            var response = await _instance.GetDataSetsAsync(top, skip, filter, count, orderBy, select);
            Assert.IsType<ODataDataSets>(response);
        }

        /// <summary>
        /// Test GetDatasetProperties
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDatasetPropertiesAsyncTest()
        {
            string id = default;
            List<string> properties = default;
            var response = await _instance.GetDatasetPropertiesAsync(id, properties);
            Assert.IsType<ODataProperties>(response);
        }

        /// <summary>
        /// Test SetDataSetCacheOptions
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task SetDataSetCacheOptionsAsyncTest()
        {
            CacheOptions cacheOptions = default;
            string id = default;
            await _instance.SetDataSetCacheOptionsAsync(cacheOptions, id);
        }

        /// <summary>
        /// Test SetDataSetDataSource
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task SetDataSetDataSourceAsyncTest()
        {
            DataSource dataSource = default;
            string id = default;
            string dataSourceId = default;
            await _instance.SetDataSetDataSourceAsync(dataSource, id, dataSourceId);
        }

        /// <summary>
        /// Test SetDataSetDataSources
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task SetDataSetDataSourcesAsyncTest()
        {
            DataSource dataSource = default;
            string id = default;
            await _instance.SetDataSetDataSourcesAsync(dataSource, id);
        }

        /// <summary>
        /// Test SetDataSetPolicies
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task SetDataSetPoliciesAsyncTest()
        {
            List<ItemPolicy> itemPolicy = default;
            string id = default;
            await _instance.SetDataSetPoliciesAsync(itemPolicy, id);
        }

        /// <summary>
        /// Test UpdateDataSet
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateDataSetAsyncTest()
        {
            DataSet dataSet = default;
            string id = default;
            await _instance.UpdateDataSetAsync(dataSet, id);
        }

        /// <summary>
        /// Test UpdateDataSetParameterDefinitions
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateDataSetParameterDefinitionsAsyncTest()
        {
            List<ReportParameterDefinitionPatch> parameterDefinitions = default;
            string id = default;
            await _instance.UpdateDataSetParameterDefinitionsAsync(parameterDefinitions, id);
        }

        /// <summary>
        /// Test UpdateDatasetProperties
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateDatasetPropertiesAsyncTest()
        {
            List<Property> properties = default;
            string id = default;
            await _instance.UpdateDatasetPropertiesAsync(properties, id);
        }
    }
}
