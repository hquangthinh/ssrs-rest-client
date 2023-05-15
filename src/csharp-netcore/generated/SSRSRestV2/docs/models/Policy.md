# SSRSRestV2.Model.Policy
An object that specifies a set of roles that are grouped together as a policy and can then be assigned as a group of policies to an item using the property GroupUserName.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupUserName** | **string** | A string value that specifies the name of the user or group to which the policy applies. | [optional] 
**Roles** | [**List&lt;Role&gt;**](Role.md) | An array of objects of type Role that specify the security roles that are included in the Policy. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

