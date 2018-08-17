using System.Web;
using System.Web.Optimization;

namespace ProjetoTCC
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/jquery.min.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/carbon.js",
                        "~/Scripts/chart.min.js",
                        "~/Scripts/demo.js",
                        "~/Scripts/popper.min.js",
                        "~/Scripts/modernizr.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.min.js",
                        "~/Scripts/jquery.validate.pt-br.min.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/fa-brands.css",
                      "~/Content/fa-brands.min.css",
                      "~/Content/fa-regular.css",
                      "~/Content/fa-regular.min.css",
                      "~/Content/fa-solid.css",
                      "~/Content/fa-solid.min.css",
                      "~/Content/fontawesome-all.css",
                      "~/Content/fontawesome-all.min.css",
                      "~/Content/fontawesome.css",
                      "~/Content/fontawesome.min.css",
                      "~/Content/simple-line-icons.css",
                      "~/Content/styles.css"));
        }
    }
}