# VideoRegisteredNotificationItem


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**my_anime_list_id** | **int** |  | 
**dub** | **str** |  | 
**episode** | **int** |  | 

## Example

```python
from bounan_common.models.video_registered_notification_item import VideoRegisteredNotificationItem

# TODO update the JSON string below
json = "{}"
# create an instance of VideoRegisteredNotificationItem from a JSON string
video_registered_notification_item_instance = VideoRegisteredNotificationItem.from_json(json)
# print the JSON string representation of the object
print(VideoRegisteredNotificationItem.to_json())

# convert the object into a dict
video_registered_notification_item_dict = video_registered_notification_item_instance.to_dict()
# create an instance of VideoRegisteredNotificationItem from a dict
video_registered_notification_item_from_dict = VideoRegisteredNotificationItem.from_dict(video_registered_notification_item_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


