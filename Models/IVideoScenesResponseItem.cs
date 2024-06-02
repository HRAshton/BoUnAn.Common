namespace Bounan.Common.Models;

public interface IVideoScenesResponseItem
{
    VideoKey VideoKey { get; }

    Scenes Scenes { get; }
}