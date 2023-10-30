using System.Threading.Tasks;
using Unity.Services.Multiplay.Authoring.Core.MultiplayApi;
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Allocations.Apis.Allocations;

namespace Unity.Services.Multiplay.Authoring.Editor.MultiplayApis
{
    class AllocationApi : IAllocationApi
    {
        private readonly IAllocationsApiClient m_Client;

        public AllocationApi(IAllocationsApiClient client)
        {
            m_Client = client;
        }

        public async Task<AllocationResult> CreateTestAllocation()
        {
            var res = await m_Client.ProcessTestAllocationAsync(null, null);
            return new AllocationResult(res.Result.AllocationId);
        }
    }
}
