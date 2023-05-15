# SSRSRestV2.Api.SystemApi

All URIs are relative to *http://localhost/reports/api/v2.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSystemAllowedActions**](SystemApi.md#getsystemallowedactions) | **GET** /System/AllowedActions | Gets a list of system level actions allowed in the current session; user permissions and product edition capabilities are considered when querying. |
| [**GetSystemInfo**](SystemApi.md#getsysteminfo) | **GET** /System | Get SystemInformation |
| [**GetSystemPolicies**](SystemApi.md#getsystempolicies) | **GET** /System/Policies | Gets the System Policies. |
| [**GetSystemProperties**](SystemApi.md#getsystemproperties) | **GET** /System/Properties | Gets the Systems Properties (takes list of Property names to retrieve the values) |
| [**SetSystemPolicies**](SystemApi.md#setsystempolicies) | **PUT** /System/Policies | Updates the System&#39;s Policies. |
| [**UpdateSystemProperties**](SystemApi.md#updatesystemproperties) | **PATCH** /System/Properties | Updates the System Properties with the given property list. |

<a name="getsystemallowedactions"></a>
# **GetSystemAllowedActions**
> ODataAllowedActions GetSystemAllowedActions ()

Gets a list of system level actions allowed in the current session; user permissions and product edition capabilities are considered when querying.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetSystemAllowedActionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new SystemApi(config);

            try
            {
                // Gets a list of system level actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
                ODataAllowedActions result = apiInstance.GetSystemAllowedActions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemAllowedActions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemAllowedActionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of system level actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
    ApiResponse<ODataAllowedActions> response = apiInstance.GetSystemAllowedActionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.GetSystemAllowedActionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a name="getsysteminfo"></a>
# **GetSystemInfo**
> SystemInfo GetSystemInfo ()

Get SystemInformation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetSystemInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new SystemApi(config);

            try
            {
                // Get SystemInformation
                SystemInfo result = apiInstance.GetSystemInfo();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SystemInformation
    ApiResponse<SystemInfo> response = apiInstance.GetSystemInfoWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.GetSystemInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SystemInfo**](SystemInfo.md)

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

<a name="getsystempolicies"></a>
# **GetSystemPolicies**
> List&lt;Policy&gt; GetSystemPolicies ()

Gets the System Policies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetSystemPoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new SystemApi(config);

            try
            {
                // Gets the System Policies.
                List<Policy> result = apiInstance.GetSystemPolicies();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemPolicies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemPoliciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the System Policies.
    ApiResponse<List<Policy>> response = apiInstance.GetSystemPoliciesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.GetSystemPoliciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Policy&gt;**](Policy.md)

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

<a name="getsystemproperties"></a>
# **GetSystemProperties**
> ODataProperties GetSystemProperties (List<string> properties = null)

Gets the Systems Properties (takes list of Property names to retrieve the values)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetSystemPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new SystemApi(config);
            var properties = new List<string>(); // List<string> | Names for the Properties to be returned. (optional) 

            try
            {
                // Gets the Systems Properties (takes list of Property names to retrieve the values)
                ODataProperties result = apiInstance.GetSystemProperties(properties);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the Systems Properties (takes list of Property names to retrieve the values)
    ApiResponse<ODataProperties> response = apiInstance.GetSystemPropertiesWithHttpInfo(properties);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.GetSystemPropertiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

<a name="setsystempolicies"></a>
# **SetSystemPolicies**
> void SetSystemPolicies (SystemPolicy systemPolicy)

Updates the System's Policies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class SetSystemPoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new SystemApi(config);
            var systemPolicy = new SystemPolicy(); // SystemPolicy | The SystemPolicy object that contains settings to apply.

            try
            {
                // Updates the System's Policies.
                apiInstance.SetSystemPolicies(systemPolicy);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.SetSystemPolicies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetSystemPoliciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the System's Policies.
    apiInstance.SetSystemPoliciesWithHttpInfo(systemPolicy);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.SetSystemPoliciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **systemPolicy** | [**SystemPolicy**](SystemPolicy.md) | The SystemPolicy object that contains settings to apply. |  |

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

<a name="updatesystemproperties"></a>
# **UpdateSystemProperties**
> void UpdateSystemProperties (List<Property> properties)

Updates the System Properties with the given property list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class UpdateSystemPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new SystemApi(config);
            var properties = new List<Property>(); // List<Property> | Definition of the SystemProperties that updates the current item on the server. It is only necessary to include properties to be updated. All other property values will be left unchanged.

            try
            {
                // Updates the System Properties with the given property list.
                apiInstance.UpdateSystemProperties(properties);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.UpdateSystemProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSystemPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the System Properties with the given property list.
    apiInstance.UpdateSystemPropertiesWithHttpInfo(properties);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.UpdateSystemPropertiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **properties** | [**List&lt;Property&gt;**](Property.md) | Definition of the SystemProperties that updates the current item on the server. It is only necessary to include properties to be updated. All other property values will be left unchanged. |  |

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

