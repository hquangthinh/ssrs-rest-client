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
    public interface IExtensionsApi : IApi
    {
        /// <summary>
        /// Retrieves the ExtensionParameter list for given extension.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;List&lt;ExtensionParameter&gt;&gt;&gt;</returns>
        Task<ApiResponse<List<ExtensionParameter>>> GetExtensionParametersWithHttpInfoAsync(string id, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Retrieves the ExtensionParameter list for given extension.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;List&lt;ExtensionParameter&gt;&gt;</returns>
        Task<List<ExtensionParameter>> GetExtensionParametersAsync(string id, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Retreives all Extension items.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;List&lt;Extension&gt;&gt;&gt;</returns>
        Task<ApiResponse<List<Extension>>> GetExtensionsWithHttpInfoAsync(System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Retreives all Extension items.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;List&lt;Extension&gt;&gt;</returns>
        Task<List<Extension>> GetExtensionsAsync(System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Validates extension parameters and returns collection of ExtensionParameter.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionSettings"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;List&lt;ExtensionParameter&gt;&gt;&gt;</returns>
        Task<ApiResponse<List<ExtensionParameter>>> ValidateExtensionParametersWithHttpInfoAsync(ExtensionSettings extensionSettings = null, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Validates extension parameters and returns collection of ExtensionParameter.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionSettings"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;List&lt;ExtensionParameter&gt;&gt;</returns>
        Task<List<ExtensionParameter>> ValidateExtensionParametersAsync(ExtensionSettings extensionSettings = null, System.Threading.CancellationToken? cancellationToken = null);
    }
}

namespace SSRSRestV2.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ExtensionsApi : IApi.IExtensionsApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<ExtensionsApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExtensionsApi(ILogger<ExtensionsApi> logger, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider)
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
        /// Retrieves the ExtensionParameter list for given extension. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="List&lt;ExtensionParameter&gt;"/>&gt;</returns>
        public async Task<List<ExtensionParameter>> GetExtensionParametersAsync(string id, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<List<ExtensionParameter>> result = await GetExtensionParametersWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Retrieves the ExtensionParameter list for given extension. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="List&lt;ExtensionParameter&gt;"/>&gt;</returns>
        public async Task<List<ExtensionParameter>> GetExtensionParametersOrDefaultAsync(string id, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<List<ExtensionParameter>> result = null;
            try 
            {
                result = await GetExtensionParametersWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
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
        /// <param name="id"></param>
        /// <returns></returns>
        protected virtual string OnGetExtensionParameters(string id)
        {
            #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            #pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (id == null)
                throw new ArgumentNullException(nameof(id));

            #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            #pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            return id;
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponse"></param>
        /// <param name="id"></param>
        protected virtual void AfterGetExtensionParameters(ApiResponse<List<ExtensionParameter>> apiResponse, string id)
        {
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="id"></param>
        protected virtual void OnErrorGetExtensionParameters(Exception exception, string pathFormat, string path, string id)
        {
            Logger.LogError(exception, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// Retrieves the ExtensionParameter list for given extension. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="List&lt;ExtensionParameter&gt;"/></returns>
        public async Task<ApiResponse<List<ExtensionParameter>>> GetExtensionParametersWithHttpInfoAsync(string id, System.Threading.CancellationToken? cancellationToken = null)
        {
            UriBuilder uriBuilder = new UriBuilder();

            try
            {
                id = OnGetExtensionParameters(id);

                using (HttpRequestMessage request = new HttpRequestMessage())
                {
                    uriBuilder.Host = HttpClient.BaseAddress.Host;
                    uriBuilder.Port = HttpClient.BaseAddress.Port;
                    uriBuilder.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilder.Path = ClientUtils.CONTEXT_PATH + "/Extensions({Id})/Parameters";

                    uriBuilder.Path = uriBuilder.Path.Replace("%7BId%7D", Uri.EscapeDataString(id.ToString()));

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
                        OnApiResponded(new ApiResponseEventArgs(requestedAt, DateTime.UtcNow, responseMessage.StatusCode, "/Extensions({Id})/Parameters", uriBuilder.Path));

                        string responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

                        ApiResponse<List<ExtensionParameter>> apiResponse = new ApiResponse<List<ExtensionParameter>>(responseMessage, responseContent);

                        if (apiResponse.IsSuccessStatusCode)
                        {
                            apiResponse.Content = JsonSerializer.Deserialize<List<ExtensionParameter>>(apiResponse.RawContent, _jsonSerializerOptions);
                            AfterGetExtensionParameters(apiResponse, id);
                        }

                        return apiResponse;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorGetExtensionParameters(e, "/Extensions({Id})/Parameters", uriBuilder.Path, id);
                throw;
            }
        }

        /// <summary>
        /// Retreives all Extension items. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="List&lt;Extension&gt;"/>&gt;</returns>
        public async Task<List<Extension>> GetExtensionsAsync(System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<List<Extension>> result = await GetExtensionsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Retreives all Extension items. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="List&lt;Extension&gt;"/>&gt;</returns>
        public async Task<List<Extension>> GetExtensionsOrDefaultAsync(System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<List<Extension>> result = null;
            try 
            {
                result = await GetExtensionsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
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
        protected virtual void OnGetExtensions()
        {
            return;
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponse"></param>
        protected virtual void AfterGetExtensions(ApiResponse<List<Extension>> apiResponse)
        {
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        protected virtual void OnErrorGetExtensions(Exception exception, string pathFormat, string path)
        {
            Logger.LogError(exception, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// Retreives all Extension items. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="List&lt;Extension&gt;"/></returns>
        public async Task<ApiResponse<List<Extension>>> GetExtensionsWithHttpInfoAsync(System.Threading.CancellationToken? cancellationToken = null)
        {
            UriBuilder uriBuilder = new UriBuilder();

            try
            {
                OnGetExtensions();

                using (HttpRequestMessage request = new HttpRequestMessage())
                {
                    uriBuilder.Host = HttpClient.BaseAddress.Host;
                    uriBuilder.Port = HttpClient.BaseAddress.Port;
                    uriBuilder.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilder.Path = ClientUtils.CONTEXT_PATH + "/Extensions";



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
                        OnApiResponded(new ApiResponseEventArgs(requestedAt, DateTime.UtcNow, responseMessage.StatusCode, "/Extensions", uriBuilder.Path));

                        string responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

                        ApiResponse<List<Extension>> apiResponse = new ApiResponse<List<Extension>>(responseMessage, responseContent);

                        if (apiResponse.IsSuccessStatusCode)
                        {
                            apiResponse.Content = JsonSerializer.Deserialize<List<Extension>>(apiResponse.RawContent, _jsonSerializerOptions);
                            AfterGetExtensions(apiResponse);
                        }

                        return apiResponse;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorGetExtensions(e, "/Extensions", uriBuilder.Path);
                throw;
            }
        }

        /// <summary>
        /// Validates extension parameters and returns collection of ExtensionParameter. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionSettings"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="List&lt;ExtensionParameter&gt;"/>&gt;</returns>
        public async Task<List<ExtensionParameter>> ValidateExtensionParametersAsync(ExtensionSettings extensionSettings = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<List<ExtensionParameter>> result = await ValidateExtensionParametersWithHttpInfoAsync(extensionSettings, cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Validates extension parameters and returns collection of ExtensionParameter. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionSettings"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="List&lt;ExtensionParameter&gt;"/>&gt;</returns>
        public async Task<List<ExtensionParameter>> ValidateExtensionParametersOrDefaultAsync(ExtensionSettings extensionSettings = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<List<ExtensionParameter>> result = null;
            try 
            {
                result = await ValidateExtensionParametersWithHttpInfoAsync(extensionSettings, cancellationToken).ConfigureAwait(false);
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
        /// <param name="extensionSettings"></param>
        /// <returns></returns>
        protected virtual ExtensionSettings OnValidateExtensionParameters(ExtensionSettings extensionSettings)
        {
            return extensionSettings;
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponse"></param>
        /// <param name="extensionSettings"></param>
        protected virtual void AfterValidateExtensionParameters(ApiResponse<List<ExtensionParameter>> apiResponse, ExtensionSettings extensionSettings)
        {
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="extensionSettings"></param>
        protected virtual void OnErrorValidateExtensionParameters(Exception exception, string pathFormat, string path, ExtensionSettings extensionSettings)
        {
            Logger.LogError(exception, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// Validates extension parameters and returns collection of ExtensionParameter. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionSettings"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="List&lt;ExtensionParameter&gt;"/></returns>
        public async Task<ApiResponse<List<ExtensionParameter>>> ValidateExtensionParametersWithHttpInfoAsync(ExtensionSettings extensionSettings = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            UriBuilder uriBuilder = new UriBuilder();

            try
            {
                extensionSettings = OnValidateExtensionParameters(extensionSettings);

                using (HttpRequestMessage request = new HttpRequestMessage())
                {
                    uriBuilder.Host = HttpClient.BaseAddress.Host;
                    uriBuilder.Port = HttpClient.BaseAddress.Port;
                    uriBuilder.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilder.Path = ClientUtils.CONTEXT_PATH + "/Extensions/Model.ValidateExtensionSettings";

                    request.Content = (extensionSettings as object) is System.IO.Stream stream
                        ? request.Content = new StreamContent(stream)
                        : request.Content = new StringContent(JsonSerializer.Serialize(extensionSettings, _jsonSerializerOptions));



                    request.RequestUri = uriBuilder.Uri;

                    string[] contentTypes = new string[] {
                        "application/json" 
                    };

                    string contentType = ClientUtils.SelectHeaderContentType(contentTypes);

                    if (contentType != null)
                        request.Content.Headers.ContentType = new MediaTypeHeaderValue(contentType);

                    string[] accepts = new string[] { 
                        "application/json" 
                    };

                    string accept = ClientUtils.SelectHeaderAccept(accepts);

                    if (accept != null)
                        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));

                    request.Method = new HttpMethod("POST");

                    DateTime requestedAt = DateTime.UtcNow;

                    using (HttpResponseMessage responseMessage = await HttpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false))
                    {
                        OnApiResponded(new ApiResponseEventArgs(requestedAt, DateTime.UtcNow, responseMessage.StatusCode, "/Extensions/Model.ValidateExtensionSettings", uriBuilder.Path));

                        string responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

                        ApiResponse<List<ExtensionParameter>> apiResponse = new ApiResponse<List<ExtensionParameter>>(responseMessage, responseContent);

                        if (apiResponse.IsSuccessStatusCode)
                        {
                            apiResponse.Content = JsonSerializer.Deserialize<List<ExtensionParameter>>(apiResponse.RawContent, _jsonSerializerOptions);
                            AfterValidateExtensionParameters(apiResponse, extensionSettings);
                        }

                        return apiResponse;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorValidateExtensionParameters(e, "/Extensions/Model.ValidateExtensionSettings", uriBuilder.Path, extensionSettings);
                throw;
            }
        }
    }
}