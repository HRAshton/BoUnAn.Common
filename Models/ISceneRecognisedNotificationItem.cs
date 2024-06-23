namespace Bounan.Common.Models;

/// <summary>
/// Information about scenes recognised in a video.
/// </summary>
public interface ISceneRecognisedNotificationItem : IVideoKey
{
    Scenes? Scenes { get; }
}