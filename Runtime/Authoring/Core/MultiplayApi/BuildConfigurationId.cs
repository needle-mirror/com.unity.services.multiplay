namespace Unity.Services.Multiplay.Authoring.Core.MultiplayApi
{
    /// <summary>
    /// Represents a type-safe Build Configuration ID
    /// </summary>
    public struct BuildConfigurationId
    {
        /// <summary>
        /// The numerical value of the Build Config TBA
        /// </summary>
        public long Id { private get; init; }

        /// <summary>
        /// The numerical value of the Build Config TBA
        /// </summary>
        public long ToLong() => Id;
    }
}
