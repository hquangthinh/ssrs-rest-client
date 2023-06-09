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
    ///  Class for testing ResourcesApi
    /// </summary>
    public sealed class ResourcesApiTests : ApiTestsBase
    {
        private readonly IApi.IResourcesApi _instance;

        public ResourcesApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IApi.IResourcesApi>();
        }


        /// <summary>
        /// Test AddResource
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task AddResourceAsyncTest()
        {
            Resource resource = default;
            var response = await _instance.AddResourceAsync(resource);
            Assert.IsType<Resource>(response);
        }

        /// <summary>
        /// Test DeleteResource
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task DeleteResourceAsyncTest()
        {
            string id = default;
            await _instance.DeleteResourceAsync(id);
        }

        /// <summary>
        /// Test GetResource
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetResourceAsyncTest()
        {
            string id = default;
            var response = await _instance.GetResourceAsync(id);
            Assert.IsType<Resource>(response);
        }

        /// <summary>
        /// Test GetResourceAllowedActions
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetResourceAllowedActionsAsyncTest()
        {
            string id = default;
            var response = await _instance.GetResourceAllowedActionsAsync(id);
            Assert.IsType<ODataAllowedActions>(response);
        }

        /// <summary>
        /// Test GetResourceContent
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetResourceContentAsyncTest()
        {
            string id = default;
            var response = await _instance.GetResourceContentAsync(id);
            Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test GetResourcePolicies
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetResourcePoliciesAsyncTest()
        {
            string id = default;
            var response = await _instance.GetResourcePoliciesAsync(id);
            Assert.IsType<List<ItemPolicy>>(response);
        }

        /// <summary>
        /// Test GetResourceProperties
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetResourcePropertiesAsyncTest()
        {
            string id = default;
            List<string> properties = default;
            var response = await _instance.GetResourcePropertiesAsync(id, properties);
            Assert.IsType<ODataProperties>(response);
        }

        /// <summary>
        /// Test GetResources
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetResourcesAsyncTest()
        {
            int? top = default;
            int? skip = default;
            string filter = default;
            string count = default;
            var response = await _instance.GetResourcesAsync(top, skip, filter, count);
            Assert.IsType<ODataResources>(response);
        }

        /// <summary>
        /// Test SetResourcePolicies
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task SetResourcePoliciesAsyncTest()
        {
            List<ItemPolicy> policies = default;
            string id = default;
            await _instance.SetResourcePoliciesAsync(policies, id);
        }

        /// <summary>
        /// Test UpdateResource
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateResourceAsyncTest()
        {
            Resource resource = default;
            string id = default;
            var response = await _instance.UpdateResourceAsync(resource, id);
            Assert.IsType<Resource>(response);
        }

        /// <summary>
        /// Test UpdateResourceProperties
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateResourcePropertiesAsyncTest()
        {
            List<Property> properties = default;
            string id = default;
            await _instance.UpdateResourcePropertiesAsync(properties, id);
        }
    }
}
