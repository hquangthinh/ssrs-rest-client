# SSRSRestV2.Api.CacheRefreshPlansApi

All URIs are relative to *http://localhost/reports/api/v2.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddCacheRefreshPlan**](CacheRefreshPlansApi.md#addcacherefreshplan) | **POST** /CacheRefreshPlans | Creates a new CacheRefreshPlan item. |
| [**DeleteCacheRefreshPlan**](CacheRefreshPlansApi.md#deletecacherefreshplan) | **DELETE** /CacheRefreshPlans({Id}) | Deletes the specified CacheRefreshPlan. |
| [**ExecuteCacheRefreshPlan**](CacheRefreshPlansApi.md#executecacherefreshplan) | **POST** /CacheRefreshPlans({Id})/Model.Execute | Executes given CacheRefreshPlan immediately. |
| [**GetCacheRefreshPlan**](CacheRefreshPlansApi.md#getcacherefreshplan) | **GET** /CacheRefreshPlans({Id}) | Gets a CacheRefreshPlan item specified by the Id. |
| [**SetCacheRefreshPlan**](CacheRefreshPlansApi.md#setcacherefreshplan) | **PUT** /CacheRefreshPlans({Id}) | Replaces the specified CacheRefreshPlan item using the provided definition. |

<a name="addcacherefreshplan"></a>
# **AddCacheRefreshPlan**
> CacheRefreshPlan AddCacheRefreshPlan (CacheRefreshPlan cacheRefreshPlan)

Creates a new CacheRefreshPlan item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class AddCacheRefreshPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new CacheRefreshPlansApi(config);
            var cacheRefreshPlan = new CacheRefreshPlan(); // CacheRefreshPlan | The definition of the new CacheRefreshPlan item.

            try
            {
                // Creates a new CacheRefreshPlan item.
                CacheRefreshPlan result = apiInstance.AddCacheRefreshPlan(cacheRefreshPlan);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CacheRefreshPlansApi.AddCacheRefreshPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddCacheRefreshPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new CacheRefreshPlan item.
    ApiResponse<CacheRefreshPlan> response = apiInstance.AddCacheRefreshPlanWithHttpInfo(cacheRefreshPlan);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CacheRefreshPlansApi.AddCacheRefreshPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cacheRefreshPlan** | [**CacheRefreshPlan**](CacheRefreshPlan.md) | The definition of the new CacheRefreshPlan item. |  |

### Return type

[**CacheRefreshPlan**](CacheRefreshPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The definition of the CacheRefreshPlan item that was just created. |  -  |
| **400** | Couldn&#39;t understand your request. |  -  |
| **409** | Conflict. Item already exists. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="deletecacherefreshplan"></a>
# **DeleteCacheRefreshPlan**
> void DeleteCacheRefreshPlan (string id)

Deletes the specified CacheRefreshPlan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class DeleteCacheRefreshPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new CacheRefreshPlansApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Deletes the specified CacheRefreshPlan.
                apiInstance.DeleteCacheRefreshPlan(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CacheRefreshPlansApi.DeleteCacheRefreshPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCacheRefreshPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes the specified CacheRefreshPlan.
    apiInstance.DeleteCacheRefreshPlanWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CacheRefreshPlansApi.DeleteCacheRefreshPlanWithHttpInfo: " + e.Message);
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

<a name="executecacherefreshplan"></a>
# **ExecuteCacheRefreshPlan**
> void ExecuteCacheRefreshPlan (string id)

Executes given CacheRefreshPlan immediately.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class ExecuteCacheRefreshPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new CacheRefreshPlansApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Executes given CacheRefreshPlan immediately.
                apiInstance.ExecuteCacheRefreshPlan(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CacheRefreshPlansApi.ExecuteCacheRefreshPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExecuteCacheRefreshPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Executes given CacheRefreshPlan immediately.
    apiInstance.ExecuteCacheRefreshPlanWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CacheRefreshPlansApi.ExecuteCacheRefreshPlanWithHttpInfo: " + e.Message);
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
| **204** | The return result is empty. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getcacherefreshplan"></a>
# **GetCacheRefreshPlan**
> CacheRefreshPlan GetCacheRefreshPlan (string id)

Gets a CacheRefreshPlan item specified by the Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetCacheRefreshPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new CacheRefreshPlansApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a CacheRefreshPlan item specified by the Id.
                CacheRefreshPlan result = apiInstance.GetCacheRefreshPlan(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CacheRefreshPlansApi.GetCacheRefreshPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCacheRefreshPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a CacheRefreshPlan item specified by the Id.
    ApiResponse<CacheRefreshPlan> response = apiInstance.GetCacheRefreshPlanWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CacheRefreshPlansApi.GetCacheRefreshPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

[**CacheRefreshPlan**](CacheRefreshPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The CacheRefreshPlan item specified by the Id. |  -  |
| **400** | Couldn&#39;t understand your request. |  -  |
| **404** | Not found. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="setcacherefreshplan"></a>
# **SetCacheRefreshPlan**
> CacheRefreshPlan SetCacheRefreshPlan (CacheRefreshPlan cacheRefreshPlan, string id)

Replaces the specified CacheRefreshPlan item using the provided definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class SetCacheRefreshPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new CacheRefreshPlansApi(config);
            var cacheRefreshPlan = new CacheRefreshPlan(); // CacheRefreshPlan | Definition of the CacheRefreshPlan item that updates the current item on the server.
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Replaces the specified CacheRefreshPlan item using the provided definition.
                CacheRefreshPlan result = apiInstance.SetCacheRefreshPlan(cacheRefreshPlan, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CacheRefreshPlansApi.SetCacheRefreshPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetCacheRefreshPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replaces the specified CacheRefreshPlan item using the provided definition.
    ApiResponse<CacheRefreshPlan> response = apiInstance.SetCacheRefreshPlanWithHttpInfo(cacheRefreshPlan, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CacheRefreshPlansApi.SetCacheRefreshPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cacheRefreshPlan** | [**CacheRefreshPlan**](CacheRefreshPlan.md) | Definition of the CacheRefreshPlan item that updates the current item on the server. |  |
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

[**CacheRefreshPlan**](CacheRefreshPlan.md)

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

