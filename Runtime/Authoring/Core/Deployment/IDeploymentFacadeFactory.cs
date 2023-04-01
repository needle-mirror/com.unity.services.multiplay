using System.Threading.Tasks;

namespace Unity.Services.Multiplay.Authoring.Core.Deployment
{
    /// <summary>
    /// This factory will create a JWT authenticated version of IDeployment facade
    /// </summary>
    public interface IDeploymentFacadeFactory
    {
        /// <summary>
        /// Create an authenticated IDeploymentFacade
        /// </summary>
        Task<IDeploymentFacade> BuildAsync();
    }
}
