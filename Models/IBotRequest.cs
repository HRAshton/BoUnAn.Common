namespace Bounan.Common.Models;

public interface IBotRequest
{
	int MyAnimeListId { get; }

	string Dub { get; }

	int Episode { get; }

	long ChatId { get; }
}