namespace Bounan.Common.Models;

public interface IBotRequest : IVideoKey
{
    long ChatId { get; }
}