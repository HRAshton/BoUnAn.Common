# Scenes

Scenes of a video. If a scene is not present, it means that it is not recognised.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**opening** | [**Interval**](Interval.md) |  | [optional] 
**ending** | [**Interval**](Interval.md) |  | [optional] 
**scene_after_ending** | [**Interval**](Interval.md) |  | [optional] 

## Example

```python
from bounan_common.models.scenes import Scenes

# TODO update the JSON string below
json = "{}"
# create an instance of Scenes from a JSON string
scenes_instance = Scenes.from_json(json)
# print the JSON string representation of the object
print(Scenes.to_json())

# convert the object into a dict
scenes_dict = scenes_instance.to_dict()
# create an instance of Scenes from a dict
scenes_from_dict = Scenes.from_dict(scenes_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


