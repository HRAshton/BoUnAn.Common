# MatcherResultRequest

Request to send the result of the matching

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**items** | [**List[MatcherResultRequestItem]**](MatcherResultRequestItem.md) |  | 

## Example

```python
from bounan_common.models.matcher_result_request import MatcherResultRequest

# TODO update the JSON string below
json = "{}"
# create an instance of MatcherResultRequest from a JSON string
matcher_result_request_instance = MatcherResultRequest.from_json(json)
# print the JSON string representation of the object
print(MatcherResultRequest.to_json())

# convert the object into a dict
matcher_result_request_dict = matcher_result_request_instance.to_dict()
# create an instance of MatcherResultRequest from a dict
matcher_result_request_from_dict = MatcherResultRequest.from_dict(matcher_result_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


