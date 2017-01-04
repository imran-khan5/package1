using System.Web.Optimization;

namespace Package1.Web.Bundles
{
    public sealed class SiteStyleBundle : Bundle
    {
        public SiteStyleBundle(string virtualPath)
            : base(virtualPath, new CssMinify())
        {
            Include(
                "~/Content/Style/Framework/toastr.min.css",
                "~/Content/Style/Framework/bootstrap.min.css",
                "~/Content/Style/Framework/jquery-ui.min.css",
                "~/Content/Style/Framework/jquery-ui.structure.min.css",
                "~/Content/Style/Framework/bootstrap-theme.min.css",
                "~/Content/Style/site.css"
                );
        }
    }
}
