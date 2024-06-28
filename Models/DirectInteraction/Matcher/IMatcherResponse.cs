namespace Bounan.Common.Models.DirectInteraction.Matcher;

public interface IMatcherResponse
{
    ICollection<VideoKey> VideosToMatch { get; init; }
}