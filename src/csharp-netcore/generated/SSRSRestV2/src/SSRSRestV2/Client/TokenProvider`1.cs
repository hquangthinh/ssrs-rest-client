// <auto-generated>
/*
 * SQL Server 2017 Reporting Services REST API
 *
 * The SQL Server 2017 Reporting Services REST API provides programmatic access to the report server catalog.  For example, basic CRUD operations can be done on folders, reports, KPIs, data sources, datasets, refresh plans, subscriptions, etc.     The REST API can also be used to provide more advanced functionality, such as: * Navigate the folder hierarchy * Discover the contents of a folder * Download a report definition * Modify default report parameters * Change or execute a refresh plan * A whole lot more  The REST API is a RESTful successor to the legacy [SOAP API](https://msdn.microsoft.com/library/reportservice2010.reportingservice2010.aspx).  Happy coding!  __API samples:__ https://github.com/Microsoft/Reporting-Services  __Developer documentation:__ https://docs.microsoft.com/sql/reporting-services/reporting-services-developer-documentation  __Team Blog:__ https://blogs.msdn.microsoft.com/sqlrsteamblog  __Support forums:__ https://social.msdn.microsoft.com/Forums/en-US/home?forum=sqlreportingservices 
 *
 * The version of the OpenAPI document: 2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.Collections.Generic;
using SSRSRestV2.Client;

namespace SSRSRestV2
{
    /// <summary>
    /// A class which will provide tokens.
    /// </summary>
    public abstract class TokenProvider<TTokenBase> where TTokenBase : TokenBase
    {
        /// <summary>
        /// The array of tokens.
        /// </summary>
        protected TTokenBase[] _tokens;

        internal abstract System.Threading.Tasks.ValueTask<TTokenBase> GetAsync(System.Threading.CancellationToken? cancellation = null);

        /// <summary>
        /// Instantiates a TokenProvider.
        /// </summary>
        /// <param name="tokens"></param>
        public TokenProvider(IEnumerable<TTokenBase> tokens)
        {
            _tokens = tokens.ToArray();

            if (_tokens.Length == 0)
                throw new ArgumentException("You did not provide any tokens.");
        }
    }
}