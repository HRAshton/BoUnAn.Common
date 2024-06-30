# BotRequest

Request to send from the bot tp AniMan

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**my_anime_list_id** | **int** |  | 
**dub** | **str** |  | 
**episode** | **int** |  | 
**chat_id** | **int** |  | 

## Example

```python
from bounan_common.models.bot_request import BotRequest

# TODO update the JSON string below
json = "{}"
# create an instance of BotRequest from a JSON string
bot_request_instance = BotRequest.from_json(json)
# print the JSON string representation of the object
print(BotRequest.to_json())

# convert the object into a dict
bot_request_dict = bot_request_instance.to_dict()
# create an instance of BotRequest from a dict
bot_request_from_dict = BotRequest.from_dict(bot_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


