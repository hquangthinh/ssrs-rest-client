# SSRSRestV2.Model.CredentialsStoredInServer
This object holds credentials for connections to an external data source. The object is stored on the Report Server for later retrieval and use. NOTE: This object represents a security risk as its properties can be seen in plain text over the HTTP protocol; HTTPS is recommended.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ImpersonateAuthenticatedUser** | **bool** | A boolean value that indicates whether the session should impersonate the user for the supplied credentials. | [optional] 
**Password** | **string** | A string value that contains the password to be used to connect to an external data source. | [optional] 
**UseAsWindowsCredentials** | **bool** | A boolean value that indicates whether the supplied credentials should be used as Windows credentials. | [optional] 
**UserName** | **string** | A string value that contains the user name to be used to connect to an external data source. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

