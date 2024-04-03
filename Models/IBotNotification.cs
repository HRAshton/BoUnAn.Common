namespace Bounan.Common.Models;

public interface IBotNotification
{
	ICollection<long> ChatIds { get; }

	int MyAnimeListId { get; }

	string Dub { get; }

	int Episode { get; }

	string? FileId { get; }
}