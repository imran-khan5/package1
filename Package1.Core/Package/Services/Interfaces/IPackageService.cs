using System.Threading.Tasks;
using Package1.Core.Package.Models;

namespace Package1.Core.Package.Services.Interfaces
{
    public interface IPackageService
    {
        Task<Bundle> ReadBundleData(int id);
    }
}
