using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unity.Services.Core.Editor.Environments;
using Unity.Services.DeploymentApi.Editor;
using Unity.Services.Multiplay.Authoring.Core.Logging;
using Unity.Services.Multiplay.Authoring.Core.Model;
using Unity.Services.Multiplay.Authoring.Core.MultiplayApi;
using Unity.Services.Multiplay.Authoring.Core.Threading;

namespace Unity.Services.Multiplay.Authoring.Editor.Deployment
{
    class FleetStatusTracker
    {
        const string k_FleetStatus = "Fleet Status: ";
        readonly IFleetApiFactory m_Factory;
        readonly ILogger m_Logger;
        readonly IDispatchToMainThread m_Dispatcher;
        readonly IItemStore m_DeploymentItemStore;
        readonly IEnvironmentsApi m_EnvironmentsApi;
        readonly BuildsApiExtensions.ITaskDelay m_TaskDelay;
        IFleetApi m_FleetsClient;
        Exception m_FailedToBuildClient;

        public FleetStatusTracker(
            IFleetApiFactory factory,
            ILogger logger,
            IDispatchToMainThread dispatcher,
            IItemStore deploymentItemStore,
            IEnvironmentsApi environmentsApi,
            BuildsApiExtensions.ITaskDelay taskDelay)
        {
            m_Factory = factory;
            m_Logger = logger;
            m_Dispatcher = dispatcher;
            m_DeploymentItemStore = deploymentItemStore;
            m_EnvironmentsApi = environmentsApi;
            m_TaskDelay = taskDelay;
            m_EnvironmentsApi.PropertyChanged += (sender, args) =>
            {
                m_FleetsClient = null;
            };
            // ReSharper disable once VirtualMemberCallInConstructor : Intentional for testing purposes
            StartLoop();
        }

        internal async Task<bool> Update()
        {
            List<FleetItem> fleetItems = null;
            try
            {
                m_Logger.LogVerbose($"[{nameof(FleetStatusTracker)}] Checking fleet statuses");

                if (!TryCreateClient())
                    return true;

                fleetItems = m_DeploymentItemStore
                    .GetAllItems()
                    .OfType<FleetItem>()
                    .ToList();
                var fleetsInfo = await m_FleetsClient.List();

                foreach (var fleetItem in fleetItems)
                {
                    var fleetInfo = fleetsInfo
                        .FirstOrDefault(f => f.FleetName == fleetItem.OriginalName.Name);

                    m_Dispatcher.DispatchAction(() => UpdateUI(fleetItem, fleetInfo));
                }
            }
            catch (Exception e)
            {
                m_Logger.LogVerbose($"[{nameof(FleetStatusTracker)}] An error occurred: {e}");
                ClearUI(fleetItems);
                return false;
            }

            return true;
        }

        protected virtual void StartLoop()
        {
            var task = Task.Run(UpdateLoop);
        }

        async Task UpdateLoop()
        {
            do
            {
                await m_TaskDelay.Delay(TimeSpan.FromSeconds(30));

                if (await Update())
                    continue;
                break;
            }
            while (true);
        }

        bool TryCreateClient()
        {
            if (m_FailedToBuildClient != null)
                throw new Exception("Could not build client", m_FailedToBuildClient);

            if (m_FleetsClient == null)
            {
                m_Dispatcher.DispatchAction(async() =>
                {
                    try
                    {
                        m_FleetsClient = await m_Factory.Build();
                    }
                    catch (Exception e)
                    {
                        m_Logger.LogVerbose($"[{nameof(FleetStatusTracker)}] Failed to build client. {e}");
                        m_FailedToBuildClient = e;
                    }
                });
                return m_FleetsClient != null;
            }
            return true;
        }

        void UpdateUI(FleetItem fleetItem, FleetInfo fleetInfo)
        {
            var state = GetFleetStatusState(fleetItem);

            if (!string.IsNullOrEmpty(state.Description))
            {
                fleetItem.States.Remove(state);
            }

            if (fleetInfo == null)
            {
                return;
            }

            var severity = SeverityLevel.Warning;
            bool isOffline = fleetInfo.FleetStatus == FleetInfo.Status.Offline;
            if (isOffline)
            {
                severity = SeverityLevel.Info;
            }

            state = new AssetState(
                k_FleetStatus + $" {fleetInfo.FleetStatus} ({fleetInfo.Allocation.Total})",
                isOffline ? string.Empty : $"Online fleets may cost if the servers are being used.{Environment.NewLine}"
                + $"Fleet allocations:{Environment.NewLine}"
                + $"    Allocated: {fleetInfo.Allocation.Allocated}{Environment.NewLine}"
                + $"    Available: {fleetInfo.Allocation.Available}{Environment.NewLine}"
                + $"    Online: {fleetInfo.Allocation.Online}",
                severity);
            fleetItem.States.Add(state);
        }

        void ClearUI(List<FleetItem> fleetItems)
        {
            if (fleetItems == null)
                return;

            foreach (var fleetItem in fleetItems)
            {
                var state = GetFleetStatusState(fleetItem);
                fleetItem.States.Remove(state);
            }
        }

        static AssetState GetFleetStatusState(FleetItem fleetItem)
        {
            var state = fleetItem
                .States
                .FirstOrDefault(s => s.Description.StartsWith(k_FleetStatus));

            return state;
        }
    }
}
