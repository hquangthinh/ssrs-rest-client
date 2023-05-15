# SSRSRestV2.Api.LinkedReportsApi

All URIs are relative to *http://localhost/reports/api/v2.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddLinkedReport**](LinkedReportsApi.md#addlinkedreport) | **POST** /LinkedReports | Creates a new LinkedReport CatalogItem. |
| [**AddLinkedReportComment**](LinkedReportsApi.md#addlinkedreportcomment) | **POST** /LinkedReports({Id})/Comments | Creates a new Comment associated to the specified LinkedReport. |
| [**AddLinkedReportHistorySnapshot**](LinkedReportsApi.md#addlinkedreporthistorysnapshot) | **POST** /LinkedReports({Id})/HistorySnapshots | Creates new HistorySnapshot |
| [**DeleteLinkedReport**](LinkedReportsApi.md#deletelinkedreport) | **DELETE** /LinkedReports({Id}) | Deletes the specified LinkedReport. |
| [**DeleteLinkedReportComment**](LinkedReportsApi.md#deletelinkedreportcomment) | **DELETE** /LinkedReports({Id})/Comments({CommentId}) | Deletes the specified Comment associated to the LinkedReport. |
| [**DeleteLinkedReportHistorySnapshot**](LinkedReportsApi.md#deletelinkedreporthistorysnapshot) | **DELETE** /LinkedReports({Id})/HistorySnapshots({HistoryId}) | Deletes a HistorySnapshot specified by HistoryId from the LinkedReport specified by Id. |
| [**GetLinkedReport**](LinkedReportsApi.md#getlinkedreport) | **GET** /LinkedReports({Id}) | Gets a LinkedReport CatalogItem specified by the Id. |
| [**GetLinkedReportAllowedActions**](LinkedReportsApi.md#getlinkedreportallowedactions) | **GET** /LinkedReports({Id})/AllowedActions | Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying. |
| [**GetLinkedReportCacheOptions**](LinkedReportsApi.md#getlinkedreportcacheoptions) | **GET** /LinkedReports({Id})/CacheOptions | Gets the content of CacheOptions for the LinkedReport specified by the Id. |
| [**GetLinkedReportCacheRefreshPlans**](LinkedReportsApi.md#getlinkedreportcacherefreshplans) | **GET** /LinkedReports({Id})/CacheRefreshPlans | Gets the CacheRefreshPlans for a LinkedReport specified by the Id. |
| [**GetLinkedReportComments**](LinkedReportsApi.md#getlinkedreportcomments) | **GET** /LinkedReports({Id})/Comments | Gets the Comments for a LinkedReport specified by the Id. |
| [**GetLinkedReportHistorySnapshot**](LinkedReportsApi.md#getlinkedreporthistorysnapshot) | **GET** /LinkedReports({Id})/HistorySnapshots({HistoryId}) | Gets requested HistorySnapshot item specified by HistoryId of the LinkedReport specified by Id. |
| [**GetLinkedReportHistorySnapshotOptions**](LinkedReportsApi.md#getlinkedreporthistorysnapshotoptions) | **GET** /LinkedReports({Id})/HistorySnapshotOptions | Gets HistorySnapshotOptions for the specified LinkedReport. |
| [**GetLinkedReportHistorySnapshots**](LinkedReportsApi.md#getlinkedreporthistorysnapshots) | **GET** /LinkedReports({Id})/HistorySnapshots | Get a list of HistorySnapshots of the LinkedReport specified by Id. |
| [**GetLinkedReportParameterDefinitions**](LinkedReportsApi.md#getlinkedreportparameterdefinitions) | **GET** /LinkedReports({Id})/ParameterDefinitions | Gets the ParameterDefinitions associated with the LinkedReport specified by the Id. |
| [**GetLinkedReportPolicies**](LinkedReportsApi.md#getlinkedreportpolicies) | **GET** /LinkedReports({Id})/Policies | Gets ItemPolicies associated with the specified LinkedReport CatalogItem. |
| [**GetLinkedReportProperties**](LinkedReportsApi.md#getlinkedreportproperties) | **GET** /LinkedReports({Id})/Properties | Gets LinkedReport Properties (takes list of Property names to retrieve the values) |
| [**GetLinkedReports**](LinkedReportsApi.md#getlinkedreports) | **GET** /LinkedReports | Gets an array of LinkedReport CatalogItems. |
| [**SetLinkedReportCacheOptions**](LinkedReportsApi.md#setlinkedreportcacheoptions) | **PUT** /LinkedReports({Id})/CacheOptions | Replaces the CacheOption&#39;s content for a given LinkedReport using the provided definition. |
| [**SetLinkedReportHistorySnapshotOptions**](LinkedReportsApi.md#setlinkedreporthistorysnapshotoptions) | **PUT** /LinkedReports({Id})/HistorySnapshotOptions | Updates HistorySnapshotOptions property. |
| [**SetLinkedReportPolicies**](LinkedReportsApi.md#setlinkedreportpolicies) | **PUT** /LinkedReports({Id})/Policies | Replaces ItemPolicies associated with the specified LinkedReport item. |
| [**UpdateLinkedReport**](LinkedReportsApi.md#updatelinkedreport) | **PATCH** /LinkedReports({Id}) | Updates the specified LinkedReport CatalogItem using the provided definition. |
| [**UpdateLinkedReportComment**](LinkedReportsApi.md#updatelinkedreportcomment) | **PUT** /LinkedReports({Id})/Comments({CommentId}) | Updates the Comment specified by CommentId in the associated LinkedReport. |
| [**UpdateLinkedReportParameterDefinitions**](LinkedReportsApi.md#updatelinkedreportparameterdefinitions) | **PATCH** /LinkedReports({Id})/ParameterDefinitions | Updates the ParameterDefinitions associated with the specified LinkedReport by the Id. |
| [**UpdateLinkedReportProperties**](LinkedReportsApi.md#updatelinkedreportproperties) | **PUT** /LinkedReports({Id})/Properties | Updates the LinkedReport Properties included in the given list. |

<a name="addlinkedreport"></a>
# **AddLinkedReport**
> LinkedReport AddLinkedReport (LinkedReport linkedReport)

Creates a new LinkedReport CatalogItem.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class AddLinkedReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var linkedReport = new LinkedReport(); // LinkedReport | The definition of the new LinkedReport CatalogItem.

            try
            {
                // Creates a new LinkedReport CatalogItem.
                LinkedReport result = apiInstance.AddLinkedReport(linkedReport);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.AddLinkedReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddLinkedReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new LinkedReport CatalogItem.
    ApiResponse<LinkedReport> response = apiInstance.AddLinkedReportWithHttpInfo(linkedReport);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.AddLinkedReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **linkedReport** | [**LinkedReport**](LinkedReport.md) | The definition of the new LinkedReport CatalogItem. |  |

### Return type

[**LinkedReport**](LinkedReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created. |  -  |
| **400** | Couldn&#39;t understand your request. |  -  |
| **409** | Conflict. Item already exists. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="addlinkedreportcomment"></a>
# **AddLinkedReportComment**
> void AddLinkedReportComment (Comment comment, string id)

Creates a new Comment associated to the specified LinkedReport.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class AddLinkedReportCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var comment = new Comment(); // Comment | The Comment to be created
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Creates a new Comment associated to the specified LinkedReport.
                apiInstance.AddLinkedReportComment(comment, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.AddLinkedReportComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddLinkedReportCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new Comment associated to the specified LinkedReport.
    apiInstance.AddLinkedReportCommentWithHttpInfo(comment, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.AddLinkedReportCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comment** | [**Comment**](Comment.md) | The Comment to be created |  |
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="addlinkedreporthistorysnapshot"></a>
# **AddLinkedReportHistorySnapshot**
> bool AddLinkedReportHistorySnapshot (string id)

Creates new HistorySnapshot

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class AddLinkedReportHistorySnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Creates new HistorySnapshot
                bool result = apiInstance.AddLinkedReportHistorySnapshot(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.AddLinkedReportHistorySnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddLinkedReportHistorySnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates new HistorySnapshot
    ApiResponse<bool> response = apiInstance.AddLinkedReportHistorySnapshotWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.AddLinkedReportHistorySnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="deletelinkedreport"></a>
# **DeleteLinkedReport**
> void DeleteLinkedReport (string id)

Deletes the specified LinkedReport.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class DeleteLinkedReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Deletes the specified LinkedReport.
                apiInstance.DeleteLinkedReport(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.DeleteLinkedReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteLinkedReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes the specified LinkedReport.
    apiInstance.DeleteLinkedReportWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.DeleteLinkedReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="deletelinkedreportcomment"></a>
# **DeleteLinkedReportComment**
> void DeleteLinkedReportComment (string id, string commentId)

Deletes the specified Comment associated to the LinkedReport.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class DeleteLinkedReportCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var commentId = "commentId_example";  // string | The Id of the Comment.

            try
            {
                // Deletes the specified Comment associated to the LinkedReport.
                apiInstance.DeleteLinkedReportComment(id, commentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.DeleteLinkedReportComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteLinkedReportCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes the specified Comment associated to the LinkedReport.
    apiInstance.DeleteLinkedReportCommentWithHttpInfo(id, commentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.DeleteLinkedReportCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |
| **commentId** | **string** | The Id of the Comment. |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="deletelinkedreporthistorysnapshot"></a>
# **DeleteLinkedReportHistorySnapshot**
> bool DeleteLinkedReportHistorySnapshot (string id, string historyId)

Deletes a HistorySnapshot specified by HistoryId from the LinkedReport specified by Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class DeleteLinkedReportHistorySnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var historyId = "historyId_example";  // string | The Id property of the HistorySnapshot

            try
            {
                // Deletes a HistorySnapshot specified by HistoryId from the LinkedReport specified by Id.
                bool result = apiInstance.DeleteLinkedReportHistorySnapshot(id, historyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.DeleteLinkedReportHistorySnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteLinkedReportHistorySnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a HistorySnapshot specified by HistoryId from the LinkedReport specified by Id.
    ApiResponse<bool> response = apiInstance.DeleteLinkedReportHistorySnapshotWithHttpInfo(id, historyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.DeleteLinkedReportHistorySnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |
| **historyId** | **string** | The Id property of the HistorySnapshot |  |

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **400** | Couldn&#39;t understand your request. |  -  |
| **404** | Not found. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getlinkedreport"></a>
# **GetLinkedReport**
> LinkedReport GetLinkedReport (string id)

Gets a LinkedReport CatalogItem specified by the Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetLinkedReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a LinkedReport CatalogItem specified by the Id.
                LinkedReport result = apiInstance.GetLinkedReport(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLinkedReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a LinkedReport CatalogItem specified by the Id.
    ApiResponse<LinkedReport> response = apiInstance.GetLinkedReportWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

[**LinkedReport**](LinkedReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The LinkedReport CatalogItem specified by the Id. |  -  |
| **400** | Couldn&#39;t understand your request. |  -  |
| **404** | Not found. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getlinkedreportallowedactions"></a>
# **GetLinkedReportAllowedActions**
> ODataAllowedActions GetLinkedReportAllowedActions (string id)

Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetLinkedReportAllowedActionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
                ODataAllowedActions result = apiInstance.GetLinkedReportAllowedActions(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportAllowedActions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLinkedReportAllowedActionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
    ApiResponse<ODataAllowedActions> response = apiInstance.GetLinkedReportAllowedActionsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportAllowedActionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

[**ODataAllowedActions**](ODataAllowedActions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getlinkedreportcacheoptions"></a>
# **GetLinkedReportCacheOptions**
> CacheOptions GetLinkedReportCacheOptions (string id)

Gets the content of CacheOptions for the LinkedReport specified by the Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetLinkedReportCacheOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the content of CacheOptions for the LinkedReport specified by the Id.
                CacheOptions result = apiInstance.GetLinkedReportCacheOptions(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportCacheOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLinkedReportCacheOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the content of CacheOptions for the LinkedReport specified by the Id.
    ApiResponse<CacheOptions> response = apiInstance.GetLinkedReportCacheOptionsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportCacheOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

[**CacheOptions**](CacheOptions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the content of CacheOptions for the LinkedReport specified by the Id. |  -  |
| **404** | Not found. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getlinkedreportcacherefreshplans"></a>
# **GetLinkedReportCacheRefreshPlans**
> ODataCacheRefreshPlans GetLinkedReportCacheRefreshPlans (string id)

Gets the CacheRefreshPlans for a LinkedReport specified by the Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetLinkedReportCacheRefreshPlansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the CacheRefreshPlans for a LinkedReport specified by the Id.
                ODataCacheRefreshPlans result = apiInstance.GetLinkedReportCacheRefreshPlans(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportCacheRefreshPlans: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLinkedReportCacheRefreshPlansWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the CacheRefreshPlans for a LinkedReport specified by the Id.
    ApiResponse<ODataCacheRefreshPlans> response = apiInstance.GetLinkedReportCacheRefreshPlansWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportCacheRefreshPlansWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

[**ODataCacheRefreshPlans**](ODataCacheRefreshPlans.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the CacheRefreshPlans for a LinkedReport specified by the Id. |  -  |
| **404** | Not found. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getlinkedreportcomments"></a>
# **GetLinkedReportComments**
> ODataComments GetLinkedReportComments (string id)

Gets the Comments for a LinkedReport specified by the Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetLinkedReportCommentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the Comments for a LinkedReport specified by the Id.
                ODataComments result = apiInstance.GetLinkedReportComments(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportComments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLinkedReportCommentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the Comments for a LinkedReport specified by the Id.
    ApiResponse<ODataComments> response = apiInstance.GetLinkedReportCommentsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportCommentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

[**ODataComments**](ODataComments.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A collection of Comments associated to the LinkedReport |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getlinkedreporthistorysnapshot"></a>
# **GetLinkedReportHistorySnapshot**
> HistorySnapshot GetLinkedReportHistorySnapshot (string id, string historyId)

Gets requested HistorySnapshot item specified by HistoryId of the LinkedReport specified by Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetLinkedReportHistorySnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var historyId = "historyId_example";  // string | The Id property of the HistorySnapshot

            try
            {
                // Gets requested HistorySnapshot item specified by HistoryId of the LinkedReport specified by Id.
                HistorySnapshot result = apiInstance.GetLinkedReportHistorySnapshot(id, historyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportHistorySnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLinkedReportHistorySnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets requested HistorySnapshot item specified by HistoryId of the LinkedReport specified by Id.
    ApiResponse<HistorySnapshot> response = apiInstance.GetLinkedReportHistorySnapshotWithHttpInfo(id, historyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportHistorySnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |
| **historyId** | **string** | The Id property of the HistorySnapshot |  |

### Return type

[**HistorySnapshot**](HistorySnapshot.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a History Snapshot item. |  -  |
| **404** | Not found. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getlinkedreporthistorysnapshotoptions"></a>
# **GetLinkedReportHistorySnapshotOptions**
> HistorySnapshotOptions GetLinkedReportHistorySnapshotOptions (string id)

Gets HistorySnapshotOptions for the specified LinkedReport.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetLinkedReportHistorySnapshotOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets HistorySnapshotOptions for the specified LinkedReport.
                HistorySnapshotOptions result = apiInstance.GetLinkedReportHistorySnapshotOptions(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportHistorySnapshotOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLinkedReportHistorySnapshotOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets HistorySnapshotOptions for the specified LinkedReport.
    ApiResponse<HistorySnapshotOptions> response = apiInstance.GetLinkedReportHistorySnapshotOptionsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportHistorySnapshotOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

[**HistorySnapshotOptions**](HistorySnapshotOptions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | History Snapshot Options |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getlinkedreporthistorysnapshots"></a>
# **GetLinkedReportHistorySnapshots**
> List&lt;HistorySnapshot&gt; GetLinkedReportHistorySnapshots (string id)

Get a list of HistorySnapshots of the LinkedReport specified by Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetLinkedReportHistorySnapshotsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Get a list of HistorySnapshots of the LinkedReport specified by Id.
                List<HistorySnapshot> result = apiInstance.GetLinkedReportHistorySnapshots(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportHistorySnapshots: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLinkedReportHistorySnapshotsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of HistorySnapshots of the LinkedReport specified by Id.
    ApiResponse<List<HistorySnapshot>> response = apiInstance.GetLinkedReportHistorySnapshotsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportHistorySnapshotsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

[**List&lt;HistorySnapshot&gt;**](HistorySnapshot.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getlinkedreportparameterdefinitions"></a>
# **GetLinkedReportParameterDefinitions**
> ODataReportParameterDefinitions GetLinkedReportParameterDefinitions (string id)

Gets the ParameterDefinitions associated with the LinkedReport specified by the Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetLinkedReportParameterDefinitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the ParameterDefinitions associated with the LinkedReport specified by the Id.
                ODataReportParameterDefinitions result = apiInstance.GetLinkedReportParameterDefinitions(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportParameterDefinitions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLinkedReportParameterDefinitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the ParameterDefinitions associated with the LinkedReport specified by the Id.
    ApiResponse<ODataReportParameterDefinitions> response = apiInstance.GetLinkedReportParameterDefinitionsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportParameterDefinitionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

[**ODataReportParameterDefinitions**](ODataReportParameterDefinitions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of ParameterDefinitions that are associated with the LinkedReport CatalogItem specified by the Id. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getlinkedreportpolicies"></a>
# **GetLinkedReportPolicies**
> List&lt;ItemPolicy&gt; GetLinkedReportPolicies (string id)

Gets ItemPolicies associated with the specified LinkedReport CatalogItem.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetLinkedReportPoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets ItemPolicies associated with the specified LinkedReport CatalogItem.
                List<ItemPolicy> result = apiInstance.GetLinkedReportPolicies(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportPolicies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLinkedReportPoliciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets ItemPolicies associated with the specified LinkedReport CatalogItem.
    ApiResponse<List<ItemPolicy>> response = apiInstance.GetLinkedReportPoliciesWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportPoliciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

[**List&lt;ItemPolicy&gt;**](ItemPolicy.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of ItemPolicies that are associated with the specified LinkedReport CatalogItem. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getlinkedreportproperties"></a>
# **GetLinkedReportProperties**
> ODataProperties GetLinkedReportProperties (string id, List<string> properties = null)

Gets LinkedReport Properties (takes list of Property names to retrieve the values)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetLinkedReportPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<string>(); // List<string> | Names for the Properties to be returned. (optional) 

            try
            {
                // Gets LinkedReport Properties (takes list of Property names to retrieve the values)
                ODataProperties result = apiInstance.GetLinkedReportProperties(id, properties);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLinkedReportPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets LinkedReport Properties (takes list of Property names to retrieve the values)
    ApiResponse<ODataProperties> response = apiInstance.GetLinkedReportPropertiesWithHttpInfo(id, properties);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportPropertiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |
| **properties** | [**List&lt;string&gt;**](string.md) | Names for the Properties to be returned. | [optional]  |

### Return type

[**ODataProperties**](ODataProperties.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getlinkedreports"></a>
# **GetLinkedReports**
> ODataLinkedReports GetLinkedReports (int? top = null, int? skip = null, string filter = null, string count = null, string orderBy = null, string select = null)

Gets an array of LinkedReport CatalogItems.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetLinkedReportsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var top = 56;  // int? | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) (optional) 
            var filter = "filter_example";  // string | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) (optional) 
            var count = "count_example";  // string | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) (optional) 
            var orderBy = "orderBy_example";  // string | Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) (optional) 
            var select = "select_example";  // string | Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) (optional) 

            try
            {
                // Gets an array of LinkedReport CatalogItems.
                ODataLinkedReports result = apiInstance.GetLinkedReports(top, skip, filter, count, orderBy, select);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReports: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLinkedReportsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets an array of LinkedReport CatalogItems.
    ApiResponse<ODataLinkedReports> response = apiInstance.GetLinkedReportsWithHttpInfo(top, skip, filter, count, orderBy, select);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **top** | **int?** | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) | [optional]  |
| **skip** | **int?** | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) | [optional]  |
| **filter** | **string** | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) | [optional]  |
| **count** | **string** | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) | [optional]  |
| **orderBy** | **string** | Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) | [optional]  |
| **select** | **string** | Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) | [optional]  |

### Return type

[**ODataLinkedReports**](ODataLinkedReports.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok. |  -  |
| **400** | Couldn&#39;t understand your request. |  -  |
| **404** | Not found. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="setlinkedreportcacheoptions"></a>
# **SetLinkedReportCacheOptions**
> void SetLinkedReportCacheOptions (CacheOptions cacheOptions, string id)

Replaces the CacheOption's content for a given LinkedReport using the provided definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class SetLinkedReportCacheOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var cacheOptions = new CacheOptions(); // CacheOptions | Updated definition for the CacheOption's content associated with the LinkedReport specified by the Id.
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Replaces the CacheOption's content for a given LinkedReport using the provided definition.
                apiInstance.SetLinkedReportCacheOptions(cacheOptions, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.SetLinkedReportCacheOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetLinkedReportCacheOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replaces the CacheOption's content for a given LinkedReport using the provided definition.
    apiInstance.SetLinkedReportCacheOptionsWithHttpInfo(cacheOptions, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.SetLinkedReportCacheOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cacheOptions** | [**CacheOptions**](CacheOptions.md) | Updated definition for the CacheOption&#39;s content associated with the LinkedReport specified by the Id. |  |
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="setlinkedreporthistorysnapshotoptions"></a>
# **SetLinkedReportHistorySnapshotOptions**
> void SetLinkedReportHistorySnapshotOptions (HistorySnapshotOptions historySnapshotOptions, string id)

Updates HistorySnapshotOptions property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class SetLinkedReportHistorySnapshotOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var historySnapshotOptions = new HistorySnapshotOptions(); // HistorySnapshotOptions | Modified HistorySnapshotOptions object.
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Updates HistorySnapshotOptions property.
                apiInstance.SetLinkedReportHistorySnapshotOptions(historySnapshotOptions, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.SetLinkedReportHistorySnapshotOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetLinkedReportHistorySnapshotOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates HistorySnapshotOptions property.
    apiInstance.SetLinkedReportHistorySnapshotOptionsWithHttpInfo(historySnapshotOptions, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.SetLinkedReportHistorySnapshotOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **historySnapshotOptions** | [**HistorySnapshotOptions**](HistorySnapshotOptions.md) | Modified HistorySnapshotOptions object. |  |
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **400** | Couldn&#39;t understand your request. |  -  |
| **404** | Not found. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="setlinkedreportpolicies"></a>
# **SetLinkedReportPolicies**
> void SetLinkedReportPolicies (List<ItemPolicy> itemPolicy, string id)

Replaces ItemPolicies associated with the specified LinkedReport item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class SetLinkedReportPoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var itemPolicy = new List<ItemPolicy>(); // List<ItemPolicy> | The ItemPolicy definitions that will be replaced.
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Replaces ItemPolicies associated with the specified LinkedReport item.
                apiInstance.SetLinkedReportPolicies(itemPolicy, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.SetLinkedReportPolicies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetLinkedReportPoliciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replaces ItemPolicies associated with the specified LinkedReport item.
    apiInstance.SetLinkedReportPoliciesWithHttpInfo(itemPolicy, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.SetLinkedReportPoliciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **itemPolicy** | [**List&lt;ItemPolicy&gt;**](ItemPolicy.md) | The ItemPolicy definitions that will be replaced. |  |
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="updatelinkedreport"></a>
# **UpdateLinkedReport**
> void UpdateLinkedReport (LinkedReport linkedReport, string id)

Updates the specified LinkedReport CatalogItem using the provided definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class UpdateLinkedReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var linkedReport = new LinkedReport(); // LinkedReport | Definition of the LinkedReport item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Updates the specified LinkedReport CatalogItem using the provided definition.
                apiInstance.UpdateLinkedReport(linkedReport, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.UpdateLinkedReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateLinkedReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the specified LinkedReport CatalogItem using the provided definition.
    apiInstance.UpdateLinkedReportWithHttpInfo(linkedReport, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.UpdateLinkedReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **linkedReport** | [**LinkedReport**](LinkedReport.md) | Definition of the LinkedReport item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged. |  |
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="updatelinkedreportcomment"></a>
# **UpdateLinkedReportComment**
> void UpdateLinkedReportComment (Comment comment, string id, string commentId)

Updates the Comment specified by CommentId in the associated LinkedReport.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class UpdateLinkedReportCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var comment = new Comment(); // Comment | The Comment to be updated
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var commentId = "commentId_example";  // string | The Id of the Comment.

            try
            {
                // Updates the Comment specified by CommentId in the associated LinkedReport.
                apiInstance.UpdateLinkedReportComment(comment, id, commentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.UpdateLinkedReportComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateLinkedReportCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the Comment specified by CommentId in the associated LinkedReport.
    apiInstance.UpdateLinkedReportCommentWithHttpInfo(comment, id, commentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.UpdateLinkedReportCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comment** | [**Comment**](Comment.md) | The Comment to be updated |  |
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |
| **commentId** | **string** | The Id of the Comment. |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="updatelinkedreportparameterdefinitions"></a>
# **UpdateLinkedReportParameterDefinitions**
> void UpdateLinkedReportParameterDefinitions (List<ReportParameterDefinitionPatch> parameterDefinitions, string id)

Updates the ParameterDefinitions associated with the specified LinkedReport by the Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class UpdateLinkedReportParameterDefinitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var parameterDefinitions = new List<ReportParameterDefinitionPatch>(); // List<ReportParameterDefinitionPatch> | Updated definitions for the ParameterDefinitions associated with the LinkedReport, represented as ParameterDefinitionsPatch objects. It is only necessary to include properties to be updated. All other property values will be left unchanged.
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Updates the ParameterDefinitions associated with the specified LinkedReport by the Id.
                apiInstance.UpdateLinkedReportParameterDefinitions(parameterDefinitions, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.UpdateLinkedReportParameterDefinitions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateLinkedReportParameterDefinitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the ParameterDefinitions associated with the specified LinkedReport by the Id.
    apiInstance.UpdateLinkedReportParameterDefinitionsWithHttpInfo(parameterDefinitions, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.UpdateLinkedReportParameterDefinitionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parameterDefinitions** | [**List&lt;ReportParameterDefinitionPatch&gt;**](ReportParameterDefinitionPatch.md) | Updated definitions for the ParameterDefinitions associated with the LinkedReport, represented as ParameterDefinitionsPatch objects. It is only necessary to include properties to be updated. All other property values will be left unchanged. |  |
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Couldn&#39;t understand your request. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="updatelinkedreportproperties"></a>
# **UpdateLinkedReportProperties**
> void UpdateLinkedReportProperties (List<Property> properties, string id)

Updates the LinkedReport Properties included in the given list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class UpdateLinkedReportPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new LinkedReportsApi(config);
            var properties = new List<Property>(); // List<Property> | The Properties that will be updated.
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Updates the LinkedReport Properties included in the given list.
                apiInstance.UpdateLinkedReportProperties(properties, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.UpdateLinkedReportProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateLinkedReportPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the LinkedReport Properties included in the given list.
    apiInstance.UpdateLinkedReportPropertiesWithHttpInfo(properties, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkedReportsApi.UpdateLinkedReportPropertiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **properties** | [**List&lt;Property&gt;**](Property.md) | The Properties that will be updated. |  |
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

