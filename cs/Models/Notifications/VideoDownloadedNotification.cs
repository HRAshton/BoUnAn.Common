namespace Bounan.Common.Models.Notifications;

/// <summary>
/// Notification that a video has been downloaded / failed to download.
/// </summary>
public record VideoDownloadedNotification(
    VideoKey VideoKey,
    ICollection<long> ChatIds,
    int? MessageId,
    Scenes? Scenes);