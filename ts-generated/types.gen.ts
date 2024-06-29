// This file is auto-generated by @hey-api/openapi-ts

/**
 * Key to identify a video.
 */
export type VideoKey = {
    MyAnimeListId: number;
    Dub: string;
    Episode: number;
};

/**
 * Interval of time in seconds.
 */
export type Interval = {
    Start: number;
    End: number;
};

/**
 * Scenes of a video. If a scene is not present, it means that it is not recognised.
 */
export type Scenes = {
    Opening?: Interval;
    Ending?: Interval;
    SceneAfterEnding?: Interval;
};

export type SceneRecognisedNotificationItem = VideoKey & {
    Scenes?: Scenes;
};

/**
 * Notification that video scenes have been recognised (for multiple videos at once)
 */
export type SceneRecognisedNotification = {
    Items: Array<SceneRecognisedNotificationItem>;
};

/**
 * Notification that a video has been downloaded
 */
export type VideoDownloadedNotification = VideoKey & {
    MessageId?: number;
};

export type VideoRegisteredNotificationItem = VideoKey;

/**
 * Notification that a video has been registered (for multiple videos at once)
 */
export type VideoRegisteredNotification = {
    Items: Array<VideoRegisteredNotificationItem>;
};

/**
 * List of a videos to match
 */
export type MatcherResponse = {
    VideosToMatch: Array<VideoKey>;
};

export type MatcherResultRequestItem = VideoKey & {
    Scenes: Scenes;
};

/**
 * Request to send the result of the matching
 */
export type MatcherResultRequest = {
    Items: Array<MatcherResultRequestItem>;
};

/**
 * A video to download
 */
export type DownloaderResponse = {
    VideoKey?: VideoKey;
};

/**
 * Request to send the result of the download
 */
export type DownloaderResultRequest = VideoKey & {
    MessageId?: number;
};

/**
 * Request to send from the bot tp AniMan
 */
export type BotRequest = VideoKey & {
    ChatId: number;
};

/**
 * Response to send from AniMan to the bot
 */
export type BotResponse = {
    Status: VideoStatus;
    MessageId?: number;
    Scenes?: Scenes;
};

/**
 * Status of a video
 */
export type VideoStatus = 'Pending' | 'Downloading' | 'Downloaded' | 'Failed' | 'NotAvailable';