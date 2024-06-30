namespace Bounan.Common.Models;

public interface IBundledModel<T>
{
    ICollection<T> Items { get; }
}