using System.Threading.Tasks;

namespace Unity.Services.Multiplay.Authoring.Core.MultiplayApi
{
    interface IAllocationApi
    {
        Task<AllocationResult>  CreateTestAllocation();
    }
}
