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
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace SSRSRestV2.IApi
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    public interface IMeApi : IApi
    {
        /// <summary>
        /// Gets the User object for the current user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;User&gt;&gt;</returns>
        Task<ApiResponse<User>> GetUserDetailsWithHttpInfoAsync(System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Gets the User object for the current user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;User&gt;</returns>
        Task<User> GetUserDetailsAsync(System.Threading.CancellationToken? cancellationToken = null);
    }
}

namespace SSRSRestV2.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MeApi : IApi.IMeApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<MeApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MeApi(ILogger<MeApi> logger, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            Logger = logger;
            HttpClient = httpClient;
        }

        /// <summary>
        /// Logs the api response
        /// </summary>
        /// <param name="args"></param>
        protected virtual void OnApiResponded(ApiResponseEventArgs args)
        {
            Logger.LogInformation("{0,-9} | {1} | {3}", (args.ReceivedAt - args.RequestedAt).TotalSeconds, args.HttpStatus, args.Path);
        }

        /// <summary>
        /// Gets the User object for the current user. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="User"/>&gt;</returns>
        public async Task<User> GetUserDetailsAsync(System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<User> result = await GetUserDetailsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Gets the User object for the current user. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="User"/>&gt;</returns>
        public async Task<User> GetUserDetailsOrDefaultAsync(System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<User> result = null;
            try 
            {
                result = await GetUserDetailsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result != null && result.IsSuccessStatusCode
                ? result.Content
                : null;
        }

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <returns></returns>
        protected virtual void OnGetUserDetails()
        {
            return;
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponse"></param>
        protected virtual void AfterGetUserDetails(ApiResponse<User> apiResponse)
        {
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        protected virtual void OnErrorGetUserDetails(Exception exception, string pathFormat, string path)
        {
            Logger.LogError(exception, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// Gets the User object for the current user. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="User"/></returns>
        public async Task<ApiResponse<User>> GetUserDetailsWithHttpInfoAsync(System.Threading.CancellationToken? cancellationToken = null)
        {
            UriBuilder uriBuilder = new UriBuilder();

            try
            {
                OnGetUserDetails();

                using (HttpRequestMessage request = new HttpRequestMessage())
                {
                    uriBuilder.Host = HttpClient.BaseAddress.Host;
                    uriBuilder.Port = HttpClient.BaseAddress.Port;
                    uriBuilder.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilder.Path = ClientUtils.CONTEXT_PATH + "/Me";



                    request.RequestUri = uriBuilder.Uri;

                    string[] accepts = new string[] { 
                        "application/json" 
                    };

                    string accept = ClientUtils.SelectHeaderAccept(accepts);

                    if (accept != null)
                        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));

                    request.Method = new HttpMethod("GET");

                    DateTime requestedAt = DateTime.UtcNow;

                    using (HttpResponseMessage responseMessage = await HttpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false))
                    {
                        OnApiResponded(new ApiResponseEventArgs(requestedAt, DateTime.UtcNow, responseMessage.StatusCode, "/Me", uriBuilder.Path));

                        string responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

                        ApiResponse<User> apiResponse = new ApiResponse<User>(responseMessage, responseContent);

                        if (apiResponse.IsSuccessStatusCode)
                        {
                            apiResponse.Content = JsonSerializer.Deserialize<User>(apiResponse.RawContent, _jsonSerializerOptions);
                            AfterGetUserDetails(apiResponse);
                        }

                        return apiResponse;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorGetUserDetails(e, "/Me", uriBuilder.Path);
                throw;
            }
        }
    }
}