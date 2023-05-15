# SSRSRestV2.Api.MobileReportsApi

All URIs are relative to *http://localhost/reports/api/v2.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddMobileReport**](MobileReportsApi.md#addmobilereport) | **POST** /MobileReports | Creates new MobileReport item |
| [**AddMobileReportComment**](MobileReportsApi.md#addmobilereportcomment) | **POST** /MobileReports({Id})/Comments | Creates a new Comment associated to the specified MobileReport. |
| [**DeleteMobileReport**](MobileReportsApi.md#deletemobilereport) | **DELETE** /MobileReports({Id}) | Delete the specified MobileReport. |
| [**DeleteMobileReportComment**](MobileReportsApi.md#deletemobilereportcomment) | **DELETE** /MobileReports({Id})/Comments({CommentId}) | Deletes the specified Comment associated to the MobileReport. |
| [**GetMobileReport**](MobileReportsApi.md#getmobilereport) | **GET** /MobileReports({Id}) | Fetch MobileReport item by Id or path property. |
| [**GetMobileReportAllowedActions**](MobileReportsApi.md#getmobilereportallowedactions) | **GET** /MobileReports({Id})/AllowedActions | Gets a list of actions allowed in the current session; considering user permissions and product edition capabilities. |
| [**GetMobileReportComments**](MobileReportsApi.md#getmobilereportcomments) | **GET** /MobileReports({Id})/Comments | Gets the Comments for a MobileReport specified by the Id. |
| [**GetMobileReportContent**](MobileReportsApi.md#getmobilereportcontent) | **GET** /MobileReports({Id})/Content/$value | Gets the content of the specified MobileReport CatalogItem. |
| [**GetMobileReportPolicies**](MobileReportsApi.md#getmobilereportpolicies) | **GET** /MobileReports({Id})/Policies | Gets ItemPolicies associated with the MobileReport catalog item. |
| [**GetMobileReportProperties**](MobileReportsApi.md#getmobilereportproperties) | **GET** /MobileReports({Id})/Properties | Gets MobileReport Properties (takes list of Property names to retrieve the values) |
| [**GetMobileReports**](MobileReportsApi.md#getmobilereports) | **GET** /MobileReports | Retrieve array of MobileReport catalog items. |
| [**SetMobileReportPolicies**](MobileReportsApi.md#setmobilereportpolicies) | **PUT** /MobileReports({Id})/Policies | Sets ItemPolicies on the MobileReport item. |
| [**UpdateMobileReport**](MobileReportsApi.md#updatemobilereport) | **PATCH** /MobileReports({Id}) | Updates the specified MobileReport CatalogItem using the provided definition. |
| [**UpdateMobileReportComment**](MobileReportsApi.md#updatemobilereportcomment) | **PUT** /MobileReports({Id})/Comments({CommentId}) | Updates the Comment specified by CommentId in the associated MobileReport. |
| [**UpdateMobileReportProperties**](MobileReportsApi.md#updatemobilereportproperties) | **PUT** /MobileReports({Id})/Properties | Updates the MobileReport properties included in the given list. |

<a name="addmobilereport"></a>
# **AddMobileReport**
> MobileReport AddMobileReport (MobileReport body)

Creates new MobileReport item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class AddMobileReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new MobileReportsApi(config);
            var body = new MobileReport(); // MobileReport | The definition of the new MobileReport item.

            try
            {
                // Creates new MobileReport item
                MobileReport result = apiInstance.AddMobileReport(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MobileReportsApi.AddMobileReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMobileReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates new MobileReport item
    ApiResponse<MobileReport> response = apiInstance.AddMobileReportWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MobileReportsApi.AddMobileReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**MobileReport**](MobileReport.md) | The definition of the new MobileReport item. |  |

### Return type

[**MobileReport**](MobileReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **409** | Conflict. Item already exists. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="addmobilereportcomment"></a>
# **AddMobileReportComment**
> void AddMobileReportComment (Comment comment, string id)

Creates a new Comment associated to the specified MobileReport.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class AddMobileReportCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new MobileReportsApi(config);
            var comment = new Comment(); // Comment | The Comment to be created
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Creates a new Comment associated to the specified MobileReport.
                apiInstance.AddMobileReportComment(comment, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MobileReportsApi.AddMobileReportComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMobileReportCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new Comment associated to the specified MobileReport.
    apiInstance.AddMobileReportCommentWithHttpInfo(comment, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MobileReportsApi.AddMobileReportCommentWithHttpInfo: " + e.Message);
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

<a name="deletemobilereport"></a>
# **DeleteMobileReport**
> void DeleteMobileReport (string id)

Delete the specified MobileReport.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class DeleteMobileReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new MobileReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Delete the specified MobileReport.
                apiInstance.DeleteMobileReport(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MobileReportsApi.DeleteMobileReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMobileReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete the specified MobileReport.
    apiInstance.DeleteMobileReportWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MobileReportsApi.DeleteMobileReportWithHttpInfo: " + e.Message);
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

<a name="deletemobilereportcomment"></a>
# **DeleteMobileReportComment**
> void DeleteMobileReportComment (string id, string commentId)

Deletes the specified Comment associated to the MobileReport.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class DeleteMobileReportCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new MobileReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var commentId = "commentId_example";  // string | The Id of the Comment.

            try
            {
                // Deletes the specified Comment associated to the MobileReport.
                apiInstance.DeleteMobileReportComment(id, commentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MobileReportsApi.DeleteMobileReportComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMobileReportCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes the specified Comment associated to the MobileReport.
    apiInstance.DeleteMobileReportCommentWithHttpInfo(id, commentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MobileReportsApi.DeleteMobileReportCommentWithHttpInfo: " + e.Message);
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

<a name="getmobilereport"></a>
# **GetMobileReport**
> MobileReport GetMobileReport (string id)

Fetch MobileReport item by Id or path property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetMobileReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new MobileReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Fetch MobileReport item by Id or path property.
                MobileReport result = apiInstance.GetMobileReport(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MobileReportsApi.GetMobileReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMobileReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch MobileReport item by Id or path property.
    ApiResponse<MobileReport> response = apiInstance.GetMobileReportWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MobileReportsApi.GetMobileReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

[**MobileReport**](MobileReport.md)

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

<a name="getmobilereportallowedactions"></a>
# **GetMobileReportAllowedActions**
> ODataAllowedActions GetMobileReportAllowedActions (string id)

Gets a list of actions allowed in the current session; considering user permissions and product edition capabilities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetMobileReportAllowedActionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new MobileReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a list of actions allowed in the current session; considering user permissions and product edition capabilities.
                ODataAllowedActions result = apiInstance.GetMobileReportAllowedActions(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MobileReportsApi.GetMobileReportAllowedActions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMobileReportAllowedActionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of actions allowed in the current session; considering user permissions and product edition capabilities.
    ApiResponse<ODataAllowedActions> response = apiInstance.GetMobileReportAllowedActionsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MobileReportsApi.GetMobileReportAllowedActionsWithHttpInfo: " + e.Message);
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

<a name="getmobilereportcomments"></a>
# **GetMobileReportComments**
> ODataComments GetMobileReportComments (string id)

Gets the Comments for a MobileReport specified by the Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetMobileReportCommentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new MobileReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the Comments for a MobileReport specified by the Id.
                ODataComments result = apiInstance.GetMobileReportComments(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MobileReportsApi.GetMobileReportComments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMobileReportCommentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the Comments for a MobileReport specified by the Id.
    ApiResponse<ODataComments> response = apiInstance.GetMobileReportCommentsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MobileReportsApi.GetMobileReportCommentsWithHttpInfo: " + e.Message);
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
| **200** | A collection of Comments associated to the MobileReport |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getmobilereportcontent"></a>
# **GetMobileReportContent**
> System.IO.Stream GetMobileReportContent (string id)

Gets the content of the specified MobileReport CatalogItem.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetMobileReportContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new MobileReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the content of the specified MobileReport CatalogItem.
                System.IO.Stream result = apiInstance.GetMobileReportContent(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MobileReportsApi.GetMobileReportContent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMobileReportContentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the content of the specified MobileReport CatalogItem.
    ApiResponse<System.IO.Stream> response = apiInstance.GetMobileReportContentWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MobileReportsApi.GetMobileReportContentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The content of the specified MobileReport CatalogItem. |  -  |
| **404** | Not found. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getmobilereportpolicies"></a>
# **GetMobileReportPolicies**
> List&lt;ItemPolicy&gt; GetMobileReportPolicies (string id)

Gets ItemPolicies associated with the MobileReport catalog item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetMobileReportPoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new MobileReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets ItemPolicies associated with the MobileReport catalog item.
                List<ItemPolicy> result = apiInstance.GetMobileReportPolicies(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MobileReportsApi.GetMobileReportPolicies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMobileReportPoliciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets ItemPolicies associated with the MobileReport catalog item.
    ApiResponse<List<ItemPolicy>> response = apiInstance.GetMobileReportPoliciesWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MobileReportsApi.GetMobileReportPoliciesWithHttpInfo: " + e.Message);
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
| **200** | Ok |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getmobilereportproperties"></a>
# **GetMobileReportProperties**
> ODataProperties GetMobileReportProperties (string id, List<string> properties = null)

Gets MobileReport Properties (takes list of Property names to retrieve the values)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetMobileReportPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new MobileReportsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<string>(); // List<string> | Names for the Properties to be returned. (optional) 

            try
            {
                // Gets MobileReport Properties (takes list of Property names to retrieve the values)
                ODataProperties result = apiInstance.GetMobileReportProperties(id, properties);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MobileReportsApi.GetMobileReportProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMobileReportPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets MobileReport Properties (takes list of Property names to retrieve the values)
    ApiResponse<ODataProperties> response = apiInstance.GetMobileReportPropertiesWithHttpInfo(id, properties);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MobileReportsApi.GetMobileReportPropertiesWithHttpInfo: " + e.Message);
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

<a name="getmobilereports"></a>
# **GetMobileReports**
> ODataMobileReport GetMobileReports (int? top = null, int? skip = null, string filter = null, string count = null)

Retrieve array of MobileReport catalog items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetMobileReportsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new MobileReportsApi(config);
            var top = 56;  // int? | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) (optional) 
            var filter = "filter_example";  // string | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) (optional) 
            var count = "count_example";  // string | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) (optional) 

            try
            {
                // Retrieve array of MobileReport catalog items.
                ODataMobileReport result = apiInstance.GetMobileReports(top, skip, filter, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MobileReportsApi.GetMobileReports: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMobileReportsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve array of MobileReport catalog items.
    ApiResponse<ODataMobileReport> response = apiInstance.GetMobileReportsWithHttpInfo(top, skip, filter, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MobileReportsApi.GetMobileReportsWithHttpInfo: " + e.Message);
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

### Return type

[**ODataMobileReport**](ODataMobileReport.md)

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

<a name="setmobilereportpolicies"></a>
# **SetMobileReportPolicies**
> void SetMobileReportPolicies (List<ItemPolicy> mobileReports, string id)

Sets ItemPolicies on the MobileReport item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class SetMobileReportPoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new MobileReportsApi(config);
            var mobileReports = new List<ItemPolicy>(); // List<ItemPolicy> | Array of ItemPolicies to set on the MobileReport CatalogItem.
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Sets ItemPolicies on the MobileReport item.
                apiInstance.SetMobileReportPolicies(mobileReports, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MobileReportsApi.SetMobileReportPolicies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetMobileReportPoliciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets ItemPolicies on the MobileReport item.
    apiInstance.SetMobileReportPoliciesWithHttpInfo(mobileReports, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MobileReportsApi.SetMobileReportPoliciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mobileReports** | [**List&lt;ItemPolicy&gt;**](ItemPolicy.md) | Array of ItemPolicies to set on the MobileReport CatalogItem. |  |
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

<a name="updatemobilereport"></a>
# **UpdateMobileReport**
> MobileReport UpdateMobileReport (MobileReport body, string id)

Updates the specified MobileReport CatalogItem using the provided definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class UpdateMobileReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new MobileReportsApi(config);
            var body = new MobileReport(); // MobileReport | Definition of the MobileReport item that replaces the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Updates the specified MobileReport CatalogItem using the provided definition.
                MobileReport result = apiInstance.UpdateMobileReport(body, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MobileReportsApi.UpdateMobileReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMobileReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the specified MobileReport CatalogItem using the provided definition.
    ApiResponse<MobileReport> response = apiInstance.UpdateMobileReportWithHttpInfo(body, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MobileReportsApi.UpdateMobileReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**MobileReport**](MobileReport.md) | Definition of the MobileReport item that replaces the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged. |  |
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

[**MobileReport**](MobileReport.md)

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

<a name="updatemobilereportcomment"></a>
# **UpdateMobileReportComment**
> void UpdateMobileReportComment (Comment comment, string id, string commentId)

Updates the Comment specified by CommentId in the associated MobileReport.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class UpdateMobileReportCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new MobileReportsApi(config);
            var comment = new Comment(); // Comment | The Comment to be updated
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var commentId = "commentId_example";  // string | The Id of the Comment.

            try
            {
                // Updates the Comment specified by CommentId in the associated MobileReport.
                apiInstance.UpdateMobileReportComment(comment, id, commentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MobileReportsApi.UpdateMobileReportComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMobileReportCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the Comment specified by CommentId in the associated MobileReport.
    apiInstance.UpdateMobileReportCommentWithHttpInfo(comment, id, commentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MobileReportsApi.UpdateMobileReportCommentWithHttpInfo: " + e.Message);
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

<a name="updatemobilereportproperties"></a>
# **UpdateMobileReportProperties**
> void UpdateMobileReportProperties (List<Property> properties, string id)

Updates the MobileReport properties included in the given list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class UpdateMobileReportPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new MobileReportsApi(config);
            var properties = new List<Property>(); // List<Property> | The Properties that will be updated.
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Updates the MobileReport properties included in the given list.
                apiInstance.UpdateMobileReportProperties(properties, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MobileReportsApi.UpdateMobileReportProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMobileReportPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the MobileReport properties included in the given list.
    apiInstance.UpdateMobileReportPropertiesWithHttpInfo(properties, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MobileReportsApi.UpdateMobileReportPropertiesWithHttpInfo: " + e.Message);
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

