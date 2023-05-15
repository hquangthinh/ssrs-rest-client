# SSRSRestV2.Model.ExtensionParameter
An object that contains the definition of a Reporting Services extension's parameter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the extension setting that is displayed to the user. | [optional] 
**Encrypted** | **bool** | Indicates whether the extension parameter value should be encrypted in the Report Server database. | [optional] 
**Error** | **string** | An error that describes a problem with the value of the setting. | [optional] 
**IsPassword** | **bool** | A Boolean value that indicates whether the ExtensionParameter is a password. | [optional] 
**Name** | **string** | A string value that specifies the name for the ExtensionParameter. | [optional] 
**ReadOnly** | **bool** | Indicates whether the setting is read-only. | [optional] 
**Required** | **bool** | Indicates whether the value is required. | [optional] 
**ValidValues** | [**List&lt;ValidValue&gt;**](ValidValue.md) | A set of values that can be configured for the setting. | [optional] 
**ValidValuesIsNull** | **bool** | A Boolean value that indicates whether the ValidValues property is null. | [optional] 
**Value** | **string** | A string that represents the value of an extension parameter. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

