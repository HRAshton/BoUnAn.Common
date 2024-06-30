# VideoRegisteredNotification

Notification that a video has been registered (for multiple videos at once)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**items** | [**List[VideoRegisteredNotificationItem]**](VideoRegisteredNotificationItem.md) |  | 

## Example

```python
from bounan_common.models.video_registered_notification import VideoRegisteredNotification

# TODO update the JSON string below
json = "{}"
# create an instance of VideoRegisteredNotification from a JSON string
video_registered_notification_instance = VideoRegisteredNotification.from_json(json)
# print the JSON string representation of the object
print(VideoRegisteredNotification.to_json())

# convert the object into a dict
video_registered_notification_dict = video_registered_notification_instance.to_dict()
# create an instance of VideoRegisteredNotification from a dict
video_registered_notification_from_dict = VideoRegisteredNotification.from_dict(video_registered_notification_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


