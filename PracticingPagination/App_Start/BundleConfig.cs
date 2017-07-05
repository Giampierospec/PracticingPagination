using System.Web;
using System.Web.Optimization;

namespace PracticingPagination
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular")
                .Include("~/lib/angular/angular.js",
                "~/lib/angular-route/angular-route.js",
                "~/Scripts/ui-bootstrap-tpls-2.5.0.js"));

            bundles.Add(new ScriptBundle("~/bundles/mainCss")
                .Include("~/lib/bootstrap/dist/css/bootstrap.css",
                "~/lib/font-awesome/css/font-awesome.css"));

            bundles.Add(new ScriptBundle("~/bundles/mainJs")
                .Include("~/lib/jquery/dist/jquery.js",
                "~/lib/bootstrap/dist/js/bootstrap.js"));
        }
    }
}