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
    ///  Class for testing CatalogItem
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CatalogItemTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CatalogItem
        //private CatalogItem instance;

        public CatalogItemTests()
        {
            // TODO uncomment below to create an instance of CatalogItem
            //instance = new CatalogItem();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CatalogItem
        /// </summary>
        [Fact]
        public void CatalogItemInstanceTest()
        {
            // TODO uncomment below to test "IsType" CatalogItem
            //Assert.IsType<CatalogItem>(instance);
        }


        /// <summary>
        /// Test the property 'Content'
        /// </summary>
        [Fact]
        public void ContentTest()
        {
            // TODO unit test for the property 'Content'
        }
        /// <summary>
        /// Test the property 'ContentType'
        /// </summary>
        [Fact]
        public void ContentTypeTest()
        {
            // TODO unit test for the property 'ContentType'
        }
        /// <summary>
        /// Test the property 'CreatedBy'
        /// </summary>
        [Fact]
        public void CreatedByTest()
        {
            // TODO unit test for the property 'CreatedBy'
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
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Hidden'
        /// </summary>
        [Fact]
        public void HiddenTest()
        {
            // TODO unit test for the property 'Hidden'
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
        /// Test the property 'IsFavorite'
        /// </summary>
        [Fact]
        public void IsFavoriteTest()
        {
            // TODO unit test for the property 'IsFavorite'
        }
        /// <summary>
        /// Test the property 'ModifiedBy'
        /// </summary>
        [Fact]
        public void ModifiedByTest()
        {
            // TODO unit test for the property 'ModifiedBy'
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
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'ParentFolderId'
        /// </summary>
        [Fact]
        public void ParentFolderIdTest()
        {
            // TODO unit test for the property 'ParentFolderId'
        }
        /// <summary>
        /// Test the property 'Path'
        /// </summary>
        [Fact]
        public void PathTest()
        {
            // TODO unit test for the property 'Path'
        }
        /// <summary>
        /// Test the property 'Size'
        /// </summary>
        [Fact]
        public void SizeTest()
        {
            // TODO unit test for the property 'Size'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }

    }

}