namespace Bounan.Common.Models.DirectInteraction.Downloader;

public interface IDwnResponse<out TVideoKey>
    where TVideoKey : IVideoKey
{
    TVideoKey? VideoKey { get; }
}