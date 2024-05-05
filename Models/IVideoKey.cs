namespace Bounan.Common.Models;

/// <summary>
/// Represents the primary key for a video.
/// </summary>
public interface IVideoKey
{
    /// <summary>
    /// Gets the MyAnimeList ID of the anime.
    /// </summary>
    int MyAnimeListId { get; }

    /// <summary>
    /// Gets the dub of the video.
    /// </summary>
    string Dub { get; }

    /// <summary>
    /// Gets the episode number of the video.
    /// </summary>
    int Episode { get; }
}