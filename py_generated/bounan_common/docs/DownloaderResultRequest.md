# DownloaderResultRequest

Request to send the result of the download

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**my_anime_list_id** | **int** |  | 
**dub** | **str** |  | 
**episode** | **int** |  | 
**message_id** | **int** |  | [optional] 

## Example

```python
from bounan_common.models.downloader_result_request import DownloaderResultRequest

# TODO update the JSON string below
json = "{}"
# create an instance of DownloaderResultRequest from a JSON string
downloader_result_request_instance = DownloaderResultRequest.from_json(json)
# print the JSON string representation of the object
print(DownloaderResultRequest.to_json())

# convert the object into a dict
downloader_result_request_dict = downloader_result_request_instance.to_dict()
# create an instance of DownloaderResultRequest from a dict
downloader_result_request_from_dict = DownloaderResultRequest.from_dict(downloader_result_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


