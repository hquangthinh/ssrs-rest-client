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
using System.Collections.Generic;
using System.Net;

namespace SSRSRestV2.Client
{
    /// <summary>
    /// Provides a non-generic contract for the ApiResponse wrapper.
    /// </summary>
    public interface IApiResponse
    {
        /// <summary>
        /// The data type of <see cref="Data"/>
        /// </summary>
        Type ResponseType { get; }

        /// <summary>
        /// Gets or sets the status code (HTTP status code)
        /// </summary>
        /// <value>The status code.</value>
        HttpStatusCode StatusCode { get; }

        /// <summary>
        /// The raw content of this response
        /// </summary>
        string RawContent { get; }

        /// <summary>
        /// The DateTime when the request was retrieved.
        /// </summary>
        DateTime DownloadedAt { get; }
    }

    /// <summary>
    /// API Response
    /// </summary>
    public partial class ApiResponse<T> : IApiResponse
    {
        /// <summary>
        /// The deserialized content
        /// </summary>
        public T Content { get; internal set; }

        /// <summary>
        /// Gets or sets the status code (HTTP status code)
        /// </summary>
        /// <value>The status code.</value>
        public HttpStatusCode StatusCode { get; }

        /// <summary>
        /// The content of this response
        /// </summary>
        public Type ResponseType
        {
            get { return typeof(T); }
        }

        /// <summary>
        /// The raw data
        /// </summary>
        public string RawContent { get; }

        /// <summary>
        /// The IsSuccessStatusCode from the api response
        /// </summary>
        public bool IsSuccessStatusCode { get; }

        /// <summary>
        /// The reason phrase contained in the api response
        /// </summary>
        public string ReasonPhrase { get; }

        /// <summary>
        /// The headers contained in the api response
        /// </summary>
        public System.Net.Http.Headers.HttpResponseHeaders Headers { get; }

        /// <summary>
        /// The DateTime when the request was retrieved.
        /// </summary>
        public DateTime DownloadedAt { get; } = DateTime.UtcNow;

        /// <summary>
        /// Construct the response using an HttpResponseMessage
        /// </summary>
        /// <param name="response"></param>
        /// <param name="rawContent"></param>
        public ApiResponse(System.Net.Http.HttpResponseMessage response, string rawContent)
        {
            StatusCode = response.StatusCode;
            Headers = response.Headers;
            IsSuccessStatusCode = response.IsSuccessStatusCode;
            ReasonPhrase = response.ReasonPhrase;
            RawContent = rawContent;
        }
    }
}
