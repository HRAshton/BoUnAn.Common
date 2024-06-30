# VideoDownloadedNotification

Notification that a video has been downloaded

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**my_anime_list_id** | **int** |  | 
**dub** | **str** |  | 
**episode** | **int** |  | 
**message_id** | **int** |  | [optional] 

## Example

```python
from bounan_common.models.video_downloaded_notification import VideoDownloadedNotification

# TODO update the JSON string below
json = "{}"
# create an instance of VideoDownloadedNotification from a JSON string
video_downloaded_notification_instance = VideoDownloadedNotification.from_json(json)
# print the JSON string representation of the object
print(VideoDownloadedNotification.to_json())

# convert the object into a dict
video_downloaded_notification_dict = video_downloaded_notification_instance.to_dict()
# create an instance of VideoDownloadedNotification from a dict
video_downloaded_notification_from_dict = VideoDownloadedNotification.from_dict(video_downloaded_notification_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


