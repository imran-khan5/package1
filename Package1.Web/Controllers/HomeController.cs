using System.Configuration;
using System.Web.Mvc;

namespace Package1.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.WebApiUrl = ConfigurationManager.AppSettings["WebApiUrl"];
            return View();
        }
    }
}