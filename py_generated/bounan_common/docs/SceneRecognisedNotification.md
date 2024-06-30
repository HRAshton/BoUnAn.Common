# SceneRecognisedNotification

Notification that video scenes have been recognised (for multiple videos at once)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**items** | [**List[SceneRecognisedNotificationItem]**](SceneRecognisedNotificationItem.md) |  | 

## Example

```python
from bounan_common.models.scene_recognised_notification import SceneRecognisedNotification

# TODO update the JSON string below
json = "{}"
# create an instance of SceneRecognisedNotification from a JSON string
scene_recognised_notification_instance = SceneRecognisedNotification.from_json(json)
# print the JSON string representation of the object
print(SceneRecognisedNotification.to_json())

# convert the object into a dict
scene_recognised_notification_dict = scene_recognised_notification_instance.to_dict()
# create an instance of SceneRecognisedNotification from a dict
scene_recognised_notification_from_dict = SceneRecognisedNotification.from_dict(scene_recognised_notification_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


