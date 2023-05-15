# SSRSRestV2.Model.DataSource1
An object that defines information about an external source of data that can be connected to as a source of data for Reporting Services. DataSource is derived from CatalogItem and therefore includes all properties defined by CatalogItem.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConnectionString** | **string** | A string value that can be passed to a data source in order to begin the process of establishing connection. | [optional] 
**CredentialsByUser** | [**CredentialsSuppliedByUser**](CredentialsSuppliedByUser.md) |  | [optional] 
**CredentialsInServer** | [**CredentialsStoredInServer**](CredentialsStoredInServer.md) |  | [optional] 
**DataSourceType** | **string** | DataSource extension such as &#39;SQL&#39;. | [optional] 
**IsConnectionStringOverridden** | **bool** | Specifies whether the original connection string is overridden. | [optional] 
**IsEnabled** | **bool** | A Boolean value that specifies whether the DataSource is enabled for use. | [optional] 
**IsOriginalConnectionStringExpressionBased** | **bool** | Indicates whether the original connection string for the data source was expression-based. | [optional] 
**IsReference** | **bool** | Indicates whether this is a reference to a shared data source or an embedded data source. | [optional] 
**Subscriptions** | [**Subscription**](Subscription.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

