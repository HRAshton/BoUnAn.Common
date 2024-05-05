namespace Bounan.Common.Models;

public record Scenes
{
    public Interval<float>? Opening { get; init; }

    public Interval<float>? Ending { get; init; }
}