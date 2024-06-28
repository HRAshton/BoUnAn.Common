using Bounan.Common.Enums;

namespace Bounan.Common.Models.DirectInteraction.Bot;

public interface IBotResponse
{
    VideoStatus Status { get; }

    int? MessageId { get; }

    Scenes? Scenes { get; }
}