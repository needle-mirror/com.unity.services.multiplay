using System;

namespace Unity.Services.Multiplay.Authoring.Core.Builds
{
    /// <summary>
    /// Represents the identifier of the CCD bucket where direct file upload is stored
    /// </summary>
    public struct CloudBucketId
    {
        /// <summary>
        /// ID of the cloud bucket
        /// </summary>
        public Guid Id { private get; init; }

        /// <summary>
        /// Gets the CloudBucket as a GUID
        /// </summary>
        public Guid ToGuid() => Id;
        /// <inheritdoc />
        public override string ToString() => Id.ToString();
    }
}
