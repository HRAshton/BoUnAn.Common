export interface VideoKey {
    myAnimeListId: number;
    dub: string;
    episode: number;
}

export interface Interval {
    start: number;
    end: number;
}

export interface Scenes {
    opening?: Interval;
    ending?: Interval;
    sceneAfterEnding?: Interval;
}

export interface SceneRecognisedNotificationItem {
    videoKey: VideoKey;
    scenes?: Scenes;
}

export interface SceneRecognisedNotification {
    items: SceneRecognisedNotificationItem[];
}

export interface VideoDownloadedNotification {
    videoKey: VideoKey;
    messageId?: number;
    scenes?: Scenes;
    publishingDetails?: PublishingDetails;
}

export interface VideoRegisteredNotificationItem {
    videoKey: VideoKey;
}

export interface VideoRegisteredNotification {
    items: VideoRegisteredNotificationItem[];
}

export interface MatcherResponse {
    videosToMatch: VideoKey[];
}

export interface MatcherResultRequestItem {
    videoKey: VideoKey;
    scenes: Scenes;
    isFailed: boolean;
}

export interface MatcherResultRequest {
    items: MatcherResultRequestItem[];
}

export interface DownloaderResponse {
    videoKey?: VideoKey;
}

export interface DownloaderResultRequest {
    videoKey: VideoKey;
    messageId?: number;
}

export interface BotRequest {
    videoKey: VideoKey;
}

export interface BotResponse {
    status: VideoStatus;
    messageId?: number;
    scenes?: Scenes;
    publishingDetails?: PublishingDetails;
}

export interface PublishingDetails {
    threadId: number;
    messageId: number;
}

export interface PublisherResultRequestItem {
    videoKey: VideoKey;
    publishingDetails: PublishingDetails;
}

export interface PublisherResultRequest {
    items: PublisherResultRequestItem[];
}

export interface RegisterVideosRequestItem {
    videoKey: VideoKey;
}

export interface RegisterVideosRequest {
    items: RegisterVideosRequestItem[];
}

export type VideoStatus = 'Pending' | 'Downloading' | 'Downloaded' | 'Failed' | 'NotAvailable';
