using System.Collections.Generic;

#pragma warning disable SA1649
#pragma warning disable SA1402

namespace Bounan.Common;

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

public record VideoDownloadedNotification(VideoKey VideoKey, int? MessageId, List<long>? SubscriberChatIds, Scenes? Scenes);

public record VideoRegisteredNotificationItem(VideoKey VideoKey);

public record VideoRegisteredNotification(List<VideoRegisteredNotificationItem> Items);

public record MatcherResponse(List<VideoKey> VideosToMatch);

public record MatcherResultRequestItem(VideoKey VideoKey, Scenes Scenes);

public record MatcherResultRequest(List<MatcherResultRequestItem> Items);

public record DownloaderResponse(VideoKey VideoKey);

public record DownloaderResultRequest(VideoKey VideoKey, int? MessageId);

public record BotRequest(VideoKey VideoKey, long ChatId);

public record BotResponse(VideoStatus Status, int? MessageId, Scenes? Scenes);

public enum VideoStatus
{
    Unknown,
    Pending,
    Downloading,
    Downloaded,
    Failed,
    NotAvailable,
}