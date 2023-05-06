using System.Threading.Tasks;

namespace Unity.Services.Multiplay.Authoring.Core.MultiplayApi
{
    /// <summary>
    /// Represents an object that requires asynchronous initialization before use
    /// </summary>
    public interface IInitializable
    {
        /// <summary>
        /// The initialization the object requires to do
        /// </summary>
        public Task InitAsync();
    }
}
