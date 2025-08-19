﻿ #pragma warning disable SA1649
#pragma warning disable SA1402

namespace Bounan.Common;

public enum VideoStatus
{
    /// <summary>
    /// Unknown status. This is the default value. Should not be used.
    /// </summary>
    Unknown,

    /// <summary>
    /// Scheduled for download. The video is not yet available.
    /// </summary>
    Pending,

    /// <summary>
    /// The video is being downloaded.
    /// </summary>
    Downloading,

    /// <summary>
    /// The video has been downloaded successfully.
    /// </summary>
    Downloaded,

    /// <summary>
    /// The video has not been downloaded due to an error.
    /// </summary>
    Failed,

    /// <summary>
    /// The video is not available for download. This can happen if the video has been removed or is not accessible.
    /// </summary>
    NotAvailable,
}

public interface IVideoKey
{
    int MyAnimeListId { get; }

    string Dub { get; }

    int Episode { get; }
}

public record VideoKey(int MyAnimeListId, string Dub, int Episode) : IVideoKey;

public record Interval(float Start, float End);

public record Scenes(Interval? Opening, Interval? Ending, Interval? SceneAfterEnding);

public record SceneRecognisedNotificationItem(VideoKey VideoKey, Scenes? Scenes);

public record SceneRecognisedNotification(List<SceneRecognisedNotificationItem> Items);

public record VideoDownloadedNotification(VideoKey VideoKey, int? MessageId, Scenes? Scenes, PublishingDetails? PublishingDetails);

public record VideoRegisteredNotificationItem(VideoKey VideoKey);

public record VideoRegisteredNotification(List<VideoRegisteredNotificationItem> Items);

public record MatcherResponse(List<VideoKey> VideosToMatch);

public record MatcherResultRequestItem(VideoKey VideoKey, Scenes Scenes);

public record MatcherResultRequest(List<MatcherResultRequestItem> Items);

public record DownloaderResponse(VideoKey VideoKey);

public record DownloaderResultRequest(VideoKey VideoKey, int? MessageId);

public record BotRequest(VideoKey VideoKey);

public record BotResponse(VideoStatus Status, int? MessageId, Scenes? Scenes, PublishingDetails? PublishingDetails);

public record PublishingDetails(int ThreadId, int MessageId);

public record PublisherResultRequestItem(VideoKey VideoKey, PublishingDetails PublishingDetails);

public record PublisherResultRequest(List<PublisherResultRequestItem> Items);

public record RegisterVideosRequestItem(VideoKey VideoKey);

public record RegisterVideosRequest(List<RegisterVideosRequestItem> Items);
