using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Unity.Services.Multiplay.Authoring.Core.MultiplayApi
{
    interface ILogsApi
    {
        Task<LogSearchResult> SearchLogsAsync(LogSearchParams searchParams, CancellationToken cancellationToken = default);
    }
}
