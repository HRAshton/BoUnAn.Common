namespace Bounan.Common.Models.Notifications;

/// <summary>
/// Information about scenes recognised in a video.
/// </summary>
public interface ISceneRecognisedNotificationItem
{
    VideoKey VideoKey { get; }

    Scenes? Scenes { get; }
}