# SSRSRestV2.Model.ReportHistorySnapshotsOptions
An object that specifies options for a Report HistorySnapshot.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KeepExecutionSnapshots** | **bool** | A Boolean value that specifies whether execution snapshots are kept. | [optional] 
**ManualCreationEnabled** | **bool** | A boolean value that specifies whether manual snapshot creation is enabled for this HistorySnapshot. | [optional] 
**Schedule** | [**ReportHistorySnapshotsOptionsSchedule**](ReportHistorySnapshotsOptionsSchedule.md) |  | [optional] 
**ScopedLimit** | **int** | An Int32 value indicating how many snapshots to keep. | [optional] 
**SystemLimit** | **int** | An Int32 value indicating how many snapshots can be kept systemwide.  Default (-1) is unlimited. | [optional] 
**UseDefaultSystemLimit** | **bool** | A boolean value that specifies whether the default system limit is used for this HistorySnapshot. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

