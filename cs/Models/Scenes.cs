namespace Bounan.Common.Models;

public record Scenes
{
    public Interval? Opening { get; init; }

    public Interval? Ending { get; init; }

    public Interval? SceneAfterEnding { get; init; }
}