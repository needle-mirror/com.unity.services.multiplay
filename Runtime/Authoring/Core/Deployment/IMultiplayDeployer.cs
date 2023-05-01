using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Unity.Services.DeploymentApi.Editor;
using Unity.Services.Multiplay.Authoring.Core.Assets;
using Unity.Services.Multiplay.Authoring.Core.Model;
using Unity.Services.Multiplay.Authoring.Core.MultiplayApi;

namespace Unity.Services.Multiplay.Authoring.Core.Deployment
{
    /// <summary>
    /// Responsible to make available deployment functionality
    /// </summary>
    public interface IMultiplayDeployer
    {
        /// <summary>
        /// Initialize the MultiplayDeployer with an authenticated client
        /// </summary>
        Task InitAsync();

        /// <summary>
        /// Deploy the associated Multiplay Config items.
        /// Builds will be built and uploaded, Build Configurations and fleets will
        /// be created or updated according to the item.
        /// The item status and progress will be updated along the way.
        /// </summary>
        Task Deploy(IReadOnlyList<DeploymentItem> items, CancellationToken token = default);

        /// <summary>
        /// Build the binaries associated with the build items
        /// </summary>
        Task<(List<BuildItem>, List<BuildItem>)> BuildBinaries(
            IReadOnlyList<BuildItem> buildItems,
            CancellationToken token = default);

        /// <summary>
        /// Uploads the associated builds, and waits for them to be available.
        /// </summary>
        Task<UploadResult> UploadAndSyncBuilds(
            List<BuildItem> successfulBuilds,
            CancellationToken token = default);

        /// <summary>
        /// Creates or Updates the associated build configurations
        /// </summary>
        Task<(Dictionary<BuildConfigurationName, BuildConfigurationId>, List<BuildConfigurationItem>)> DeployBuildConfigs(
            IReadOnlyList<BuildConfigurationItem> items,
            Dictionary<BuildName, BuildId> successfulUploads,
            CancellationToken token);


        /// <summary>
        /// Creates or Updates the associated fleets
        /// </summary>
        /// <param name="buildConfigIds">If the config IDs are known, they will not be searched remotely</param>
        Task DeployFleets(
            IReadOnlyList<FleetItem> items,
            Dictionary<BuildConfigurationName, BuildConfigurationId> buildConfigIds = null,
            CancellationToken token = default);


        /// <summary>
        /// Creates a test allocation for the associated Fleet
        /// </summary>
        Task<AllocationInformation> CreateAndSyncTestAllocationAsync(
            FleetName fleetName,
            BuildConfigurationName buildConfigurationName,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists existing test allocations for the associated fleet
        /// </summary>
        Task<List<AllocationInformation>> ListTestAllocations(FleetId fleetId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends a request to process the removal of a test allocation
        /// </summary>
        Task RemoveTestAllocation(FleetId fleetId, Guid allocationId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets regions that are available for fleet scaling options
        /// </summary>
        Task<Dictionary<string, Guid>> GetAvailableRegions();


        /// <summary>
        /// Deletes the Fleet
        /// </summary>
        Task DeleteFleet(FleetId fleetName);

        /// <summary>
        /// Gets the information of the fleets
        /// </summary>
        public Task<IReadOnlyList<FleetInfo>> GetFleets();

        /// <summary>
        /// Represents the result of a build upload operation
        /// </summary>
        /// <param name="UploadResults">The individual upload result for the build item</param>
        /// <param name="FailedUploads">The Builds that failed to upload</param>
        /// <param name="SuccessfulSyncs">The builds that were successfully synced</param>
        /// <param name="FailedSyncs">The builds that failed to sync</param>
        public record UploadResult(
            Dictionary<BuildItem, BuildUploadResult> UploadResults,
            List<BuildItem> FailedUploads,
            Dictionary<BuildName, BuildId> SuccessfulSyncs,
            List<BuildItem> FailedSyncs);
    }
}
