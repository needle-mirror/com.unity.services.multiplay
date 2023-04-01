namespace Unity.Services.Multiplay.Authoring.Core.Assets
{
    /// <summary>
    /// Struct representing a type-safe Fleet Identifier
    /// </summary>
    public readonly struct FleetName : IResourceName
    {
       /// <summary>
       /// Creates a new instance of FleetName
       /// </summary>
        public FleetName(string name) { Name = name; }

        /// <summary>
        /// The name of the Fleet
        /// </summary>
        public string Name { get; init; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is FleetName name && name.Name == Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
