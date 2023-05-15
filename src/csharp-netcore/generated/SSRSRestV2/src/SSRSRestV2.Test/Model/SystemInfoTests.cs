/*
 * SQL Server 2017 Reporting Services REST API
 *
 * The SQL Server 2017 Reporting Services REST API provides programmatic access to the report server catalog.  For example, basic CRUD operations can be done on folders, reports, KPIs, data sources, datasets, refresh plans, subscriptions, etc.     The REST API can also be used to provide more advanced functionality, such as: * Navigate the folder hierarchy * Discover the contents of a folder * Download a report definition * Modify default report parameters * Change or execute a refresh plan * A whole lot more  The REST API is a RESTful successor to the legacy [SOAP API](https://msdn.microsoft.com/library/reportservice2010.reportingservice2010.aspx).  Happy coding!  __API samples:__ https://github.com/Microsoft/Reporting-Services  __Developer documentation:__ https://docs.microsoft.com/sql/reporting-services/reporting-services-developer-documentation  __Team Blog:__ https://blogs.msdn.microsoft.com/sqlrsteamblog  __Support forums:__ https://social.msdn.microsoft.com/Forums/en-US/home?forum=sqlreportingservices 
 *
 * The version of the OpenAPI document: 2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using SSRSRestV2.Api;
using SSRSRestV2.Model;
using SSRSRestV2.Client;
using System.Reflection;

namespace SSRSRestV2.Test.Model
{
    /// <summary>
    ///  Class for testing SystemInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SystemInfoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SystemInfo
        //private SystemInfo instance;

        public SystemInfoTests()
        {
            // TODO uncomment below to create an instance of SystemInfo
            //instance = new SystemInfo();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SystemInfo
        /// </summary>
        [Fact]
        public void SystemInfoInstanceTest()
        {
            // TODO uncomment below to test "IsType" SystemInfo
            //Assert.IsType<SystemInfo>(instance);
        }


        /// <summary>
        /// Test the property 'ProductName'
        /// </summary>
        [Fact]
        public void ProductNameTest()
        {
            // TODO unit test for the property 'ProductName'
        }
        /// <summary>
        /// Test the property 'ProductType'
        /// </summary>
        [Fact]
        public void ProductTypeTest()
        {
            // TODO unit test for the property 'ProductType'
        }
        /// <summary>
        /// Test the property 'ProductVersion'
        /// </summary>
        [Fact]
        public void ProductVersionTest()
        {
            // TODO unit test for the property 'ProductVersion'
        }
        /// <summary>
        /// Test the property 'ReportServerAbsoluteUrl'
        /// </summary>
        [Fact]
        public void ReportServerAbsoluteUrlTest()
        {
            // TODO unit test for the property 'ReportServerAbsoluteUrl'
        }
        /// <summary>
        /// Test the property 'ReportServerRelativeUrl'
        /// </summary>
        [Fact]
        public void ReportServerRelativeUrlTest()
        {
            // TODO unit test for the property 'ReportServerRelativeUrl'
        }
        /// <summary>
        /// Test the property 'TimeZone'
        /// </summary>
        [Fact]
        public void TimeZoneTest()
        {
            // TODO unit test for the property 'TimeZone'
        }
        /// <summary>
        /// Test the property 'WebPortalRelativeUrl'
        /// </summary>
        [Fact]
        public void WebPortalRelativeUrlTest()
        {
            // TODO unit test for the property 'WebPortalRelativeUrl'
        }

    }

}