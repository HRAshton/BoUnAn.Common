namespace Bounan.Common.Models.DirectInteraction.Bot;

public interface IBotRequest : IVideoKey
{
    long ChatId { get; }
}