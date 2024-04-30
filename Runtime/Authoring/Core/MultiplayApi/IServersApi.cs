using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Unity.Services.Multiplay.Authoring.Core.MultiplayApi
{
    interface IServersApi
    {
        Task<bool> TriggerServerActionAsync(long serverId, ServerAction action, CancellationToken cancellationToken = default);
        Task<ServerInfo> GetServerAsync(long serverId, CancellationToken cancellationToken = default);
        Task<List<ActionLog>> GetServerActionLogsAsync(long serverId, CancellationToken cancellationToken = default);
    }
}
