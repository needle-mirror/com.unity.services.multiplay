using System.Threading;
using System.Threading.Tasks;

namespace Unity.Services.Multiplay.Authoring.Core.MultiplayApi
{
    /// <summary>
    /// Allows to find logs happening on the remote server
    /// </summary>
    public interface ILogsApi
    {
        /// <summary>
        /// Returns logs found according to the parameters
        /// </summary>
        Task<LogSearchResult> SearchLogsAsync(LogSearchParams searchParams, CancellationToken cancellationToken = default);
    }
}
