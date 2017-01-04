using Package1.Web.Bundles;
using System.Web.Optimization;

namespace Package1.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new FrameworkBundle("~/bundles/framework"));
            bundles.Add(new AppBundle("~/bundles/app"));
            bundles.Add(new ServiceBundle("~/bundles/services"));
            bundles.Add(new ControllerBundle("~/bundles/controllers"));
            bundles.Add(new SiteStyleBundle("~/bundles/site"));

#if DEBUG
            BundleTable.EnableOptimizations = false;
#endif
#if !DEBUG
            BundleTable.EnableOptimizations = true; // Set this to true once we are confident the minification is working
#endif
        }
    }
}
