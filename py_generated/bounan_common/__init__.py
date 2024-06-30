# coding: utf-8

# flake8: noqa

"""
    Bounan.Common models

    No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

    The version of the OpenAPI document: 2.0.0
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


__version__ = "1.0.0"

# import apis into sdk package

# import ApiClient
from bounan_common.api_response import ApiResponse
from bounan_common.api_client import ApiClient
from bounan_common.configuration import Configuration
from bounan_common.exceptions import OpenApiException
from bounan_common.exceptions import ApiTypeError
from bounan_common.exceptions import ApiValueError
from bounan_common.exceptions import ApiKeyError
from bounan_common.exceptions import ApiAttributeError
from bounan_common.exceptions import ApiException

# import models into sdk package
from bounan_common.models.bot_request import BotRequest
from bounan_common.models.bot_response import BotResponse
from bounan_common.models.downloader_response import DownloaderResponse
from bounan_common.models.downloader_result_request import DownloaderResultRequest
from bounan_common.models.interval import Interval
from bounan_common.models.matcher_response import MatcherResponse
from bounan_common.models.matcher_result_request import MatcherResultRequest
from bounan_common.models.matcher_result_request_item import MatcherResultRequestItem
from bounan_common.models.scene_recognised_notification import SceneRecognisedNotification
from bounan_common.models.scene_recognised_notification_item import SceneRecognisedNotificationItem
from bounan_common.models.scenes import Scenes
from bounan_common.models.video_downloaded_notification import VideoDownloadedNotification
from bounan_common.models.video_key import VideoKey
from bounan_common.models.video_registered_notification import VideoRegisteredNotification
from bounan_common.models.video_registered_notification_item import VideoRegisteredNotificationItem
from bounan_common.models.video_status import VideoStatus