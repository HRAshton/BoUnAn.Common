namespace Bounan.Common.Models;

public interface IDwnResultNotification : IVideoKey
{
    string? MessageId { get; }
}