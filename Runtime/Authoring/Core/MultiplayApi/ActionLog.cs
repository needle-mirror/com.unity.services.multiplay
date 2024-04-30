using System;

namespace Unity.Services.Multiplay.Authoring.Core.MultiplayApi
{
    record ActionLog(long Id, long ServerID, long ActionID, long MachineID, string Message, DateTime Date, string Attachment = default);
}
