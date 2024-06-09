namespace Bounan.Common.Models;

public interface IVideoScenesResponse<T>
    where T : IVideoScenesResponseItem
{
    ICollection<T> Items { get; }
}