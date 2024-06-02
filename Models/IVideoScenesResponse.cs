namespace Bounan.Common.Models;

public interface IVideoScenesResponse
{
    IEnumerable<IVideoScenesResponseItem> Items { get; }
}