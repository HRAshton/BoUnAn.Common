from dataclasses import dataclass
from enum import Enum
from typing import List, Optional

from dataclasses_json import dataclass_json, LetterCase


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class VideoKey:
    my_anime_list_id: int
    dub: str
    episode: int


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class PublishingDetails:
    thread_id: int
    message_id: int


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class Interval:
    start: float
    end: float


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class Scenes:
    opening: Optional[Interval] = None
    ending: Optional[Interval] = None
    scene_after_ending: Optional[Interval] = None


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class SceneRecognisedNotificationItem:
    video_key: VideoKey
    scenes: Optional[Scenes] = None


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class SceneRecognisedNotification:
    items: List[SceneRecognisedNotificationItem]


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class VideoDownloadedNotification:
    video_key: VideoKey
    message_id: Optional[int] = None
    scenes: Optional[Scenes] = None
    publishing_details: Optional[PublishingDetails] = None


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class VideoRegisteredNotificationItem:
    video_key: VideoKey


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class VideoRegisteredNotification:
    items: List[VideoRegisteredNotificationItem]


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class MatcherResponse:
    videos_to_match: List[VideoKey]


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class MatcherResultRequestItem:
    video_key: VideoKey
    scenes: Scenes
    is_failed: bool


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class MatcherResultRequest:
    items: List[MatcherResultRequestItem]


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class DownloaderResponse:
    video_key: VideoKey


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class DownloaderResultRequest:
    video_key: VideoKey
    message_id: Optional[int] = None


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class BotRequest:
    video_key: VideoKey


class VideoStatus(Enum):
    Pending = "Pending"
    Downloading = "Downloading"
    Downloaded = "Downloaded"
    Failed = "Failed"
    NotAvailable = "NotAvailable"


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class BotResponse:
    status: VideoStatus
    message_id: Optional[int] = None
    scenes: Optional[Scenes] = None
    publishing_details: Optional[PublishingDetails] = None


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class PublisherResultRequestItem:
    video_key: VideoKey
    publishing_details: PublishingDetails


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class PublisherResultRequest:
    items: List[PublisherResultRequestItem]


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class RegisterVideosRequestItem:
    video_key: VideoKey


@dataclass_json(letter_case=LetterCase.CAMEL)
@dataclass
class RegisterVideosRequest:
    items: List[RegisterVideosRequestItem]
