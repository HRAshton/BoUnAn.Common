namespace Bounan.Common.Models;

public record Scenes
{
    public required Interval<float> Opening { get; init; }

    public required Interval<float> Ending { get; init; }
}