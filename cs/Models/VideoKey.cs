namespace Bounan.Common.Models;

/// <inheritdoc />
public record VideoKey(int MyAnimeListId, string Dub, int Episode) : IVideoKey;