﻿namespace Bounan.Common.Models;

public interface IBotNotification : IVideoKey
{
    ICollection<long> ChatIds { get; }

    string? MessageId { get; }
}