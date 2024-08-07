using System;

namespace Unity.Services.Multiplay.Authoring.Core.MultiplayApi
{
    public record LogSearchParams(Guid FleetId, long ServerId, string Query, int Size, DateTime From, DateTime To, string PaginationToken = null);
}
