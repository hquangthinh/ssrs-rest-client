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
    ///  Class for testing ManifestItem
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ManifestItemTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ManifestItem
        //private ManifestItem instance;

        public ManifestItemTests()
        {
            // TODO uncomment below to create an instance of ManifestItem
            //instance = new ManifestItem();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ManifestItem
        /// </summary>
        [Fact]
        public void ManifestItemInstanceTest()
        {
            // TODO uncomment below to test "IsType" ManifestItem
            //Assert.IsType<ManifestItem>(instance);
        }


        /// <summary>
        /// Test the property 'Hash'
        /// </summary>
        [Fact]
        public void HashTest()
        {
            // TODO unit test for the property 'Hash'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Path'
        /// </summary>
        [Fact]
        public void PathTest()
        {
            // TODO unit test for the property 'Path'
        }

    }

}
