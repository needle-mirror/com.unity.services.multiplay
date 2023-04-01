using System.Threading.Tasks;

namespace Unity.Services.Multiplay.Authoring.Core.MultiplayApi
{
    /// <summary>
    /// Class to create an authenticated LogsApi
    /// </summary>
    public interface ILogsApiFactory
    {
        /// <summary>
        /// Returns an authenticated LogsApi
        /// </summary>
        /// <returns></returns>
        Task<ILogsApi> Build();
    }
}
