# SSRSRestV2.Api.ExtensionsApi

All URIs are relative to *http://localhost/reports/api/v2.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetExtensionParameters**](ExtensionsApi.md#getextensionparameters) | **GET** /Extensions({Id})/Parameters | Retrieves the ExtensionParameter list for given extension. |
| [**GetExtensions**](ExtensionsApi.md#getextensions) | **GET** /Extensions | Retreives all Extension items. |
| [**ValidateExtensionParameters**](ExtensionsApi.md#validateextensionparameters) | **POST** /Extensions/Model.ValidateExtensionSettings | Validates extension parameters and returns collection of ExtensionParameter. |

<a name="getextensionparameters"></a>
# **GetExtensionParameters**
> List&lt;ExtensionParameter&gt; GetExtensionParameters (string id)

Retrieves the ExtensionParameter list for given extension.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetExtensionParametersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new ExtensionsApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Retrieves the ExtensionParameter list for given extension.
                List<ExtensionParameter> result = apiInstance.GetExtensionParameters(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExtensionsApi.GetExtensionParameters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExtensionParametersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the ExtensionParameter list for given extension.
    ApiResponse<List<ExtensionParameter>> response = apiInstance.GetExtensionParametersWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExtensionsApi.GetExtensionParametersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

[**List&lt;ExtensionParameter&gt;**](ExtensionParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A array of ExtensionParameter objects. |  -  |
| **400** | Couldn&#39;t understand your request. |  -  |
| **404** | Not found. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getextensions"></a>
# **GetExtensions**
> List&lt;Extension&gt; GetExtensions ()

Retreives all Extension items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetExtensionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new ExtensionsApi(config);

            try
            {
                // Retreives all Extension items.
                List<Extension> result = apiInstance.GetExtensions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExtensionsApi.GetExtensions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExtensionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retreives all Extension items.
    ApiResponse<List<Extension>> response = apiInstance.GetExtensionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExtensionsApi.GetExtensionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Extension&gt;**](Extension.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A array of Extension objects. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="validateextensionparameters"></a>
# **ValidateExtensionParameters**
> List&lt;ExtensionParameter&gt; ValidateExtensionParameters (ExtensionSettings extensionSettings = null)

Validates extension parameters and returns collection of ExtensionParameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class ValidateExtensionParametersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new ExtensionsApi(config);
            var extensionSettings = new ExtensionSettings(); // ExtensionSettings |  (optional) 

            try
            {
                // Validates extension parameters and returns collection of ExtensionParameter.
                List<ExtensionParameter> result = apiInstance.ValidateExtensionParameters(extensionSettings);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExtensionsApi.ValidateExtensionParameters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidateExtensionParametersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validates extension parameters and returns collection of ExtensionParameter.
    ApiResponse<List<ExtensionParameter>> response = apiInstance.ValidateExtensionParametersWithHttpInfo(extensionSettings);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExtensionsApi.ValidateExtensionParametersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **extensionSettings** | [**ExtensionSettings**](ExtensionSettings.md) |  | [optional]  |

### Return type

[**List&lt;ExtensionParameter&gt;**](ExtensionParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A array of ExtensionParameter objects. |  -  |
| **400** | Couldn&#39;t understand your request. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

