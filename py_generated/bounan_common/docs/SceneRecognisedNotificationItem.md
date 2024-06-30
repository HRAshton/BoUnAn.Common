# SceneRecognisedNotificationItem


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**my_anime_list_id** | **int** |  | 
**dub** | **str** |  | 
**episode** | **int** |  | 
**scenes** | [**Scenes**](Scenes.md) |  | [optional] 

## Example

```python
from bounan_common.models.scene_recognised_notification_item import SceneRecognisedNotificationItem

# TODO update the JSON string below
json = "{}"
# create an instance of SceneRecognisedNotificationItem from a JSON string
scene_recognised_notification_item_instance = SceneRecognisedNotificationItem.from_json(json)
# print the JSON string representation of the object
print(SceneRecognisedNotificationItem.to_json())

# convert the object into a dict
scene_recognised_notification_item_dict = scene_recognised_notification_item_instance.to_dict()
# create an instance of SceneRecognisedNotificationItem from a dict
scene_recognised_notification_item_from_dict = SceneRecognisedNotificationItem.from_dict(scene_recognised_notification_item_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


