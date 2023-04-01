namespace Unity.Services.Multiplay.Authoring.Core.MultiplayApi
{
    /// <summary>
    /// Represents a type-safe Build ID
    /// </summary>
    public struct BuildId
    {
        /// <summary>
        /// The numerical value of the Build TBA
        /// </summary>
        public long Id { private get; init; }

        /// <summary>
        /// The numerical value of the Build
        /// </summary>
        public long ToLong() => Id;
    }
}
