namespace Bounan.Common.Models;

public record Interval<T>
{
    public required T Start { get; init; }

    public required T End { get; init; }
}