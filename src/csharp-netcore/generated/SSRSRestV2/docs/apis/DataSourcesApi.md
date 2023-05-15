# SSRSRestV2.Api.DataSourcesApi

All URIs are relative to *http://localhost/reports/api/v2.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddDataSource**](DataSourcesApi.md#adddatasource) | **POST** /DataSources | Creates a new DataSource CatalogItem. |
| [**CheckExistingDataSourceConnection**](DataSourcesApi.md#checkexistingdatasourceconnection) | **POST** /DataSources({Id})/Model.CheckConnection | Tests the connection for a data source. This method supports the testing of published data sources that are used by reports and shared data sources |
| [**CheckNewDataSourceConnection**](DataSourcesApi.md#checknewdatasourceconnection) | **POST** /DataSources/Model.CheckConnection | Tests the connection for a data source. This method supports the direct testing of the unsaved data source. |
| [**DeleteDataSource**](DataSourcesApi.md#deletedatasource) | **DELETE** /DataSources({Id}) | Deletes the specified DataSource. |
| [**GetDataSource**](DataSourcesApi.md#getdatasource) | **GET** /DataSources({Id}) | Gets a DataSource CatalogItem specified by the Id. |
| [**GetDataSourceAllowedActions**](DataSourcesApi.md#getdatasourceallowedactions) | **GET** /DataSources({Id})/AllowedActions | Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying. |
| [**GetDataSourceContent**](DataSourcesApi.md#getdatasourcecontent) | **GET** /DataSources({Id})/Content/$value | Gets the content of the DataSource CatalogItem specified by the Id. |
| [**GetDataSourceDependentItems**](DataSourcesApi.md#getdatasourcedependentitems) | **GET** /DataSources({Id})/DependentItems | Returns a list of CatalogItems that reference the DataSource specified by the Id. |
| [**GetDataSourcePolicies**](DataSourcesApi.md#getdatasourcepolicies) | **GET** /DataSources({Id})/Policies | Gets ItemPolicies associated with the DataSource specified by the Id. |
| [**GetDataSourceQueryFields**](DataSourcesApi.md#getdatasourcequeryfields) | **POST** /DataSources/Model.GetQueryFields | Retrieves a dataset that contains the fields retrieved by the delivery query for a data-driven subscription. |
| [**GetDataSources**](DataSourcesApi.md#getdatasources) | **GET** /DataSources | Gets an array of DataSource CatalogItems. |
| [**GetDatasourceProperties**](DataSourcesApi.md#getdatasourceproperties) | **GET** /DataSources({Id})/Properties | Gets DataSource Properties (takes list of property names to retrieve the values) |
| [**SetDataSourcePolicies**](DataSourcesApi.md#setdatasourcepolicies) | **PUT** /DataSources({Id})/Policies | Replaces ItemPolicies associated with the DataSource specified by the Id. |
| [**UpdateDataSource**](DataSourcesApi.md#updatedatasource) | **PATCH** /DataSources({Id}) | Updates the DataSource CatalogItem specified by the Id using the provided definition. |
| [**UpdateDatasourceProperties**](DataSourcesApi.md#updatedatasourceproperties) | **PUT** /DataSources({Id})/Properties | Updates the DataSource Properties included in the given list. |

<a name="adddatasource"></a>
# **AddDataSource**
> DataSource AddDataSource (DataSource dataSource)

Creates a new DataSource CatalogItem.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class AddDataSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new DataSourcesApi(config);
            var dataSource = new DataSource(); // DataSource | The definition of the new DataSource CatalogItem.

            try
            {
                // Creates a new DataSource CatalogItem.
                DataSource result = apiInstance.AddDataSource(dataSource);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourcesApi.AddDataSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddDataSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new DataSource CatalogItem.
    ApiResponse<DataSource> response = apiInstance.AddDataSourceWithHttpInfo(dataSource);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourcesApi.AddDataSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dataSource** | [**DataSource**](DataSource.md) | The definition of the new DataSource CatalogItem. |  |

### Return type

[**DataSource**](DataSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The definition of the DataSource item that was just created. |  -  |
| **400** | Couldn&#39;t understand your request. |  -  |
| **409** | Conflict. Item already exists. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="checkexistingdatasourceconnection"></a>
# **CheckExistingDataSourceConnection**
> DataSourceCheckResult CheckExistingDataSourceConnection (string id)

Tests the connection for a data source. This method supports the testing of published data sources that are used by reports and shared data sources

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class CheckExistingDataSourceConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new DataSourcesApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Tests the connection for a data source. This method supports the testing of published data sources that are used by reports and shared data sources
                DataSourceCheckResult result = apiInstance.CheckExistingDataSourceConnection(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourcesApi.CheckExistingDataSourceConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CheckExistingDataSourceConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Tests the connection for a data source. This method supports the testing of published data sources that are used by reports and shared data sources
    ApiResponse<DataSourceCheckResult> response = apiInstance.CheckExistingDataSourceConnectionWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourcesApi.CheckExistingDataSourceConnectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

[**DataSourceCheckResult**](DataSourceCheckResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A DataSourceCheckResult that contains the results of the check connection operation. |  -  |
| **400** | Couldn&#39;t understand your request. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="checknewdatasourceconnection"></a>
# **CheckNewDataSourceConnection**
> DataSourceCheckResult CheckNewDataSourceConnection (DataSource dataSource)

Tests the connection for a data source. This method supports the direct testing of the unsaved data source.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class CheckNewDataSourceConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new DataSourcesApi(config);
            var dataSource = new DataSource(); // DataSource | The definition of data source.  Must contain connectionstring, data provider, and credentials to connect to the data source.

            try
            {
                // Tests the connection for a data source. This method supports the direct testing of the unsaved data source.
                DataSourceCheckResult result = apiInstance.CheckNewDataSourceConnection(dataSource);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourcesApi.CheckNewDataSourceConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CheckNewDataSourceConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Tests the connection for a data source. This method supports the direct testing of the unsaved data source.
    ApiResponse<DataSourceCheckResult> response = apiInstance.CheckNewDataSourceConnectionWithHttpInfo(dataSource);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourcesApi.CheckNewDataSourceConnectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dataSource** | [**DataSource**](DataSource.md) | The definition of data source.  Must contain connectionstring, data provider, and credentials to connect to the data source. |  |

### Return type

[**DataSourceCheckResult**](DataSourceCheckResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A DataSourceCheckResult that contains the results of the check connection operation. |  -  |
| **400** | Couldn&#39;t understand your request. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="deletedatasource"></a>
# **DeleteDataSource**
> void DeleteDataSource (string id)

Deletes the specified DataSource.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class DeleteDataSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new DataSourcesApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Deletes the specified DataSource.
                apiInstance.DeleteDataSource(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourcesApi.DeleteDataSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDataSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes the specified DataSource.
    apiInstance.DeleteDataSourceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourcesApi.DeleteDataSourceWithHttpInfo: " + e.Message);
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

<a name="getdatasource"></a>
# **GetDataSource**
> DataSource GetDataSource (string id)

Gets a DataSource CatalogItem specified by the Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetDataSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new DataSourcesApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a DataSource CatalogItem specified by the Id.
                DataSource result = apiInstance.GetDataSource(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourcesApi.GetDataSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a DataSource CatalogItem specified by the Id.
    ApiResponse<DataSource> response = apiInstance.GetDataSourceWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourcesApi.GetDataSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

[**DataSource**](DataSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The DataSource CatalogItem specified by the Id. |  -  |
| **400** | Couldn&#39;t understand your request. |  -  |
| **404** | Not found. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getdatasourceallowedactions"></a>
# **GetDataSourceAllowedActions**
> ODataAllowedActions GetDataSourceAllowedActions (string id)

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
    public class GetDataSourceAllowedActionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new DataSourcesApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
                ODataAllowedActions result = apiInstance.GetDataSourceAllowedActions(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourcesApi.GetDataSourceAllowedActions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataSourceAllowedActionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
    ApiResponse<ODataAllowedActions> response = apiInstance.GetDataSourceAllowedActionsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourcesApi.GetDataSourceAllowedActionsWithHttpInfo: " + e.Message);
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
| **200** | Ok. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getdatasourcecontent"></a>
# **GetDataSourceContent**
> System.IO.Stream GetDataSourceContent (string id)

Gets the content of the DataSource CatalogItem specified by the Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetDataSourceContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new DataSourcesApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the content of the DataSource CatalogItem specified by the Id.
                System.IO.Stream result = apiInstance.GetDataSourceContent(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourcesApi.GetDataSourceContent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataSourceContentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the content of the DataSource CatalogItem specified by the Id.
    ApiResponse<System.IO.Stream> response = apiInstance.GetDataSourceContentWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourcesApi.GetDataSourceContentWithHttpInfo: " + e.Message);
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
| **200** | The content of the DataSource CatalogItem specified by the Id. |  -  |
| **404** | Not found. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getdatasourcedependentitems"></a>
# **GetDataSourceDependentItems**
> ODataDependentItems GetDataSourceDependentItems (string id)

Returns a list of CatalogItems that reference the DataSource specified by the Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetDataSourceDependentItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new DataSourcesApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Returns a list of CatalogItems that reference the DataSource specified by the Id.
                ODataDependentItems result = apiInstance.GetDataSourceDependentItems(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourcesApi.GetDataSourceDependentItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataSourceDependentItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns a list of CatalogItems that reference the DataSource specified by the Id.
    ApiResponse<ODataDependentItems> response = apiInstance.GetDataSourceDependentItemsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourcesApi.GetDataSourceDependentItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. |  |

### Return type

[**ODataDependentItems**](ODataDependentItems.md)

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

<a name="getdatasourcepolicies"></a>
# **GetDataSourcePolicies**
> List&lt;ItemPolicy&gt; GetDataSourcePolicies (string id)

Gets ItemPolicies associated with the DataSource specified by the Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetDataSourcePoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new DataSourcesApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets ItemPolicies associated with the DataSource specified by the Id.
                List<ItemPolicy> result = apiInstance.GetDataSourcePolicies(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourcesApi.GetDataSourcePolicies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataSourcePoliciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets ItemPolicies associated with the DataSource specified by the Id.
    ApiResponse<List<ItemPolicy>> response = apiInstance.GetDataSourcePoliciesWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourcesApi.GetDataSourcePoliciesWithHttpInfo: " + e.Message);
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
| **200** | Ok. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getdatasourcequeryfields"></a>
# **GetDataSourceQueryFields**
> ODataQueryFields GetDataSourceQueryFields (QueryFieldsRequest queryFieldsRequest = null)

Retrieves a dataset that contains the fields retrieved by the delivery query for a data-driven subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetDataSourceQueryFieldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new DataSourcesApi(config);
            var queryFieldsRequest = new QueryFieldsRequest(); // QueryFieldsRequest |  (optional) 

            try
            {
                // Retrieves a dataset that contains the fields retrieved by the delivery query for a data-driven subscription.
                ODataQueryFields result = apiInstance.GetDataSourceQueryFields(queryFieldsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourcesApi.GetDataSourceQueryFields: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataSourceQueryFieldsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a dataset that contains the fields retrieved by the delivery query for a data-driven subscription.
    ApiResponse<ODataQueryFields> response = apiInstance.GetDataSourceQueryFieldsWithHttpInfo(queryFieldsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourcesApi.GetDataSourceQueryFieldsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queryFieldsRequest** | [**QueryFieldsRequest**](QueryFieldsRequest.md) |  | [optional]  |

### Return type

[**ODataQueryFields**](ODataQueryFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok. |  -  |
| **400** | Couldn&#39;t understand your request. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getdatasources"></a>
# **GetDataSources**
> ODataDataSources GetDataSources (int? top = null, int? skip = null, string filter = null, string count = null, string orderBy = null, string select = null)

Gets an array of DataSource CatalogItems.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetDataSourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new DataSourcesApi(config);
            var top = 56;  // int? | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) (optional) 
            var filter = "filter_example";  // string | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) (optional) 
            var count = "count_example";  // string | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) (optional) 
            var orderBy = "orderBy_example";  // string | Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) (optional) 
            var select = "select_example";  // string | Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) (optional) 

            try
            {
                // Gets an array of DataSource CatalogItems.
                ODataDataSources result = apiInstance.GetDataSources(top, skip, filter, count, orderBy, select);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourcesApi.GetDataSources: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataSourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets an array of DataSource CatalogItems.
    ApiResponse<ODataDataSources> response = apiInstance.GetDataSourcesWithHttpInfo(top, skip, filter, count, orderBy, select);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourcesApi.GetDataSourcesWithHttpInfo: " + e.Message);
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

[**ODataDataSources**](ODataDataSources.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OData array of DataSource CatalogItems |  -  |
| **400** | Couldn&#39;t understand your request. |  -  |
| **404** | Not found. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="getdatasourceproperties"></a>
# **GetDatasourceProperties**
> ODataProperties GetDatasourceProperties (string id, List<string> properties = null)

Gets DataSource Properties (takes list of property names to retrieve the values)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class GetDatasourcePropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new DataSourcesApi(config);
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<string>(); // List<string> | Names for the Properties to be returned. (optional) 

            try
            {
                // Gets DataSource Properties (takes list of property names to retrieve the values)
                ODataProperties result = apiInstance.GetDatasourceProperties(id, properties);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourcesApi.GetDatasourceProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDatasourcePropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets DataSource Properties (takes list of property names to retrieve the values)
    ApiResponse<ODataProperties> response = apiInstance.GetDatasourcePropertiesWithHttpInfo(id, properties);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourcesApi.GetDatasourcePropertiesWithHttpInfo: " + e.Message);
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
| **200** | Ok. |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="setdatasourcepolicies"></a>
# **SetDataSourcePolicies**
> void SetDataSourcePolicies (List<ItemPolicy> itemPolicy, string id)

Replaces ItemPolicies associated with the DataSource specified by the Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class SetDataSourcePoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new DataSourcesApi(config);
            var itemPolicy = new List<ItemPolicy>(); // List<ItemPolicy> | The ItemPolicy definitions that will be replaced.
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Replaces ItemPolicies associated with the DataSource specified by the Id.
                apiInstance.SetDataSourcePolicies(itemPolicy, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourcesApi.SetDataSourcePolicies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetDataSourcePoliciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replaces ItemPolicies associated with the DataSource specified by the Id.
    apiInstance.SetDataSourcePoliciesWithHttpInfo(itemPolicy, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourcesApi.SetDataSourcePoliciesWithHttpInfo: " + e.Message);
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

<a name="updatedatasource"></a>
# **UpdateDataSource**
> void UpdateDataSource (DataSource dataSource, string id)

Updates the DataSource CatalogItem specified by the Id using the provided definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class UpdateDataSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new DataSourcesApi(config);
            var dataSource = new DataSource(); // DataSource | Definition of the DataSource item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Updates the DataSource CatalogItem specified by the Id using the provided definition.
                apiInstance.UpdateDataSource(dataSource, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourcesApi.UpdateDataSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDataSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the DataSource CatalogItem specified by the Id using the provided definition.
    apiInstance.UpdateDataSourceWithHttpInfo(dataSource, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourcesApi.UpdateDataSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dataSource** | [**DataSource**](DataSource.md) | Definition of the DataSource item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged. |  |
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

<a name="updatedatasourceproperties"></a>
# **UpdateDatasourceProperties**
> void UpdateDatasourceProperties (List<Property> properties, string id)

Updates the DataSource Properties included in the given list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace Example
{
    public class UpdateDatasourcePropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/reports/api/v2.0";
            var apiInstance = new DataSourcesApi(config);
            var properties = new List<Property>(); // List<Property> | The Properties that will be updated.
            var id = "id_example";  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Updates the DataSource Properties included in the given list.
                apiInstance.UpdateDatasourceProperties(properties, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourcesApi.UpdateDatasourceProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDatasourcePropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the DataSource Properties included in the given list.
    apiInstance.UpdateDatasourcePropertiesWithHttpInfo(properties, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourcesApi.UpdateDatasourcePropertiesWithHttpInfo: " + e.Message);
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

