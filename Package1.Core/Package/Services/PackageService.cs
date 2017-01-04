using System.Linq;
using System.Threading.Tasks;
using Package1.Core.Package.Models;
using Package1.Core.Package.Proxy.Interfaces;
using Package1.Core.Package.Services.Interfaces;

namespace Package1.Core.Package.Services
{
    public class PackageService : IPackageService
    {
        private readonly IBundleProxy _bundleProxy;

        public PackageService(IBundleProxy bundleProxy)
        {
            _bundleProxy = bundleProxy;
        }

        public async Task<Bundle> ReadBundleData(int id)
        {
            //Create a Package which will contain the results of the API call
            Models.Package package = await _bundleProxy.GetBundleDetails();

            var bundle = package.BundleList.FirstOrDefault(b => b.BundleId == id);

            return bundle;
        }
    }
}
