using System;
using System.Collections.Generic;

namespace Unity.Services.Multiplay.Authoring.Core.MultiplayApi
{
    public record LogEntryMetadata(System.Guid FleetId, string MessageId, string ServerId, string Source, DateTime Timestamp);
    public record LogEntry(string Message, LogEntryMetadata MetaData);
    public record LogSearchResult(decimal Count, List<LogEntry> Entries, string PaginationToken);
}
