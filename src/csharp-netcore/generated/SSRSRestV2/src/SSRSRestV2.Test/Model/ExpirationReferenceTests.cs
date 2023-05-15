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
    ///  Class for testing ExpirationReference
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ExpirationReferenceTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ExpirationReference
        //private ExpirationReference instance;

        public ExpirationReferenceTests()
        {
            // TODO uncomment below to create an instance of ExpirationReference
            //instance = new ExpirationReference();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ExpirationReference
        /// </summary>
        [Fact]
        public void ExpirationReferenceInstanceTest()
        {
            // TODO uncomment below to test "IsType" ExpirationReference
            //Assert.IsType<ExpirationReference>(instance);
        }


        /// <summary>
        /// Test the property 'Minutes'
        /// </summary>
        [Fact]
        public void MinutesTest()
        {
            // TODO unit test for the property 'Minutes'
        }
        /// <summary>
        /// Test the property 'Schedule'
        /// </summary>
        [Fact]
        public void ScheduleTest()
        {
            // TODO unit test for the property 'Schedule'
        }

    }

}
