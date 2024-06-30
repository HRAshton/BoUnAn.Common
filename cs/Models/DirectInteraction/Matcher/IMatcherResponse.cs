namespace Bounan.Common.Models.DirectInteraction.Matcher;

public interface IMatcherResponse
{
    int MyAnimeListId { get; }

    string Dub { get; }

    ICollection<int> Episodes { get; }
}