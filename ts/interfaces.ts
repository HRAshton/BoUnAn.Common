export interface VideoKey {
    MyAnimeListId: number;
    Dub: string;
    Episode: number;
}

export interface Interval {
    Start: number;
    End: number;
}

export interface Scenes {
    Opening?: Interval;
    Ending?: Interval;
    SceneAfterEnding?: Interval;
}

export interface SceneRecognisedNotificationItem {
    VideoKey: VideoKey;
    Scenes?: Scenes;
}

export interface SceneRecognisedNotification {
    Items: SceneRecognisedNotificationItem[];
}

export interface VideoDownloadedNotification {
    VideoKey: VideoKey;
    MessageId?: number;
    SubscriberChatIds?: number[];
    Scenes?: Scenes;
    PublishingDetails?: PublishingDetails;
}

export interface VideoRegisteredNotificationItem {
    VideoKey: VideoKey;
}

export interface VideoRegisteredNotification {
    Items: VideoRegisteredNotificationItem[];
}

export interface MatcherResponse {
    VideosToMatch: VideoKey[];
}

export interface MatcherResultRequestItem {
    VideoKey: VideoKey;
    Scenes: Scenes;
}

export interface MatcherResultRequest {
    Items: MatcherResultRequestItem[];
}

export interface DownloaderResponse {
    VideoKey?: VideoKey;
}

export interface DownloaderResultRequest {
    VideoKey: VideoKey;
    MessageId?: number;
}

export interface BotRequest {
    VideoKey: VideoKey;
    ChatId: number;
}

export interface BotResponse {
    Status: VideoStatus;
    MessageId?: number;
    Scenes?: Scenes;
    PublishingDetails?: PublishingDetails;
}

export interface PublishingDetails {
    ThreadId: number;
    MessageId: number;
}

export interface PublisherResultRequestItem {
    VideoKey: VideoKey;
    PublishingDetails: PublishingDetails;
}

export interface PublisherResultRequest {
    Items: PublisherResultRequestItem[];
}

export type VideoStatus = 'Pending' | 'Downloading' | 'Downloaded' | 'Failed' | 'NotAvailable';
