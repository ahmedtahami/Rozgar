using System.Web;
using System.Web.Optimization;

namespace Rozgar
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Scripts/js").Include(
                    "~/Content/js/jquery.min.js",
                    "~/Content/js/bootstrap.bundle.min.js",
                    "~/Content/js/jquery.easing.min.js",
                    "~/Content/js/jquery.easing.min.js",
                    "~/Content/js/plugins.js",
                    "~/Content/js/selectize.min.js",
                    "~/Content/js/selectize.min.js",
                    "~/Content/js/jquery.nice-select.min.js",
                    "~/Content/js/owl.carousel.min.js",
                    "~/Content/js/counter.int.js",
                    "~/Content/js/counter.int.js",
                    "~/Content/js/app.js",
                    "~/Content/js/home.js"
                    ));

             bundles.Add(new StyleBundle("~/Styles/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/materialdesignicons.min.css",
                      "~/Content/css/fontawesome.css",
                      "~/Content/css/selectize.css",
                      "~/Content/css/selectize.css",
                      "~/Content/css/owl.carousel.css",
                      "~/Content/css/owl.theme.css",
                      "~/Content/css/owl.transitions.css",
                      "~/Content/css/style.css"
                      ));
        }
    }
}
