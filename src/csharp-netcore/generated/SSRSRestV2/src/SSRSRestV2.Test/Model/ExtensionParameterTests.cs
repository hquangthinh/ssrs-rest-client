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
    ///  Class for testing ExtensionParameter
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ExtensionParameterTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ExtensionParameter
        //private ExtensionParameter instance;

        public ExtensionParameterTests()
        {
            // TODO uncomment below to create an instance of ExtensionParameter
            //instance = new ExtensionParameter();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ExtensionParameter
        /// </summary>
        [Fact]
        public void ExtensionParameterInstanceTest()
        {
            // TODO uncomment below to test "IsType" ExtensionParameter
            //Assert.IsType<ExtensionParameter>(instance);
        }


        /// <summary>
        /// Test the property 'DisplayName'
        /// </summary>
        [Fact]
        public void DisplayNameTest()
        {
            // TODO unit test for the property 'DisplayName'
        }
        /// <summary>
        /// Test the property 'Encrypted'
        /// </summary>
        [Fact]
        public void EncryptedTest()
        {
            // TODO unit test for the property 'Encrypted'
        }
        /// <summary>
        /// Test the property 'Error'
        /// </summary>
        [Fact]
        public void ErrorTest()
        {
            // TODO unit test for the property 'Error'
        }
        /// <summary>
        /// Test the property 'IsPassword'
        /// </summary>
        [Fact]
        public void IsPasswordTest()
        {
            // TODO unit test for the property 'IsPassword'
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
        /// Test the property 'ReadOnly'
        /// </summary>
        [Fact]
        public void ReadOnlyTest()
        {
            // TODO unit test for the property 'ReadOnly'
        }
        /// <summary>
        /// Test the property 'Required'
        /// </summary>
        [Fact]
        public void RequiredTest()
        {
            // TODO unit test for the property 'Required'
        }
        /// <summary>
        /// Test the property 'ValidValues'
        /// </summary>
        [Fact]
        public void ValidValuesTest()
        {
            // TODO unit test for the property 'ValidValues'
        }
        /// <summary>
        /// Test the property 'ValidValuesIsNull'
        /// </summary>
        [Fact]
        public void ValidValuesIsNullTest()
        {
            // TODO unit test for the property 'ValidValuesIsNull'
        }
        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Fact]
        public void ValueTest()
        {
            // TODO unit test for the property 'Value'
        }

    }

}
