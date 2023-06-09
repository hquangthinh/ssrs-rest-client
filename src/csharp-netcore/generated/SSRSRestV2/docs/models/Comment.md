# SSRSRestV2.Model.Comment
An object that specifies a comment that is attached to a CatalogItem.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttachmentPath** | **string** | A string value that specifies the server path to an attachment that is part of the comment. | [optional] 
**CreatedDate** | **DateTime** | A string that contains the date-time of the creation of the comment. | [optional] 
**Id** | **Guid** | A unique UUID value that specifies the identifier of the comment. | [optional] 
**ItemId** | **Guid** | A unique UUID value that specifies the identifier of the CatalogItem item to which the comment is attached. | [optional] 
**ModifiedDate** | **DateTime** | A string value that contains the date-time of the last modification to the comment. | [optional] 
**Text** | **string** | A string value that contains the text of the comment. | [optional] 
**ThreadId** | **Guid** | A unique UUID value that specifies the identifier of the thread of the comment. A comment thread can be used to group comments that are a response to one another in one grouping. | [optional] 
**UserName** | **string** |  A string value that represents the user who created the comment item. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

