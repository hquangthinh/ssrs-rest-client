# SSRSRestV2.Model.MobileReportManifest
An object that contains the specification of the contents of a mobile report.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataSets** | [**List&lt;DataSetItem&gt;**](DataSetItem.md) | An array of objects of type DataSetItem that specifies the DataSets referenced in this MobileReport. | [optional] 
**Resources** | [**List&lt;ResourceGroup&gt;**](ResourceGroup.md) | An array of items of type ResourceGroup that specify the resources referenced in this MobileReport. A Resource is a generalized object and its content type is undefined.  A client must be able to understand the content returned in the Resource. | [optional] 
**Thumbnails** | [**List&lt;ThumbnailItem&gt;**](ThumbnailItem.md) | An array of items of type ThumbnailItem that contains the Thumbnails associated with the MobileReport. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

