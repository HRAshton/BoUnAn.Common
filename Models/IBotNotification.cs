namespace Bounan.Common.Models;

public interface IBotNotification : IVideoKey
{
    ICollection<long> ChatIds { get; }

    int? MessageId { get; }
}