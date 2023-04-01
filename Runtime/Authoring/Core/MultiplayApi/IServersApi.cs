using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Unity.Services.Multiplay.Authoring.Core.MultiplayApi
{
    /// <summary>
    /// Provides access to server information for the project.
    /// See https://services.docs.unity.com/multiplay-config/v1/#tag/Servers for details
    /// </summary>
    public interface IServersApi
    {
        /// <summary>
        /// Trigger an action against the server with the given id
        /// </summary>
        Task<bool> TriggerServerActionAsync(long serverId, ServerAction action, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the details of a single server with the given ID
        /// </summary>
        Task<ServerInfo> GetServerAsync(long serverId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Lists the Action Logs for a server
        /// </summary>
        Task<List<ActionLog>> GetServerActionLogsAsync(long serverId, CancellationToken cancellationToken = default);
    }
}
