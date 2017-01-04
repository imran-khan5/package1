using System.Threading.Tasks;

namespace Package1.Core.Package.Proxy.Interfaces
{
    public interface IBundleProxy
    {
        Task<Models.Package> GetBundleDetails();

    }
}
