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
    ///  Class for testing Comment
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CommentTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Comment
        //private Comment instance;

        public CommentTests()
        {
            // TODO uncomment below to create an instance of Comment
            //instance = new Comment();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Comment
        /// </summary>
        [Fact]
        public void CommentInstanceTest()
        {
            // TODO uncomment below to test "IsType" Comment
            //Assert.IsType<Comment>(instance);
        }


        /// <summary>
        /// Test the property 'AttachmentPath'
        /// </summary>
        [Fact]
        public void AttachmentPathTest()
        {
            // TODO unit test for the property 'AttachmentPath'
        }
        /// <summary>
        /// Test the property 'CreatedDate'
        /// </summary>
        [Fact]
        public void CreatedDateTest()
        {
            // TODO unit test for the property 'CreatedDate'
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
        /// Test the property 'ItemId'
        /// </summary>
        [Fact]
        public void ItemIdTest()
        {
            // TODO unit test for the property 'ItemId'
        }
        /// <summary>
        /// Test the property 'ModifiedDate'
        /// </summary>
        [Fact]
        public void ModifiedDateTest()
        {
            // TODO unit test for the property 'ModifiedDate'
        }
        /// <summary>
        /// Test the property 'Text'
        /// </summary>
        [Fact]
        public void TextTest()
        {
            // TODO unit test for the property 'Text'
        }
        /// <summary>
        /// Test the property 'ThreadId'
        /// </summary>
        [Fact]
        public void ThreadIdTest()
        {
            // TODO unit test for the property 'ThreadId'
        }
        /// <summary>
        /// Test the property 'UserName'
        /// </summary>
        [Fact]
        public void UserNameTest()
        {
            // TODO unit test for the property 'UserName'
        }

    }

}
