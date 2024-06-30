namespace Bounan.Common.Models.DirectInteraction.Downloader;

public interface IDwnResultRequest
{
    VideoKey VideoKey { get; }

    int? MessageId { get; }
}