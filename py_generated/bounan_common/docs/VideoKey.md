# VideoKey

Key to identify a video.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**my_anime_list_id** | **int** |  | 
**dub** | **str** |  | 
**episode** | **int** |  | 

## Example

```python
from bounan_common.models.video_key import VideoKey

# TODO update the JSON string below
json = "{}"
# create an instance of VideoKey from a JSON string
video_key_instance = VideoKey.from_json(json)
# print the JSON string representation of the object
print(VideoKey.to_json())

# convert the object into a dict
video_key_dict = video_key_instance.to_dict()
# create an instance of VideoKey from a dict
video_key_from_dict = VideoKey.from_dict(video_key_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


