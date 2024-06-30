# DownloaderResponse

A video to download

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**video_key** | [**VideoKey**](VideoKey.md) |  | [optional] 

## Example

```python
from bounan_common.models.downloader_response import DownloaderResponse

# TODO update the JSON string below
json = "{}"
# create an instance of DownloaderResponse from a JSON string
downloader_response_instance = DownloaderResponse.from_json(json)
# print the JSON string representation of the object
print(DownloaderResponse.to_json())

# convert the object into a dict
downloader_response_dict = downloader_response_instance.to_dict()
# create an instance of DownloaderResponse from a dict
downloader_response_from_dict = DownloaderResponse.from_dict(downloader_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


