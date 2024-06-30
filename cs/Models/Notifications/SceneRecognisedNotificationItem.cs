namespace Bounan.Common.Models.Notifications;

/// <summary>
/// Information about scenes recognised in a video.
/// </summary>
public record SceneRecognisedNotificationItem(VideoKey VideoKey, Scenes? Scenes);