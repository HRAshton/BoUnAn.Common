namespace Bounan.Common.Models.DirectInteraction.Downloader;

public interface IDwnResultRequest : IVideoKey
{
    int? MessageId { get; }
}