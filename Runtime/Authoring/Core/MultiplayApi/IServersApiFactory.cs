using System.Threading.Tasks;

namespace Unity.Services.Multiplay.Authoring.Core.MultiplayApi
{
    public interface IServersApiFactory
    {
        Task<IServersApi> Build();
    }
}
