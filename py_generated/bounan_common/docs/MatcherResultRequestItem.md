# MatcherResultRequestItem


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**my_anime_list_id** | **int** |  | 
**dub** | **str** |  | 
**episode** | **int** |  | 
**scenes** | [**Scenes**](Scenes.md) |  | 

## Example

```python
from bounan_common.models.matcher_result_request_item import MatcherResultRequestItem

# TODO update the JSON string below
json = "{}"
# create an instance of MatcherResultRequestItem from a JSON string
matcher_result_request_item_instance = MatcherResultRequestItem.from_json(json)
# print the JSON string representation of the object
print(MatcherResultRequestItem.to_json())

# convert the object into a dict
matcher_result_request_item_dict = matcher_result_request_item_instance.to_dict()
# create an instance of MatcherResultRequestItem from a dict
matcher_result_request_item_from_dict = MatcherResultRequestItem.from_dict(matcher_result_request_item_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


