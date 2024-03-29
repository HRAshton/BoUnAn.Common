namespace Bounan.Common.Models;

public record VideoKey(int MyAnimeListId, string Dub, int Episode) : IVideoKey;