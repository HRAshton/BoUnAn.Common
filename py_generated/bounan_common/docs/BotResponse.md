# BotResponse

Response to send from AniMan to the bot

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**status** | [**VideoStatus**](VideoStatus.md) |  | 
**message_id** | **int** |  | [optional] 
**scenes** | [**Scenes**](Scenes.md) |  | [optional] 

## Example

```python
from bounan_common.models.bot_response import BotResponse

# TODO update the JSON string below
json = "{}"
# create an instance of BotResponse from a JSON string
bot_response_instance = BotResponse.from_json(json)
# print the JSON string representation of the object
print(BotResponse.to_json())

# convert the object into a dict
bot_response_dict = bot_response_instance.to_dict()
# create an instance of BotResponse from a dict
bot_response_from_dict = BotResponse.from_dict(bot_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


