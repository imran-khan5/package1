using System.Web.Optimization;

namespace Package1.Web.Bundles
{
    public sealed class FrameworkBundle : Bundle
    {
        public FrameworkBundle(string virtualPath)
            : base(virtualPath)
        {
            Include(
                "~/Scripts/angular.min.js",
                "~/Scripts/angular-route.min.js",
                "~/Scripts/jquery-1.10.2.min.js",
                "~/Scripts/jquery-ui/jquery-ui.min.js",
                "~/Scripts/bootstrap.min.js"
            );
        }
    }

    public sealed class AppBundle : Bundle
    {
        public AppBundle(string virtualPath)
            : base(virtualPath)
        {
            Include(
                "~/App/app.js",
                "~/Scripts/angular-ui/ui-bootstrap-custom-0.10.0.min.js",
                "~/Scripts/angular-ui/ui-bootstrap-custom-tpls-0.10.0.min.js",
                "~/Scripts/angular-ui/ui-bootstrap-modal.js",
                "~/Scripts/angular-ui/angular-ui.min.js",
                "~/Scripts/toaster.min.js"
            );
        }
    }

    public sealed class ServiceBundle : Bundle
    {
        public ServiceBundle(string virtualPath)
            : base(virtualPath)
        {
            Include(
                "~/App/Services/Bundle/BundleService.js"
            );
        }
    }

    public sealed class ControllerBundle : Bundle
    {
        public ControllerBundle(string virtualPath)
            : base(virtualPath)
        {
            Include(
                "~/App/Controllers/HomeController.js",
                "~/App/Controllers/Bundle/BundleDetailController.js"
            );
        }
    }

}