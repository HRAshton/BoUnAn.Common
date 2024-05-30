namespace Bounan.Common.Models;

public interface IVideoScenesResponse
{
    VideoKey VideoKey { get; }

    Scenes Scenes { get; }
}