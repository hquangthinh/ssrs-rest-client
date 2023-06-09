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
    ///  Class for testing MobileReportsApi
    /// </summary>
    public sealed class MobileReportsApiTests : ApiTestsBase
    {
        private readonly IApi.IMobileReportsApi _instance;

        public MobileReportsApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IApi.IMobileReportsApi>();
        }


        /// <summary>
        /// Test AddMobileReport
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task AddMobileReportAsyncTest()
        {
            MobileReport body = default;
            var response = await _instance.AddMobileReportAsync(body);
            Assert.IsType<MobileReport>(response);
        }

        /// <summary>
        /// Test AddMobileReportComment
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task AddMobileReportCommentAsyncTest()
        {
            Comment comment = default;
            string id = default;
            await _instance.AddMobileReportCommentAsync(comment, id);
        }

        /// <summary>
        /// Test DeleteMobileReport
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task DeleteMobileReportAsyncTest()
        {
            string id = default;
            await _instance.DeleteMobileReportAsync(id);
        }

        /// <summary>
        /// Test DeleteMobileReportComment
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task DeleteMobileReportCommentAsyncTest()
        {
            string id = default;
            string commentId = default;
            await _instance.DeleteMobileReportCommentAsync(id, commentId);
        }

        /// <summary>
        /// Test GetMobileReport
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetMobileReportAsyncTest()
        {
            string id = default;
            var response = await _instance.GetMobileReportAsync(id);
            Assert.IsType<MobileReport>(response);
        }

        /// <summary>
        /// Test GetMobileReportAllowedActions
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetMobileReportAllowedActionsAsyncTest()
        {
            string id = default;
            var response = await _instance.GetMobileReportAllowedActionsAsync(id);
            Assert.IsType<ODataAllowedActions>(response);
        }

        /// <summary>
        /// Test GetMobileReportComments
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetMobileReportCommentsAsyncTest()
        {
            string id = default;
            var response = await _instance.GetMobileReportCommentsAsync(id);
            Assert.IsType<ODataComments>(response);
        }

        /// <summary>
        /// Test GetMobileReportContent
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetMobileReportContentAsyncTest()
        {
            string id = default;
            var response = await _instance.GetMobileReportContentAsync(id);
            Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test GetMobileReportPolicies
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetMobileReportPoliciesAsyncTest()
        {
            string id = default;
            var response = await _instance.GetMobileReportPoliciesAsync(id);
            Assert.IsType<List<ItemPolicy>>(response);
        }

        /// <summary>
        /// Test GetMobileReportProperties
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetMobileReportPropertiesAsyncTest()
        {
            string id = default;
            List<string> properties = default;
            var response = await _instance.GetMobileReportPropertiesAsync(id, properties);
            Assert.IsType<ODataProperties>(response);
        }

        /// <summary>
        /// Test GetMobileReports
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetMobileReportsAsyncTest()
        {
            int? top = default;
            int? skip = default;
            string filter = default;
            string count = default;
            var response = await _instance.GetMobileReportsAsync(top, skip, filter, count);
            Assert.IsType<ODataMobileReport>(response);
        }

        /// <summary>
        /// Test SetMobileReportPolicies
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task SetMobileReportPoliciesAsyncTest()
        {
            List<ItemPolicy> mobileReports = default;
            string id = default;
            await _instance.SetMobileReportPoliciesAsync(mobileReports, id);
        }

        /// <summary>
        /// Test UpdateMobileReport
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateMobileReportAsyncTest()
        {
            MobileReport body = default;
            string id = default;
            var response = await _instance.UpdateMobileReportAsync(body, id);
            Assert.IsType<MobileReport>(response);
        }

        /// <summary>
        /// Test UpdateMobileReportComment
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateMobileReportCommentAsyncTest()
        {
            Comment comment = default;
            string id = default;
            string commentId = default;
            await _instance.UpdateMobileReportCommentAsync(comment, id, commentId);
        }

        /// <summary>
        /// Test UpdateMobileReportProperties
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateMobileReportPropertiesAsyncTest()
        {
            List<Property> properties = default;
            string id = default;
            await _instance.UpdateMobileReportPropertiesAsync(properties, id);
        }
    }
}
