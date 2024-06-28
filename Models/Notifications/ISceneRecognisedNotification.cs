namespace Bounan.Common.Models.Notifications;

/// <summary>
/// Notification that a scene(s) has been recognised / failed to recognise.
/// </summary>
/// <typeparam name="T">The type of the items of the notification.</typeparam>
public interface ISceneRecognisedNotification<T> : IBundledModel<T>
    where T : ISceneRecognisedNotificationItem;