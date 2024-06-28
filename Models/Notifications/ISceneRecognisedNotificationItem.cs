namespace Bounan.Common.Models.Notifications;

/// <summary>
/// Information about scenes recognised in a video.
/// </summary>
public interface ISceneRecognisedNotificationItem : IVideoKey
{
    Scenes? Scenes { get; }
}