using System;

namespace Unity.Services.Multiplay.Authoring.Core.MultiplayApi
{
    enum ServerStatus
    {
        ALLOCATED = 1,
        RESERVED = 2,
        AVAILABLE = 3,
        ONLINE = 4,
        READY = 5,
        HELD = 6
    }
    record ServerInfo(long Id, long MachineID, string MachineName, long BuildConfigurationID, string BuildConfigurationName, string BuildName, System.Guid FleetID, string FleetName, long LocationID, string LocationName, string Ip, int Port, ServerStatus Status, long CpuLimit, long MemoryLimit, bool Deleted, long HoldExpiresAt = default);
}
