# Created with Openapi Generator

<a name="cli"></a>
## Run the following powershell command to generate the library

```ps1
$properties = @(
    'apiName=SSRSRestV2Client',
    'targetFramework=netstandard2.1',
    'validatable=true',
    'nullableReferenceTypes=false',
    'hideGenerationTimestamp=true',
    'packageVersion=1.0.0',
    'packageAuthors=Thinh',
    'packageCompany=OpenAPI',
    'packageCopyright=No Copyright',
    'packageDescription=A library generated from a OpenAPI doc for Microsoft SSRS rest api from swagger docs https://app.swaggerhub.com/apis/microsoft-rs/SSRS/2.0',
    'packageName=SSRSRestV2',
    'packageTags=',
    'packageTitle=Rest client for Microsoft SSRS rest api from swagger docs https://app.swaggerhub.com/apis/microsoft-rs/SSRS/2.0'
) -join ","

$global = @(
    'apiDocs=true',
    'modelDocs=true',
    'apiTests=true',
    'modelTests=true'
) -join ","

java -jar "<path>/openapi-generator/modules/openapi-generator-cli/target/openapi-generator-cli.jar" generate `
    -g csharp-netcore `
    -i <your-swagger-file>.yaml `
    -o <your-output-folder> `
    --library generichost `
    --additional-properties $properties `
    --global-property $global `
    --git-host "github.com" `
    --git-repo-id "GIT_REPO_ID" `
    --git-user-id "GIT_USER_ID" `
    --release-note "Minor update"
    # -t templates
```

<a name="usage"></a>
## Using the library in your project

```cs
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SSRSRestV2.Api;
using SSRSRestV2.Client;
using SSRSRestV2.Model;

namespace YourProject
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var api = host.Services.GetRequiredService<ICacheRefreshPlansApi>();
            ApiResponse<CacheRefreshPlan> foo = await api.AddCacheRefreshPlanWithHttpInfoAsync("todo");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
          .ConfigureSSRSRestV2Client((context, options) =>
          {
              options.ConfigureJsonOptions((jsonOptions) =>
              {
                  // your custom converters if any
              });

              options.AddSSRSRestV2ClientHttpClients(builder: builder => builder
                .AddRetryPolicy(2)
                .AddTimeoutPolicy(TimeSpan.FromSeconds(5))
                .AddCircuitBreakerPolicy(10, TimeSpan.FromSeconds(30))
                // add whatever middleware you prefer
              );
          });
    }
}
```
<a name="questions"></a>
## Questions

- What about HttpRequest failures and retries?
  If supportsRetry is enabled, you can configure Polly in the ConfigureClients method.
- How are tokens used?
  Tokens are provided by a TokenProvider class. The default is RateLimitProvider which will perform client side rate limiting.
  Other providers can be used with the UseProvider method.
- Does an HttpRequest throw an error when the server response is not Ok?
  It depends how you made the request. If the return type is ApiResponse<T> no error will be thrown, though the Content property will be null. 
  StatusCode and ReasonPhrase will contain information about the error.
  If the return type is T, then it will throw. If the return type is TOrDefault, it will return null.
- How do I validate requests and process responses?
  Use the provided On and After methods in the Api class from the namespace SSRSRestV2.Rest.DefaultApi.
  Or provide your own class by using the generic ConfigureSSRSRestV2Client method.

<a name="dependencies"></a>
## Dependencies

- [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting/) - 5.0.0 or later
- [Microsoft.Extensions.Http](https://www.nuget.org/packages/Microsoft.Extensions.Http/) - 5.0.0 or later
- [Microsoft.Extensions.Http.Polly](https://www.nuget.org/packages/Microsoft.Extensions.Http.Polly/) - 5.0.1 or later
- [Polly](https://www.nuget.org/packages/Polly/) - 7.2.3 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.7.0 or later

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost/reports/api/v2.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CacheRefreshPlansApi* | [**AddCacheRefreshPlan**](docs\\apisCacheRefreshPlansApi.md#addcacherefreshplan) | **POST** /CacheRefreshPlans | Creates a new CacheRefreshPlan item.
*CacheRefreshPlansApi* | [**DeleteCacheRefreshPlan**](docs\\apisCacheRefreshPlansApi.md#deletecacherefreshplan) | **DELETE** /CacheRefreshPlans({Id}) | Deletes the specified CacheRefreshPlan.
*CacheRefreshPlansApi* | [**ExecuteCacheRefreshPlan**](docs\\apisCacheRefreshPlansApi.md#executecacherefreshplan) | **POST** /CacheRefreshPlans({Id})/Model.Execute | Executes given CacheRefreshPlan immediately.
*CacheRefreshPlansApi* | [**GetCacheRefreshPlan**](docs\\apisCacheRefreshPlansApi.md#getcacherefreshplan) | **GET** /CacheRefreshPlans({Id}) | Gets a CacheRefreshPlan item specified by the Id.
*CacheRefreshPlansApi* | [**SetCacheRefreshPlan**](docs\\apisCacheRefreshPlansApi.md#setcacherefreshplan) | **PUT** /CacheRefreshPlans({Id}) | Replaces the specified CacheRefreshPlan item using the provided definition.
*CatalogItemsApi* | [**AddCatalogItem**](docs\\apisCatalogItemsApi.md#addcatalogitem) | **POST** /CatalogItems | Creates a new CatalogItem.
*CatalogItemsApi* | [**DeleteCatalogItem**](docs\\apisCatalogItemsApi.md#deletecatalogitem) | **DELETE** /CatalogItems({Id}) | Deletes the specified CatalogItem.
*CatalogItemsApi* | [**DeleteCatalogItems**](docs\\apisCatalogItemsApi.md#deletecatalogitems) | **POST** /CatalogItems/Model.DeleteItems | Deletes the given list of items
*CatalogItemsApi* | [**GetCatalogItem**](docs\\apisCatalogItemsApi.md#getcatalogitem) | **GET** /CatalogItems({Id}) | Gets a CatalogItem specified by the Id.
*CatalogItemsApi* | [**GetCatalogItemContent**](docs\\apisCatalogItemsApi.md#getcatalogitemcontent) | **GET** /CatalogItems({Id})/Content/$value | Gets the content of the specified CatalogItem specified by the Id.
*CatalogItemsApi* | [**GetCatalogItemPolicies**](docs\\apisCatalogItemsApi.md#getcatalogitempolicies) | **GET** /CatalogItems({Id})/Policies | Gets ItemPolicies associated with the specified CatalogItem.
*CatalogItemsApi* | [**GetCatalogItemProperties**](docs\\apisCatalogItemsApi.md#getcatalogitemproperties) | **GET** /CatalogItems({Id})/Properties | Gets the specified Properties for the CatalogItem (takes list of Property names to retrieve the values)
*CatalogItemsApi* | [**GetCatalogItemRoles**](docs\\apisCatalogItemsApi.md#getcatalogitemroles) | **GET** /CatalogItems({Id})/Roles | Gets the list of available Roles for the CatalogItem
*CatalogItemsApi* | [**GetCatalogItems**](docs\\apisCatalogItemsApi.md#getcatalogitems) | **GET** /CatalogItems | Gets an array of CatalogItems.
*CatalogItemsApi* | [**MoveCatalogItems**](docs\\apisCatalogItemsApi.md#movecatalogitems) | **POST** /CatalogItems/Model.MoveItems | Moves given list of items to target folder.
*CatalogItemsApi* | [**SetCatalogItemPolicies**](docs\\apisCatalogItemsApi.md#setcatalogitempolicies) | **PUT** /CatalogItems({Id})/Policies | Replaces ItemPolicies associated with the specified CatalogItem.
*CatalogItemsApi* | [**UpdateCatalogItem**](docs\\apisCatalogItemsApi.md#updatecatalogitem) | **PATCH** /CatalogItems({Id}) | Updates the specified CatalogItem using the provided definition.
*CatalogItemsApi* | [**UpdateCatalogItemProperties**](docs\\apisCatalogItemsApi.md#updatecatalogitemproperties) | **PATCH** /CatalogItems({Id})/Properties | Updates a CatalogItem's Properties with the list of given properties.
*DataSetsApi* | [**AddDataSet**](docs\\apisDataSetsApi.md#adddataset) | **POST** /DataSets | Creates a new DataSet CatalogItem.
*DataSetsApi* | [**DeleteDataSet**](docs\\apisDataSetsApi.md#deletedataset) | **DELETE** /DataSets({Id}) | Deletes the specified DataSet.
*DataSetsApi* | [**GetDataSet**](docs\\apisDataSetsApi.md#getdataset) | **GET** /DataSets({Id}) | Gets a DataSet CatalogItem specified by the Id.
*DataSetsApi* | [**GetDataSetAggregatedValue**](docs\\apisDataSetsApi.md#getdatasetaggregatedvalue) | **POST** /DataSets({Id})/Model.GetAggregatedValue | Gets the value for the specified DataSet column using the given aggregation type.
*DataSetsApi* | [**GetDataSetAllowedActions**](docs\\apisDataSetsApi.md#getdatasetallowedactions) | **GET** /DataSets({Id})/AllowedActions | Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
*DataSetsApi* | [**GetDataSetCacheOptions**](docs\\apisDataSetsApi.md#getdatasetcacheoptions) | **GET** /DataSets({Id})/CacheOptions | Gets the CacheOption's content for a given DataSet.
*DataSetsApi* | [**GetDataSetCacheRefreshPlans**](docs\\apisDataSetsApi.md#getdatasetcacherefreshplans) | **GET** /DataSets({Id})/CacheRefreshPlans | Gets the CacheRefreshPlans for a given DataSet.
*DataSetsApi* | [**GetDataSetContent**](docs\\apisDataSetsApi.md#getdatasetcontent) | **GET** /DataSets({Id})/Content/$value | Gets the content of the specified DataSet CatalogItem specified by the Id.
*DataSetsApi* | [**GetDataSetData**](docs\\apisDataSetsApi.md#getdatasetdata) | **POST** /DataSets({Id})/Model.GetData | Gets the query results for the specified DataSet.
*DataSetsApi* | [**GetDataSetDataSource**](docs\\apisDataSetsApi.md#getdatasetdatasource) | **GET** /DataSets({Id})/DataSources({DataSourceId}) | Gets the DataSource specified by the DataSourceId that is associated with the DataSet.
*DataSetsApi* | [**GetDataSetDataSources**](docs\\apisDataSetsApi.md#getdatasetdatasources) | **GET** /DataSets({Id})/DataSources | Gets the DataSources associated with the specified DataSet.
*DataSetsApi* | [**GetDataSetDependentItems**](docs\\apisDataSetsApi.md#getdatasetdependentitems) | **GET** /DataSets({Id})/DependentItems | Returns a list of CatalogItems that reference the specified DataSet.
*DataSetsApi* | [**GetDataSetParameterDefinitions**](docs\\apisDataSetsApi.md#getdatasetparameterdefinitions) | **GET** /DataSets({Id})/ParameterDefinitions | Gets the ParameterDefinitions associated with the specified DataSet.
*DataSetsApi* | [**GetDataSetPolicies**](docs\\apisDataSetsApi.md#getdatasetpolicies) | **GET** /DataSets({Id})/Policies | Gets ItemPolicies associated with the specified DataSet CatalogItem.
*DataSetsApi* | [**GetDataSetSchema**](docs\\apisDataSetsApi.md#getdatasetschema) | **GET** /DataSets({Id})/Model.GetSchema | Gets the schema for the specified DataSet.
*DataSetsApi* | [**GetDataSets**](docs\\apisDataSetsApi.md#getdatasets) | **GET** /DataSets | Gets an array of DataSet CatalogItems.
*DataSetsApi* | [**GetDatasetProperties**](docs\\apisDataSetsApi.md#getdatasetproperties) | **GET** /DataSets({Id})/Properties | Gets DataSet Properties (takes list of property names to retrieve the values)
*DataSetsApi* | [**SetDataSetCacheOptions**](docs\\apisDataSetsApi.md#setdatasetcacheoptions) | **PUT** /DataSets({Id})/CacheOptions | Replaces the CacheOption's content for a given DataSet using the provided definition.
*DataSetsApi* | [**SetDataSetDataSource**](docs\\apisDataSetsApi.md#setdatasetdatasource) | **PUT** /DataSets({Id})/DataSources({DataSourceId}) | Updates the DataSource specified by the DataSourceId that is associated with the DataSet.
*DataSetsApi* | [**SetDataSetDataSources**](docs\\apisDataSetsApi.md#setdatasetdatasources) | **PUT** /DataSets({Id})/DataSources | Updates the DataSource definition associated with the specified DataSet.
*DataSetsApi* | [**SetDataSetPolicies**](docs\\apisDataSetsApi.md#setdatasetpolicies) | **PUT** /DataSets({Id})/Policies | Replaces ItemPolicies associated with the specified DataSet item.
*DataSetsApi* | [**UpdateDataSet**](docs\\apisDataSetsApi.md#updatedataset) | **PATCH** /DataSets({Id}) | Updates the specified DataSet CatalogItem using the provided definition.
*DataSetsApi* | [**UpdateDataSetParameterDefinitions**](docs\\apisDataSetsApi.md#updatedatasetparameterdefinitions) | **PATCH** /DataSets({Id})/ParameterDefinitions | Updates the ParameterDefinitions associated with the DataSet specified.
*DataSetsApi* | [**UpdateDatasetProperties**](docs\\apisDataSetsApi.md#updatedatasetproperties) | **PUT** /DataSets({Id})/Properties | Updates the DataSet Properties included in the given list.
*DataSourcesApi* | [**AddDataSource**](docs\\apisDataSourcesApi.md#adddatasource) | **POST** /DataSources | Creates a new DataSource CatalogItem.
*DataSourcesApi* | [**CheckExistingDataSourceConnection**](docs\\apisDataSourcesApi.md#checkexistingdatasourceconnection) | **POST** /DataSources({Id})/Model.CheckConnection | Tests the connection for a data source. This method supports the testing of published data sources that are used by reports and shared data sources
*DataSourcesApi* | [**CheckNewDataSourceConnection**](docs\\apisDataSourcesApi.md#checknewdatasourceconnection) | **POST** /DataSources/Model.CheckConnection | Tests the connection for a data source. This method supports the direct testing of the unsaved data source.
*DataSourcesApi* | [**DeleteDataSource**](docs\\apisDataSourcesApi.md#deletedatasource) | **DELETE** /DataSources({Id}) | Deletes the specified DataSource.
*DataSourcesApi* | [**GetDataSource**](docs\\apisDataSourcesApi.md#getdatasource) | **GET** /DataSources({Id}) | Gets a DataSource CatalogItem specified by the Id.
*DataSourcesApi* | [**GetDataSourceAllowedActions**](docs\\apisDataSourcesApi.md#getdatasourceallowedactions) | **GET** /DataSources({Id})/AllowedActions | Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
*DataSourcesApi* | [**GetDataSourceContent**](docs\\apisDataSourcesApi.md#getdatasourcecontent) | **GET** /DataSources({Id})/Content/$value | Gets the content of the DataSource CatalogItem specified by the Id.
*DataSourcesApi* | [**GetDataSourceDependentItems**](docs\\apisDataSourcesApi.md#getdatasourcedependentitems) | **GET** /DataSources({Id})/DependentItems | Returns a list of CatalogItems that reference the DataSource specified by the Id.
*DataSourcesApi* | [**GetDataSourcePolicies**](docs\\apisDataSourcesApi.md#getdatasourcepolicies) | **GET** /DataSources({Id})/Policies | Gets ItemPolicies associated with the DataSource specified by the Id.
*DataSourcesApi* | [**GetDataSourceQueryFields**](docs\\apisDataSourcesApi.md#getdatasourcequeryfields) | **POST** /DataSources/Model.GetQueryFields | Retrieves a dataset that contains the fields retrieved by the delivery query for a data-driven subscription.
*DataSourcesApi* | [**GetDataSources**](docs\\apisDataSourcesApi.md#getdatasources) | **GET** /DataSources | Gets an array of DataSource CatalogItems.
*DataSourcesApi* | [**GetDatasourceProperties**](docs\\apisDataSourcesApi.md#getdatasourceproperties) | **GET** /DataSources({Id})/Properties | Gets DataSource Properties (takes list of property names to retrieve the values)
*DataSourcesApi* | [**SetDataSourcePolicies**](docs\\apisDataSourcesApi.md#setdatasourcepolicies) | **PUT** /DataSources({Id})/Policies | Replaces ItemPolicies associated with the DataSource specified by the Id.
*DataSourcesApi* | [**UpdateDataSource**](docs\\apisDataSourcesApi.md#updatedatasource) | **PATCH** /DataSources({Id}) | Updates the DataSource CatalogItem specified by the Id using the provided definition.
*DataSourcesApi* | [**UpdateDatasourceProperties**](docs\\apisDataSourcesApi.md#updatedatasourceproperties) | **PUT** /DataSources({Id})/Properties | Updates the DataSource Properties included in the given list.
*ExtensionsApi* | [**GetExtensionParameters**](docs\\apisExtensionsApi.md#getextensionparameters) | **GET** /Extensions({Id})/Parameters | Retrieves the ExtensionParameter list for given extension.
*ExtensionsApi* | [**GetExtensions**](docs\\apisExtensionsApi.md#getextensions) | **GET** /Extensions | Retreives all Extension items.
*ExtensionsApi* | [**ValidateExtensionParameters**](docs\\apisExtensionsApi.md#validateextensionparameters) | **POST** /Extensions/Model.ValidateExtensionSettings | Validates extension parameters and returns collection of ExtensionParameter.
*FavoriteItemsApi* | [**GetFavoriteItems**](docs\\apisFavoriteItemsApi.md#getfavoriteitems) | **GET** /FavoriteItems | Retrieves a collection of items of type CatalogItem which have been designated as favorites. Use the OData $expand option to also get the referenced items.
*FavoriteItemsApi* | [**RemoveFavoriteItem**](docs\\apisFavoriteItemsApi.md#removefavoriteitem) | **DELETE** /FavoriteItems({Id}) | Removes a CatalogItem from the list of favorite items.
*FavoriteItemsApi* | [**SetFavoriteItem**](docs\\apisFavoriteItemsApi.md#setfavoriteitem) | **POST** /FavoriteItems | Designate a CatalogItem as a favorite.
*FoldersApi* | [**AddFolder**](docs\\apisFoldersApi.md#addfolder) | **POST** /Folders | Creates a new Folder CatalogItem.
*FoldersApi* | [**DeleteFolder**](docs\\apisFoldersApi.md#deletefolder) | **DELETE** /Folders({Id}) | Deletes the specified Folder.
*FoldersApi* | [**GetFolder**](docs\\apisFoldersApi.md#getfolder) | **GET** /Folders({Id}) | Gets a Folder CatalogItem specified by the Id.
*FoldersApi* | [**GetFolderAllowedActions**](docs\\apisFoldersApi.md#getfolderallowedactions) | **GET** /Folders({Id})/AllowedActions | Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
*FoldersApi* | [**GetFolderCatalogItems**](docs\\apisFoldersApi.md#getfoldercatalogitems) | **GET** /Folders({Id})/CatalogItems | Gets a list of child CatalogItems in the specified folder.
*FoldersApi* | [**GetFolderPolicies**](docs\\apisFoldersApi.md#getfolderpolicies) | **GET** /Folders({Id})/Policies | Gets policies associated with the Folder CatalogItem specified by the Id.
*FoldersApi* | [**GetFolderProperties**](docs\\apisFoldersApi.md#getfolderproperties) | **GET** /Folders({Id})/Properties | Gets Folder Properties (takes list of Property names to retrieve the values)
*FoldersApi* | [**GetFolders**](docs\\apisFoldersApi.md#getfolders) | **GET** /Folders | Gets an array of Folder CatalogItems.
*FoldersApi* | [**SearchCatalogItemsInFolder**](docs\\apisFoldersApi.md#searchcatalogitemsinfolder) | **POST** /Folders({Id})/Model.SearchItems(searchText&#x3D;&#39;{searchText}&#39;) | Searches items in a given folder.
*FoldersApi* | [**SetFolderPolicies**](docs\\apisFoldersApi.md#setfolderpolicies) | **PUT** /Folders({Id})/Policies | Replaces ItemPolicies associated with the Folder item specified by the Id.
*FoldersApi* | [**UpdateFolder**](docs\\apisFoldersApi.md#updatefolder) | **PATCH** /Folders({Id}) | Updates the specified Folder CatalogItem using the provided definition.
*FoldersApi* | [**UpdateFolderProperties**](docs\\apisFoldersApi.md#updatefolderproperties) | **PUT** /Folders({Id})/Properties | Updates the Folder Properties included in the given list.
*KpisApi* | [**AddKpi**](docs\\apisKpisApi.md#addkpi) | **POST** /Kpis | Creates a new Kpi CatalogItem.
*KpisApi* | [**DeleteKpi**](docs\\apisKpisApi.md#deletekpi) | **DELETE** /Kpis({Id}) | Deletes the specified Kpi.
*KpisApi* | [**GetKpi**](docs\\apisKpisApi.md#getkpi) | **GET** /Kpis({Id}) | Gets a Kpi CatalogItem specified by the Id.
*KpisApi* | [**GetKpiAllowedActions**](docs\\apisKpisApi.md#getkpiallowedactions) | **GET** /Kpis({Id})/AllowedActions | Gets a list of actions allowed in the current session, user permissions and product edition capabilities are considered when querying.
*KpisApi* | [**GetKpiPolicies**](docs\\apisKpisApi.md#getkpipolicies) | **GET** /Kpis({Id})/Policies | Gets ItemPolicies associated with the Kpi CatalogItem specified by the Id.
*KpisApi* | [**GetKpiProperties**](docs\\apisKpisApi.md#getkpiproperties) | **GET** /Kpis({Id})/Properties | Gets Kpi Properties (takes list of Property names to retrieve the values)
*KpisApi* | [**GetKpis**](docs\\apisKpisApi.md#getkpis) | **GET** /Kpis | Gets an array of Kpi CatalogItems.
*KpisApi* | [**SetKpiPolicies**](docs\\apisKpisApi.md#setkpipolicies) | **PUT** /Kpis({Id})/Policies | Replaces ItemPolicies associated with the Kpi specified by the Id.
*KpisApi* | [**UpdateKpi**](docs\\apisKpisApi.md#updatekpi) | **PATCH** /Kpis({Id}) | Updates the specified Kpi CatalogItem using the provided definition.
*KpisApi* | [**UpdateKpiProperties**](docs\\apisKpisApi.md#updatekpiproperties) | **PUT** /Kpis({Id})/Properties | Updates the Kpi Properties included in the given list.
*LinkedReportsApi* | [**AddLinkedReport**](docs\\apisLinkedReportsApi.md#addlinkedreport) | **POST** /LinkedReports | Creates a new LinkedReport CatalogItem.
*LinkedReportsApi* | [**AddLinkedReportComment**](docs\\apisLinkedReportsApi.md#addlinkedreportcomment) | **POST** /LinkedReports({Id})/Comments | Creates a new Comment associated to the specified LinkedReport.
*LinkedReportsApi* | [**AddLinkedReportHistorySnapshot**](docs\\apisLinkedReportsApi.md#addlinkedreporthistorysnapshot) | **POST** /LinkedReports({Id})/HistorySnapshots | Creates new HistorySnapshot
*LinkedReportsApi* | [**DeleteLinkedReport**](docs\\apisLinkedReportsApi.md#deletelinkedreport) | **DELETE** /LinkedReports({Id}) | Deletes the specified LinkedReport.
*LinkedReportsApi* | [**DeleteLinkedReportComment**](docs\\apisLinkedReportsApi.md#deletelinkedreportcomment) | **DELETE** /LinkedReports({Id})/Comments({CommentId}) | Deletes the specified Comment associated to the LinkedReport.
*LinkedReportsApi* | [**DeleteLinkedReportHistorySnapshot**](docs\\apisLinkedReportsApi.md#deletelinkedreporthistorysnapshot) | **DELETE** /LinkedReports({Id})/HistorySnapshots({HistoryId}) | Deletes a HistorySnapshot specified by HistoryId from the LinkedReport specified by Id.
*LinkedReportsApi* | [**GetLinkedReport**](docs\\apisLinkedReportsApi.md#getlinkedreport) | **GET** /LinkedReports({Id}) | Gets a LinkedReport CatalogItem specified by the Id.
*LinkedReportsApi* | [**GetLinkedReportAllowedActions**](docs\\apisLinkedReportsApi.md#getlinkedreportallowedactions) | **GET** /LinkedReports({Id})/AllowedActions | Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
*LinkedReportsApi* | [**GetLinkedReportCacheOptions**](docs\\apisLinkedReportsApi.md#getlinkedreportcacheoptions) | **GET** /LinkedReports({Id})/CacheOptions | Gets the content of CacheOptions for the LinkedReport specified by the Id.
*LinkedReportsApi* | [**GetLinkedReportCacheRefreshPlans**](docs\\apisLinkedReportsApi.md#getlinkedreportcacherefreshplans) | **GET** /LinkedReports({Id})/CacheRefreshPlans | Gets the CacheRefreshPlans for a LinkedReport specified by the Id.
*LinkedReportsApi* | [**GetLinkedReportComments**](docs\\apisLinkedReportsApi.md#getlinkedreportcomments) | **GET** /LinkedReports({Id})/Comments | Gets the Comments for a LinkedReport specified by the Id.
*LinkedReportsApi* | [**GetLinkedReportHistorySnapshot**](docs\\apisLinkedReportsApi.md#getlinkedreporthistorysnapshot) | **GET** /LinkedReports({Id})/HistorySnapshots({HistoryId}) | Gets requested HistorySnapshot item specified by HistoryId of the LinkedReport specified by Id.
*LinkedReportsApi* | [**GetLinkedReportHistorySnapshotOptions**](docs\\apisLinkedReportsApi.md#getlinkedreporthistorysnapshotoptions) | **GET** /LinkedReports({Id})/HistorySnapshotOptions | Gets HistorySnapshotOptions for the specified LinkedReport.
*LinkedReportsApi* | [**GetLinkedReportHistorySnapshots**](docs\\apisLinkedReportsApi.md#getlinkedreporthistorysnapshots) | **GET** /LinkedReports({Id})/HistorySnapshots | Get a list of HistorySnapshots of the LinkedReport specified by Id.
*LinkedReportsApi* | [**GetLinkedReportParameterDefinitions**](docs\\apisLinkedReportsApi.md#getlinkedreportparameterdefinitions) | **GET** /LinkedReports({Id})/ParameterDefinitions | Gets the ParameterDefinitions associated with the LinkedReport specified by the Id.
*LinkedReportsApi* | [**GetLinkedReportPolicies**](docs\\apisLinkedReportsApi.md#getlinkedreportpolicies) | **GET** /LinkedReports({Id})/Policies | Gets ItemPolicies associated with the specified LinkedReport CatalogItem.
*LinkedReportsApi* | [**GetLinkedReportProperties**](docs\\apisLinkedReportsApi.md#getlinkedreportproperties) | **GET** /LinkedReports({Id})/Properties | Gets LinkedReport Properties (takes list of Property names to retrieve the values)
*LinkedReportsApi* | [**GetLinkedReports**](docs\\apisLinkedReportsApi.md#getlinkedreports) | **GET** /LinkedReports | Gets an array of LinkedReport CatalogItems.
*LinkedReportsApi* | [**SetLinkedReportCacheOptions**](docs\\apisLinkedReportsApi.md#setlinkedreportcacheoptions) | **PUT** /LinkedReports({Id})/CacheOptions | Replaces the CacheOption's content for a given LinkedReport using the provided definition.
*LinkedReportsApi* | [**SetLinkedReportHistorySnapshotOptions**](docs\\apisLinkedReportsApi.md#setlinkedreporthistorysnapshotoptions) | **PUT** /LinkedReports({Id})/HistorySnapshotOptions | Updates HistorySnapshotOptions property.
*LinkedReportsApi* | [**SetLinkedReportPolicies**](docs\\apisLinkedReportsApi.md#setlinkedreportpolicies) | **PUT** /LinkedReports({Id})/Policies | Replaces ItemPolicies associated with the specified LinkedReport item.
*LinkedReportsApi* | [**UpdateLinkedReport**](docs\\apisLinkedReportsApi.md#updatelinkedreport) | **PATCH** /LinkedReports({Id}) | Updates the specified LinkedReport CatalogItem using the provided definition.
*LinkedReportsApi* | [**UpdateLinkedReportComment**](docs\\apisLinkedReportsApi.md#updatelinkedreportcomment) | **PUT** /LinkedReports({Id})/Comments({CommentId}) | Updates the Comment specified by CommentId in the associated LinkedReport.
*LinkedReportsApi* | [**UpdateLinkedReportParameterDefinitions**](docs\\apisLinkedReportsApi.md#updatelinkedreportparameterdefinitions) | **PATCH** /LinkedReports({Id})/ParameterDefinitions | Updates the ParameterDefinitions associated with the specified LinkedReport by the Id.
*LinkedReportsApi* | [**UpdateLinkedReportProperties**](docs\\apisLinkedReportsApi.md#updatelinkedreportproperties) | **PUT** /LinkedReports({Id})/Properties | Updates the LinkedReport Properties included in the given list.
*MeApi* | [**GetUserDetails**](docs\\apisMeApi.md#getuserdetails) | **GET** /Me | Gets the User object for the current user.
*MobileReportsApi* | [**AddMobileReport**](docs\\apisMobileReportsApi.md#addmobilereport) | **POST** /MobileReports | Creates new MobileReport item
*MobileReportsApi* | [**AddMobileReportComment**](docs\\apisMobileReportsApi.md#addmobilereportcomment) | **POST** /MobileReports({Id})/Comments | Creates a new Comment associated to the specified MobileReport.
*MobileReportsApi* | [**DeleteMobileReport**](docs\\apisMobileReportsApi.md#deletemobilereport) | **DELETE** /MobileReports({Id}) | Delete the specified MobileReport.
*MobileReportsApi* | [**DeleteMobileReportComment**](docs\\apisMobileReportsApi.md#deletemobilereportcomment) | **DELETE** /MobileReports({Id})/Comments({CommentId}) | Deletes the specified Comment associated to the MobileReport.
*MobileReportsApi* | [**GetMobileReport**](docs\\apisMobileReportsApi.md#getmobilereport) | **GET** /MobileReports({Id}) | Fetch MobileReport item by Id or path property.
*MobileReportsApi* | [**GetMobileReportAllowedActions**](docs\\apisMobileReportsApi.md#getmobilereportallowedactions) | **GET** /MobileReports({Id})/AllowedActions | Gets a list of actions allowed in the current session; considering user permissions and product edition capabilities.
*MobileReportsApi* | [**GetMobileReportComments**](docs\\apisMobileReportsApi.md#getmobilereportcomments) | **GET** /MobileReports({Id})/Comments | Gets the Comments for a MobileReport specified by the Id.
*MobileReportsApi* | [**GetMobileReportContent**](docs\\apisMobileReportsApi.md#getmobilereportcontent) | **GET** /MobileReports({Id})/Content/$value | Gets the content of the specified MobileReport CatalogItem.
*MobileReportsApi* | [**GetMobileReportPolicies**](docs\\apisMobileReportsApi.md#getmobilereportpolicies) | **GET** /MobileReports({Id})/Policies | Gets ItemPolicies associated with the MobileReport catalog item.
*MobileReportsApi* | [**GetMobileReportProperties**](docs\\apisMobileReportsApi.md#getmobilereportproperties) | **GET** /MobileReports({Id})/Properties | Gets MobileReport Properties (takes list of Property names to retrieve the values)
*MobileReportsApi* | [**GetMobileReports**](docs\\apisMobileReportsApi.md#getmobilereports) | **GET** /MobileReports | Retrieve array of MobileReport catalog items.
*MobileReportsApi* | [**SetMobileReportPolicies**](docs\\apisMobileReportsApi.md#setmobilereportpolicies) | **PUT** /MobileReports({Id})/Policies | Sets ItemPolicies on the MobileReport item.
*MobileReportsApi* | [**UpdateMobileReport**](docs\\apisMobileReportsApi.md#updatemobilereport) | **PATCH** /MobileReports({Id}) | Updates the specified MobileReport CatalogItem using the provided definition.
*MobileReportsApi* | [**UpdateMobileReportComment**](docs\\apisMobileReportsApi.md#updatemobilereportcomment) | **PUT** /MobileReports({Id})/Comments({CommentId}) | Updates the Comment specified by CommentId in the associated MobileReport.
*MobileReportsApi* | [**UpdateMobileReportProperties**](docs\\apisMobileReportsApi.md#updatemobilereportproperties) | **PUT** /MobileReports({Id})/Properties | Updates the MobileReport properties included in the given list.
*ReportsApi* | [**AddReport**](docs\\apisReportsApi.md#addreport) | **POST** /Reports | Creates a new Report CatalogItem.
*ReportsApi* | [**AddReportComment**](docs\\apisReportsApi.md#addreportcomment) | **POST** /Reports({Id})/Comments | Creates a new Comment associated to the specified Report.
*ReportsApi* | [**AddReportHistorySnapshot**](docs\\apisReportsApi.md#addreporthistorysnapshot) | **POST** /Reports({Id})/HistorySnapshots | Creates new HistorySnapshot
*ReportsApi* | [**CheckReportDataSourceConnection**](docs\\apisReportsApi.md#checkreportdatasourceconnection) | **POST** /Reports({Id})/Model.CheckDataSourceConnection | Checks the status of the specified Reports DataSource connection.
*ReportsApi* | [**DeleteReport**](docs\\apisReportsApi.md#deletereport) | **DELETE** /Reports({Id}) | Deletes the specified Report.
*ReportsApi* | [**DeleteReportComment**](docs\\apisReportsApi.md#deletereportcomment) | **DELETE** /Reports({Id})/Comments({CommentId}) | Deletes the specified Comment associated to the Report.
*ReportsApi* | [**DeleteReportHistorySnapshot**](docs\\apisReportsApi.md#deletereporthistorysnapshot) | **DELETE** /Reports({Id})/HistorySnapshots({HistoryId}) | Deletes the requested Reports HistorySnapshot specified by HistoryId.
*ReportsApi* | [**GetReport**](docs\\apisReportsApi.md#getreport) | **GET** /Reports({Id}) | Gets a Report CatalogItem specified by the Id.
*ReportsApi* | [**GetReportAllowedActions**](docs\\apisReportsApi.md#getreportallowedactions) | **GET** /Reports({Id})/AllowedActions | Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
*ReportsApi* | [**GetReportCacheOptions**](docs\\apisReportsApi.md#getreportcacheoptions) | **GET** /Reports({Id})/CacheOptions | Gets the content of CacheOptions for the Report specified by the Id
*ReportsApi* | [**GetReportCacheRefreshPlans**](docs\\apisReportsApi.md#getreportcacherefreshplans) | **GET** /Reports({Id})/CacheRefreshPlans | Gets the CacheRefreshPlans for the Report specified by the Id
*ReportsApi* | [**GetReportComments**](docs\\apisReportsApi.md#getreportcomments) | **GET** /Reports({Id})/Comments | Gets the Comments for a Report specified by the Id.
*ReportsApi* | [**GetReportContent**](docs\\apisReportsApi.md#getreportcontent) | **GET** /Reports({Id})/Content/$value | Gets the content of the specified Report CatalogItem specified by the Id.
*ReportsApi* | [**GetReportDataSources**](docs\\apisReportsApi.md#getreportdatasources) | **GET** /Reports({Id})/DataSources | Gets the DataSources associated with the Report specified by the Id.
*ReportsApi* | [**GetReportDependentItems**](docs\\apisReportsApi.md#getreportdependentitems) | **GET** /Reports({Id})/DependentItems | Returns a list of CatalogItems that reference the Report specified by the Id.
*ReportsApi* | [**GetReportHistorySnapshot**](docs\\apisReportsApi.md#getreporthistorysnapshot) | **GET** /Reports({Id})/HistorySnapshots({HistoryId}) | Gets the requested Reports HistorySnapshot specified by HistoryId.
*ReportsApi* | [**GetReportHistorySnapshotOptions**](docs\\apisReportsApi.md#getreporthistorysnapshotoptions) | **GET** /Reports({Id})/HistorySnapshotOptions | Gets the HistorySnapshotOptions for the specified Report.
*ReportsApi* | [**GetReportHistorySnapshots**](docs\\apisReportsApi.md#getreporthistorysnapshots) | **GET** /Reports({Id})/HistorySnapshots | Get a list of HistorySnapshots for the specified Report.
*ReportsApi* | [**GetReportParameterDefinitions**](docs\\apisReportsApi.md#getreportparameterdefinitions) | **GET** /Reports({Id})/ParameterDefinitions | Gets the ParameterDefinitions associated with the Report specified by the Id.
*ReportsApi* | [**GetReportPolicies**](docs\\apisReportsApi.md#getreportpolicies) | **GET** /Reports({Id})/Policies | Gets policies associated with the specified Report CatalogItem.
*ReportsApi* | [**GetReportProperties**](docs\\apisReportsApi.md#getreportproperties) | **GET** /Reports({Id})/Properties | Gets the specified Reports Properties (takes list of Property names to retrieve the values)
*ReportsApi* | [**GetReportSharedDataSets**](docs\\apisReportsApi.md#getreportshareddatasets) | **GET** /Reports({Id})/SharedDataSets | Gets the shared DataSets for the specified Report.
*ReportsApi* | [**GetReportSubscriptions**](docs\\apisReportsApi.md#getreportsubscriptions) | **GET** /Reports({Id})/Subscriptions | Gets the Subscriptions for the specified Report.
*ReportsApi* | [**GetReports**](docs\\apisReportsApi.md#getreports) | **GET** /Reports | Gets an array of Report CatalogItems.
*ReportsApi* | [**SetReportCacheOptions**](docs\\apisReportsApi.md#setreportcacheoptions) | **PUT** /Reports({Id})/CacheOptions | Replaces the CacheOptions content for a given Report using the provided definition.
*ReportsApi* | [**SetReportDataSource**](docs\\apisReportsApi.md#setreportdatasource) | **PUT** /Reports({Id})/DataSources | Updates the DataSource definition associated with the Report specified by the Id.
*ReportsApi* | [**SetReportHistorySnapshotOptions**](docs\\apisReportsApi.md#setreporthistorysnapshotoptions) | **PUT** /Reports({Id})/HistorySnapshotOptions | Updates HistorySnapshotOptions for the specified Report.
*ReportsApi* | [**SetReportPolicies**](docs\\apisReportsApi.md#setreportpolicies) | **PUT** /Reports({Id})/Policies | Replaces ItemPolicies associated with the Report specified by the Id.
*ReportsApi* | [**SetReportSharedDataSets**](docs\\apisReportsApi.md#setreportshareddatasets) | **PUT** /Reports({Id})/SharedDataSets | Updates the DataSet definitions associated with the specified Report.
*ReportsApi* | [**UpdateCacheSnapshot**](docs\\apisReportsApi.md#updatecachesnapshot) | **POST** /Reports({Id})/Model.UpdateCacheSnapshot | Updates the execution cache snapshot for the specified report.
*ReportsApi* | [**UpdateReport**](docs\\apisReportsApi.md#updatereport) | **PATCH** /Reports({Id}) | Updates the specified Report CatalogItem using the provided definition.
*ReportsApi* | [**UpdateReportComment**](docs\\apisReportsApi.md#updatereportcomment) | **PUT** /Reports({Id})/Comments({CommentId}) | Updates the Comment specified by CommentId in the associated Report.
*ReportsApi* | [**UpdateReportParameterDefinitions**](docs\\apisReportsApi.md#updatereportparameterdefinitions) | **PATCH** /Reports({Id})/ParameterDefinitions | Updates the ParameterDefinitions associated with the Report specified by Id.
*ReportsApi* | [**UpdateReportProperties**](docs\\apisReportsApi.md#updatereportproperties) | **PUT** /Reports({Id})/Properties | Updates the Report Properties included in the given list.
*ResourcesApi* | [**AddResource**](docs\\apisResourcesApi.md#addresource) | **POST** /Resources | Creates new Resource item
*ResourcesApi* | [**DeleteResource**](docs\\apisResourcesApi.md#deleteresource) | **DELETE** /Resources({Id}) | Delete the specified Resource catalog item.
*ResourcesApi* | [**GetResource**](docs\\apisResourcesApi.md#getresource) | **GET** /Resources({Id}) | Get the specified Resource.
*ResourcesApi* | [**GetResourceAllowedActions**](docs\\apisResourcesApi.md#getresourceallowedactions) | **GET** /Resources({Id})/AllowedActions | Gets a list of actions allowed in the current session; considering user permissions and product edition capabilities.
*ResourcesApi* | [**GetResourceContent**](docs\\apisResourcesApi.md#getresourcecontent) | **GET** /Resources({Id})/Content/$value | Gets the content of the specified Resource CatalogItem specified by the Id.
*ResourcesApi* | [**GetResourcePolicies**](docs\\apisResourcesApi.md#getresourcepolicies) | **GET** /Resources({Id})/Policies | Gets ItemPolicies on the Resource item.
*ResourcesApi* | [**GetResourceProperties**](docs\\apisResourcesApi.md#getresourceproperties) | **GET** /Resources({Id})/Properties | Gets the specified Resources Properties (takes list of Property names to retrieve the values)
*ResourcesApi* | [**GetResources**](docs\\apisResourcesApi.md#getresources) | **GET** /Resources | Gets an array of Resource catalog items
*ResourcesApi* | [**SetResourcePolicies**](docs\\apisResourcesApi.md#setresourcepolicies) | **PUT** /Resources({Id})/Policies | Replaces ItemPolicies on the Resource item.
*ResourcesApi* | [**UpdateResource**](docs\\apisResourcesApi.md#updateresource) | **PATCH** /Resources({Id}) | Updates the specified Resource catalog item.
*ResourcesApi* | [**UpdateResourceProperties**](docs\\apisResourcesApi.md#updateresourceproperties) | **PUT** /Resources({Id})/Properties | Updates the Resource Properties included in the given list.
*SessionApi* | [**CreateSession**](docs\\apisSessionApi.md#createsession) | **POST** /Session | Creates a new session
*SessionApi* | [**DeleteSession**](docs\\apisSessionApi.md#deletesession) | **DELETE** /Session | Deletes the currently active session
*SubscriptionsApi* | [**AddSubscription**](docs\\apisSubscriptionsApi.md#addsubscription) | **POST** /Subscriptions | Creates new Subscription item
*SubscriptionsApi* | [**DeleteSubscription**](docs\\apisSubscriptionsApi.md#deletesubscription) | **DELETE** /Subscriptions({Id}) | Deletes the specified Subscription.
*SubscriptionsApi* | [**DisableSubscription**](docs\\apisSubscriptionsApi.md#disablesubscription) | **POST** /Subscriptions({Id})/Model.Disable | Disables the Subscription specified by the Id.
*SubscriptionsApi* | [**EnableSubscription**](docs\\apisSubscriptionsApi.md#enablesubscription) | **POST** /Subscriptions({Id})/Model.Enable | Enables a Subscription specified by the Id.
*SubscriptionsApi* | [**ExecuteSubscription**](docs\\apisSubscriptionsApi.md#executesubscription) | **POST** /Subscriptions({Id})/Model.Execute | Executes the Subscription specified by the Id.
*SubscriptionsApi* | [**GetSubscription**](docs\\apisSubscriptionsApi.md#getsubscription) | **GET** /Subscriptions({Id}) | Get the specified Subscription.
*SubscriptionsApi* | [**GetSubscriptions**](docs\\apisSubscriptionsApi.md#getsubscriptions) | **GET** /Subscriptions | Gets an array of Subscriptions.
*SubscriptionsApi* | [**SetSubscription**](docs\\apisSubscriptionsApi.md#setsubscription) | **PUT** /Subscriptions({Id}) | Replaces the Subscription item using Id property as key.
*SubscriptionsApi* | [**UpdateSubscription**](docs\\apisSubscriptionsApi.md#updatesubscription) | **PATCH** /Subscriptions({Id}) | Updates the Subscription item using Id property as key.
*SystemApi* | [**GetSystemAllowedActions**](docs\\apisSystemApi.md#getsystemallowedactions) | **GET** /System/AllowedActions | Gets a list of system level actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
*SystemApi* | [**GetSystemInfo**](docs\\apisSystemApi.md#getsysteminfo) | **GET** /System | Get SystemInformation
*SystemApi* | [**GetSystemPolicies**](docs\\apisSystemApi.md#getsystempolicies) | **GET** /System/Policies | Gets the System Policies.
*SystemApi* | [**GetSystemProperties**](docs\\apisSystemApi.md#getsystemproperties) | **GET** /System/Properties | Gets the Systems Properties (takes list of Property names to retrieve the values)
*SystemApi* | [**SetSystemPolicies**](docs\\apisSystemApi.md#setsystempolicies) | **PUT** /System/Policies | Updates the System's Policies.
*SystemApi* | [**UpdateSystemProperties**](docs\\apisSystemApi.md#updatesystemproperties) | **PATCH** /System/Properties | Updates the System Properties with the given property list.

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AllowedAction](docs\\modelsAllowedAction.md) - [Model.BulkOperationsResult](docs\\modelsBulkOperationsResult.md) - [Model.CacheOptions](docs\\modelsCacheOptions.md) - [Model.CacheRefreshPlan](docs\\modelsCacheRefreshPlan.md) - [Model.CatalogItem](docs\\modelsCatalogItem.md) - [Model.CatalogItemType](docs\\modelsCatalogItemType.md) - [Model.Comment](docs\\modelsComment.md) - [Model.CredentialsStoredInServer](docs\\modelsCredentialsStoredInServer.md) - [Model.CredentialsSuppliedByUser](docs\\modelsCredentialsSuppliedByUser.md) - [Model.DailyRecurrence](docs\\modelsDailyRecurrence.md) - [Model.DataSet](docs\\modelsDataSet.md) - [Model.DataSet1](docs\\modelsDataSet1.md) - [Model.DataSetAggregateValueParameters](docs\\modelsDataSetAggregateValueParameters.md) - [Model.DataSetColumns](docs\\modelsDataSetColumns.md) - [Model.DataSetData](docs\\modelsDataSetData.md) - [Model.DataSetDataParameters](docs\\modelsDataSetDataParameters.md) - [Model.DataSetField](docs\\modelsDataSetField.md) - [Model.DataSetItem](docs\\modelsDataSetItem.md) - [Model.DataSetParameter](docs\\modelsDataSetParameter.md) - [Model.DataSetParameterInfo](docs\\modelsDataSetParameterInfo.md) - [Model.DataSetSchema](docs\\modelsDataSetSchema.md) - [Model.DataSource](docs\\modelsDataSource.md) - [Model.DataSource1](docs\\modelsDataSource1.md) - [Model.DataSourceCheckResult](docs\\modelsDataSourceCheckResult.md) - [Model.DaysOfWeekSelector](docs\\modelsDaysOfWeekSelector.md) - [Model.DeleteItemsRequest](docs\\modelsDeleteItemsRequest.md) - [Model.DrillthroughTarget](docs\\modelsDrillthroughTarget.md) - [Model.DrillthroughTargetType](docs\\modelsDrillthroughTargetType.md) - [Model.ExpirationReference](docs\\modelsExpirationReference.md) - [Model.Extension](docs\\modelsExtension.md) - [Model.ExtensionParameter](docs\\modelsExtensionParameter.md) - [Model.ExtensionSettings](docs\\modelsExtensionSettings.md) - [Model.ExtensionType](docs\\modelsExtensionType.md) - [Model.FavoriteItem](docs\\modelsFavoriteItem.md) - [Model.Folder](docs\\modelsFolder.md) - [Model.HistorySnapshot](docs\\modelsHistorySnapshot.md) - [Model.HistorySnapshotOptions](docs\\modelsHistorySnapshotOptions.md) - [Model.ItemExecutionType](docs\\modelsItemExecutionType.md) - [Model.ItemPolicy](docs\\modelsItemPolicy.md) - [Model.Kpi](docs\\modelsKpi.md) - [Model.Kpi1](docs\\modelsKpi1.md) - [Model.KpiData](docs\\modelsKpiData.md) - [Model.KpiDataItem](docs\\modelsKpiDataItem.md) - [Model.KpiDataItemType](docs\\modelsKpiDataItemType.md) - [Model.KpiSharedDataItemAggregation](docs\\modelsKpiSharedDataItemAggregation.md) - [Model.KpiValueFormat](docs\\modelsKpiValueFormat.md) - [Model.KpiValues](docs\\modelsKpiValues.md) - [Model.KpiVisualization](docs\\modelsKpiVisualization.md) - [Model.LinkedReport](docs\\modelsLinkedReport.md) - [Model.LinkedReport1](docs\\modelsLinkedReport1.md) - [Model.ManifestItem](docs\\modelsManifestItem.md) - [Model.MinuteRecurrence](docs\\modelsMinuteRecurrence.md) - [Model.MobileReport](docs\\modelsMobileReport.md) - [Model.MobileReport1](docs\\modelsMobileReport1.md) - [Model.MobileReportManifest](docs\\modelsMobileReportManifest.md) - [Model.MobileReportResourceGroupType](docs\\modelsMobileReportResourceGroupType.md) - [Model.MobileReportThumbnailType](docs\\modelsMobileReportThumbnailType.md) - [Model.MonthlyDOWRecurrence](docs\\modelsMonthlyDOWRecurrence.md) - [Model.MonthlyRecurrence](docs\\modelsMonthlyRecurrence.md) - [Model.MonthsOfYearSelector](docs\\modelsMonthsOfYearSelector.md) - [Model.MoveItemsRequest](docs\\modelsMoveItemsRequest.md) - [Model.ODataAllowedActions](docs\\modelsODataAllowedActions.md) - [Model.ODataCacheRefreshPlans](docs\\modelsODataCacheRefreshPlans.md) - [Model.ODataCatalogItems](docs\\modelsODataCatalogItems.md) - [Model.ODataCatalogItems1](docs\\modelsODataCatalogItems1.md) - [Model.ODataComments](docs\\modelsODataComments.md) - [Model.ODataDataSets](docs\\modelsODataDataSets.md) - [Model.ODataDataSources](docs\\modelsODataDataSources.md) - [Model.ODataDependentItems](docs\\modelsODataDependentItems.md) - [Model.ODataFolders](docs\\modelsODataFolders.md) - [Model.ODataKpis](docs\\modelsODataKpis.md) - [Model.ODataLinkedReports](docs\\modelsODataLinkedReports.md) - [Model.ODataMobileReport](docs\\modelsODataMobileReport.md) - [Model.ODataProperties](docs\\modelsODataProperties.md) - [Model.ODataProperties1](docs\\modelsODataProperties1.md) - [Model.ODataProperties2](docs\\modelsODataProperties2.md) - [Model.ODataQueryFields](docs\\modelsODataQueryFields.md) - [Model.ODataReportParameterDefinitions](docs\\modelsODataReportParameterDefinitions.md) - [Model.ODataReports](docs\\modelsODataReports.md) - [Model.ODataResources](docs\\modelsODataResources.md) - [Model.OdataError](docs\\modelsOdataError.md) - [Model.OdataErrorDetail](docs\\modelsOdataErrorDetail.md) - [Model.OdataErrorMain](docs\\modelsOdataErrorMain.md) - [Model.ParameterValue](docs\\modelsParameterValue.md) - [Model.Policy](docs\\modelsPolicy.md) - [Model.Property](docs\\modelsProperty.md) - [Model.Query](docs\\modelsQuery.md) - [Model.QueryFieldsRequest](docs\\modelsQueryFieldsRequest.md) - [Model.Report](docs\\modelsReport.md) - [Model.Report1](docs\\modelsReport1.md) - [Model.ReportHistorySnapshotsOptions](docs\\modelsReportHistorySnapshotsOptions.md) - [Model.ReportHistorySnapshotsOptionsSchedule](docs\\modelsReportHistorySnapshotsOptionsSchedule.md) - [Model.ReportParameterDefinition](docs\\modelsReportParameterDefinition.md) - [Model.ReportParameterDefinitionPatch](docs\\modelsReportParameterDefinitionPatch.md) - [Model.ReportParameterState](docs\\modelsReportParameterState.md) - [Model.ReportParameterType](docs\\modelsReportParameterType.md) - [Model.ReportParameterVisibility](docs\\modelsReportParameterVisibility.md) - [Model.Resource](docs\\modelsResource.md) - [Model.ResourceGroup](docs\\modelsResourceGroup.md) - [Model.ResourceItem](docs\\modelsResourceItem.md) - [Model.ResourceItemAllOf](docs\\modelsResourceItemAllOf.md) - [Model.Role](docs\\modelsRole.md) - [Model.ScheduleDefinition](docs\\modelsScheduleDefinition.md) - [Model.ScheduleRecurrence](docs\\modelsScheduleRecurrence.md) - [Model.ScheduleReference](docs\\modelsScheduleReference.md) - [Model.Subscription](docs\\modelsSubscription.md) - [Model.SystemInfo](docs\\modelsSystemInfo.md) - [Model.SystemPolicy](docs\\modelsSystemPolicy.md) - [Model.ThumbnailItem](docs\\modelsThumbnailItem.md) - [Model.ThumbnailItemAllOf](docs\\modelsThumbnailItemAllOf.md) - [Model.UpdateCacheSnapshotResult](docs\\modelsUpdateCacheSnapshotResult.md) - [Model.User](docs\\modelsUser.md) - [Model.UserCredentials](docs\\modelsUserCredentials.md) - [Model.ValidValue](docs\\modelsValidValue.md) - [Model.WeekNumberEnum](docs\\modelsWeekNumberEnum.md) - [Model.WeeklyRecurrence](docs\\modelsWeeklyRecurrence.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.

## Build
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

## Api Information
- appName: SQL Server 2017 Reporting Services REST API
- appVersion: 2.0
- appDescription: The SQL Server 2017 Reporting Services REST API provides programmatic access to the report server catalog.  For example, basic CRUD operations can be done on folders, reports, KPIs, data sources, datasets, refresh plans, subscriptions, etc.     The REST API can also be used to provide more advanced functionality, such as: * Navigate the folder hierarchy * Discover the contents of a folder * Download a report definition * Modify default report parameters * Change or execute a refresh plan * A whole lot more  The REST API is a RESTful successor to the legacy [SOAP API](https://msdn.microsoft.com/library/reportservice2010.reportingservice2010.aspx).  Happy coding!  __API samples:__ https://github.com/Microsoft/Reporting-Services  __Developer documentation:__ https://docs.microsoft.com/sql/reporting-services/reporting-services-developer-documentation  __Team Blog:__ https://blogs.msdn.microsoft.com/sqlrsteamblog  __Support forums:__ https://social.msdn.microsoft.com/Forums/en-US/home?forum&#x3D;sqlreportingservices 

## [OpenApi Global properties](https://openapi-generator.tech/docs/globals)
- generateAliasAsModel: 
- supportingFiles: 
- models: omitted for brevity
- apis: omitted for brevity
- apiDocs: true
- modelDocs: true
- apiTests: true
- modelTests: true
- withXml: 

## [OpenApi Generator Parameters](https://openapi-generator.tech/docs/generators/csharp-netcore)
- allowUnicodeIdentifiers: 
- apiName: SSRSRestV2Client
- caseInsensitiveResponseHeaders: 
- conditionalSerialization: false
- disallowAdditionalPropertiesIfNotPresent: 
- gitHost: github.com
- gitRepoId: GIT_REPO_ID
- gitUserId: GIT_USER_ID
- hideGenerationTimestamp: true
- interfacePrefix: I
- library: generichost
- licenseId: 
- modelPropertyNaming: 
- netCoreProjectFile: false
- nonPublicApi: false
- nullableReferenceTypes: false
- optionalAssemblyInfo: 
- optionalEmitDefaultValues: false
- optionalMethodArgument: true
- optionalProjectFile: 
- packageAuthors: Thinh
- packageCompany: OpenAPI
- packageCopyright: No Copyright
- packageDescription: A library generated from a OpenAPI doc for Microsoft SSRS rest api from swagger docs https://app.swaggerhub.com/apis/microsoft-rs/SSRS/2.0
- packageGuid: {E1BE52AA-00A7-4717-8761-FCEA0235D7AF}
- packageName: SSRSRestV2
- packageTags: 
- packageTitle: Rest client for Microsoft SSRS rest api from swagger docs https://app.swaggerhub.com/apis/microsoft-rs/SSRS/2.0
- packageVersion: 1.0.0
- releaseNote: Minor update
- returnICollection: false
- sortParamsByRequiredFlag: 
- sourceFolder: src
- targetFramework: netstandard2.1
- useCollection: false
- useDateTimeOffset: false
- useOneOfDiscriminatorLookup: false
- validatable: true

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project.
