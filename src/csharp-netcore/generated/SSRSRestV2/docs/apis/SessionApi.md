# SSRSRestV2.Api.SessionApi

All URIs are relative to *http://localhost/reports/api/v2.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSession**](SessionApi.md#createsession) | **POST** /Session | Creates a new session |
| [**DeleteSession**](SessionApi.md#deletesession) | **DELETE** /Session | Deletes the currently active session |

<a name="createsession"></a>
# **CreateSession**
> void CreateSession (UserCredentials userCredentials)

Creates a new session

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class CreateSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new SessionApi(config);
            var userCredentials = new UserCredentials(); // UserCredentials | The credentials of the user to logon as

            try
            {
                // Creates a new session
                apiInstance.CreateSession(userCredentials);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionApi.CreateSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new session
    apiInstance.CreateSessionWithHttpInfo(userCredentials);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionApi.CreateSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userCredentials** | [**UserCredentials**](UserCredentials.md) | The credentials of the user to logon as |  |

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
| **201** | A session for the user credentials was created and a forms authentication cookie was sent as part of the response. |  -  |
| **400** | Couldn&#39;t understand your request. |  -  |
| **401** | The credentials provided are invalid. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="deletesession"></a>
# **DeleteSession**
> void DeleteSession ()

Deletes the currently active session

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class DeleteSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new SessionApi(config);

            try
            {
                // Deletes the currently active session
                apiInstance.DeleteSession();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionApi.DeleteSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes the currently active session
    apiInstance.DeleteSessionWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionApi.DeleteSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An empty session cookie is sent with the response. |  -  |
| **401** | The user is not yet authenticated. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

