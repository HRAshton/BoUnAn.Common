# MatcherResponse

List of a videos to match

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**videos_to_match** | [**List[VideoKey]**](VideoKey.md) |  | 

## Example

```python
from bounan_common.models.matcher_response import MatcherResponse

# TODO update the JSON string below
json = "{}"
# create an instance of MatcherResponse from a JSON string
matcher_response_instance = MatcherResponse.from_json(json)
# print the JSON string representation of the object
print(MatcherResponse.to_json())

# convert the object into a dict
matcher_response_dict = matcher_response_instance.to_dict()
# create an instance of MatcherResponse from a dict
matcher_response_from_dict = MatcherResponse.from_dict(matcher_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


