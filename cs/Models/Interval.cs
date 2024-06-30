namespace Bounan.Common.Models;

public record Interval
{
    public required float Start { get; init; }

    public required float End { get; init; }
}