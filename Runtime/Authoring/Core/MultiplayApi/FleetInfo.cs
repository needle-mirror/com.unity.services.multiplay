using System;

namespace Unity.Services.Multiplay.Authoring.Core.MultiplayApi
{
    class FleetInfo
    {
        public FleetInfo(
            string fleetName,
            FleetId id,
            Status fleetStatus,
            Guid osId,
            string osName,
            AllocationStatus allocationStatus = null)
        {
            FleetName = fleetName;
            FleetStatus = fleetStatus;
            OsId = osId;
            OSName = osName;
            Id = id;
            Allocation = allocationStatus;
        }

        public FleetId Id { get; }
        public string FleetName { get; }
        public Status FleetStatus { get; }
        public Guid OsId { get; }
        public string OSName { get; }
        public AllocationStatus Allocation { get; }

        public enum Status
        {
            Online = 1,
            Draining = 2,
            Offline = 3
        }

        public record AllocationStatus(int Total, int Allocated, int Available, int Online);
    }
}
