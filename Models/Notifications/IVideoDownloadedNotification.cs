namespace Bounan.Common.Models.Notifications;

/// <summary>
/// Notification that a video has been downloaded / failed to download.
/// </summary>
public interface IVideoDownloadedNotification : IVideoKey
{
    /// <summary>
    /// Gets IDs of the chats (users) to send the notification to.
    /// </summary>
    ICollection<long> ChatIds { get; }

    /// <summary>
    /// Gets MyAnimeList ID of the anime.
    /// </summary>
    int? MessageId { get; }
}