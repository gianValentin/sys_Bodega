using System.Web;
using System.Web.Optimization;

namespace sys_bodega
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles templates
            bundles.Add(new StyleBundle("~/Template/css").Include(
                "~/lib/bootstrap/css/bootstrap.min.css",
                "~/lib/font-awesome/css/font-awesome.css",
                "~/css/style.css",
                "~/css/style-responsive.css"
                ));

            bundles.Add(new ScriptBundle("~/Template/js").Include(
                "~/lib/jquery/jquery.min.js",
                "~/lib/bootstrap/js/bootstrap.min.js",
                "~/lib/jquery.backstretch.min.js"
                ));

            bundles.Add(new ScriptBundle("~/Template/jsMain").Include(
                "~/lib/jquery-ui-1.9.2.custom.min.js",
                "~/lib/jquery.ui.touch-punch.min.js",
                "~/lib/jquery.dcjqaccordion.2.7.js",
                "~/lib/jquery.scrollTo.min.js",
                "~/lib/jquery.nicescroll.js",
                "~/lib/common-scripts.js"
                ));
        }
    }
}
