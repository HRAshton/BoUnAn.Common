namespace Bounan.Common.Models;

public interface IMatcherResponse
{
    ICollection<VideoKey> VideosToMatch { get; init; }
}