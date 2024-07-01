from dataclasses import dataclass
from enum import Enum
from typing import List, Optional

from dataclasses_json import dataclass_json, LetterCase


@dataclass_json(letter_case=LetterCase.PASCAL)
@dataclass
class VideoKey:
    my_anime_list_id: int
    dub: str
    episode: int


@dataclass_json(letter_case=LetterCase.PASCAL)
@dataclass
class Interval:
    start: float
    end: float


@dataclass_json(letter_case=LetterCase.PASCAL)
@dataclass
class Scenes:
    opening: Optional[Interval] = None
    ending: Optional[Interval] = None
    scene_after_ending: Optional[Interval] = None


@dataclass_json(letter_case=LetterCase.PASCAL)
@dataclass
class SceneRecognisedNotificationItem:
    video_key: VideoKey
    scenes: Optional[Scenes] = None


@dataclass_json(letter_case=LetterCase.PASCAL)
@dataclass
class SceneRecognisedNotification:
    items: List[SceneRecognisedNotificationItem]


@dataclass_json(letter_case=LetterCase.PASCAL)
@dataclass
class VideoDownloadedNotification:
    video_key: VideoKey
    message_id: Optional[int] = None
    subscriber_chat_ids: Optional[List[int]] = None
    scenes: Optional[Scenes] = None


@dataclass_json(letter_case=LetterCase.PASCAL)
@dataclass
class VideoRegisteredNotificationItem:
    video_key: VideoKey


@dataclass_json(letter_case=LetterCase.PASCAL)
@dataclass
class VideoRegisteredNotification:
    items: List[VideoRegisteredNotificationItem]


@dataclass_json(letter_case=LetterCase.PASCAL)
@dataclass
class MatcherResponse:
    videos_to_match: List[VideoKey]


@dataclass_json(letter_case=LetterCase.PASCAL)
@dataclass
class MatcherResultRequestItem:
    video_key: VideoKey
    scenes: Scenes


@dataclass_json(letter_case=LetterCase.PASCAL)
@dataclass
class MatcherResultRequest:
    items: List[MatcherResultRequestItem]


@dataclass_json(letter_case=LetterCase.PASCAL)
@dataclass
class DownloaderResponse:
    video_key: VideoKey


@dataclass_json(letter_case=LetterCase.PASCAL)
@dataclass
class DownloaderResultRequest:
    video_key: VideoKey
    message_id: Optional[int] = None


@dataclass_json(letter_case=LetterCase.PASCAL)
@dataclass
class BotRequest:
    video_key: VideoKey
    chat_id: int


class VideoStatus(Enum):
    Pending = "Pending"
    Downloading = "Downloading"
    Downloaded = "Downloaded"
    Failed = "Failed"
    NotAvailable = "NotAvailable"


@dataclass_json(letter_case=LetterCase.PASCAL)
@dataclass
class BotResponse:
    status: VideoStatus
    message_id: Optional[int] = None
    scenes: Optional[Scenes] = None
