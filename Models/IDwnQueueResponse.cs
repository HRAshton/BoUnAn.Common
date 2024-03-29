namespace Bounan.Common.Models;

public interface IDwnQueueResponse<out TVideoKey>
    where TVideoKey : IVideoKey
{
    TVideoKey? VideoKey { get; }
}