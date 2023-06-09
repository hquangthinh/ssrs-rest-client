# SSRSRestV2.Model.CatalogItem
CatalogItem is an abstract type that contains the common properties of all the types of CatalogItems. Hence, it is the base type from which the other CatalogItem types are derived.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | **string** | A string value that contains binary encoding by base64url encoding rules. The value of this property is not processed by the server. In object creation the server receives and stores a value, and in object retrieval the server returns the previously stored value. | [optional] 
**ContentType** | **string** | A string value that contains a SOAP MIME-type that is associated with the CatalogItem. | [optional] 
**CreatedBy** | **string** | A string value that represents the network user name of the user who originally created the CatalogItem. | [optional] 
**CreatedDate** | **DateTime** | A string that contains the date-time of the creation of the CatalogItem. | [optional] 
**Description** | **string** | A string value that contains descriptive text about the CatalogItem. | [optional] 
**Hidden** | **bool** | A boolean value that indicates if the CatalogItem is hidden. If true, the item will generally not appear in listings of CatalogItems within the parent item. | [optional] 
**Id** | **Guid** | A unique UUID value that specifies the identifier by which this CatalogItem can be referenced in requests or by other defined objects. | [optional] 
**IsFavorite** | **bool** | A boolean value that specifies whether the CatalogItem is designated as a Favorite. | [optional] 
**ModifiedBy** | **string** | A string value that contains the network user name of the last user to modify the CatalogItem. | [optional] 
**ModifiedDate** | **DateTime** | A string value that contains the date-time of the last modification to the CatalogItem. | [optional] 
**Name** | **string** | A string value that specifies the name for the CatalogItem. This name is typically displayed in the user interface. | [optional] 
**ParentFolderId** | **Guid** | A unique UUID value that specifies the identifier of the Folder CatalogItem that contains this CatalogItem. | [optional] 
**Path** | **string** | A string value that contains the full server path for the CatalogItem. Path is defined as an alternate key on the CatalogItem and can be used as the parameter by which CatalogItem can be referenced in requests or by other defined objects. | [optional] 
**Size** | **long** | An Int64 value that contains the size of the CatalogItem in bytes. | [optional] 
**Type** | **CatalogItemType** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

