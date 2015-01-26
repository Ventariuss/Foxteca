using System.Web;
using System.Web.Optimization;

namespace Foxteca
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/jquery-1.10.2.min.js",
                      "~/Scripts/jquery-ui-1.11.2.min.js",                 
                      "~/Scripts/juicyslider.js"
                      //"~/Scripts/jquery.onepage-scroll.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/Main.css",
                      "~/Content/metro-ui/css/metro-bootstrap.css",
                      "~/Content/css/juicyslider.css",
                      "~/Content/metro-ui/css/iconFont.min.css"
                      //"~/Content/css/onepage-scroll.css"
                      ));
        }
    }
}
