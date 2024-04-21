using Bounan.Common.Enums;

namespace Bounan.Common.Models;

public interface IBotResponse
{
    VideoStatus Status { get; }

    string? MessageId { get; }
}