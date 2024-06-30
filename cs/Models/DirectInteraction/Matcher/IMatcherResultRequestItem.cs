namespace Bounan.Common.Models.DirectInteraction.Matcher;

public interface IMatcherResultRequestItem
{
    VideoKey VideoKey { get; }

    Scenes Scenes { get; }
}