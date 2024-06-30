namespace Bounan.Common.Models.DirectInteraction.Bot;

public interface IBotRequest
{
    VideoKey VideoKey { get; }

    long ChatId { get; }
}