namespace Bounan.Common.Models.Notifications;

/// <summary>
/// Notification that a scene(s) has been recognised / failed to recognise.
/// </summary>
public record SceneRecognisedNotification(List<SceneRecognisedNotificationItem> Items);