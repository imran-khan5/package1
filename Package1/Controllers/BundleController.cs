using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Package1.Core.Package.Models;
using Package1.Core.Package.Services.Interfaces;

namespace Package1.Controllers
{

    [RoutePrefix("api/Bundle")]
    public class BundleController : ApiController
    {

        private readonly IPackageService _packageService;

        public BundleController(IPackageService packageService)
        {
            _packageService = packageService;
        }

        // GET: api/Bundle
        public async Task<Bundle> Get(int id)
        {
            var bundle = await _packageService.ReadBundleData(id);

            return bundle;
        }

    }
}
