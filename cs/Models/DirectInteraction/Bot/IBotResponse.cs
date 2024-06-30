using Bounan.Common.Enums;

namespace Bounan.Common.Models.DirectInteraction.Bot;

public interface IBotResponse
{
    string Status { get; }

    int? MessageId { get; }

    Scenes? Scenes { get; }
}