using System.Web;
using System.Web.Optimization;

namespace Almwdeh
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/vendors/bootstrap/dist/css/"+ "bootstrap.min.css")
                .Include("~/vendors/font-awesome/css/"+ "font-awesome.min.css")
                .Include("~/vendors/nprogress" + "nprogress.css")
                .Include("~/vendors/animate.css/" + "animate.min.css")
                .Include("~/build/css/" + "custom.min.css")
                );

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/vendors/jquery/dist/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/lib")
                .Include("~/vendors/bootstrap/dist/js/" + "bootstrap.bundle.min.js")
                .Include("~/vendors/fastclick/lib/"+"fastclick.js")
                .Include("~/vendors/nprogress/"+"nprogress.js")
                .Include("~/vendors/bootstrap-wysiwyg/js/"+"bootstrap-wysiwyg.min.js")
                .Include("~/vendors/jquery.hotkeys/"+"jquery.hotkeys.js")
                .Include("~/vendors/jQuery-Smart-Wizard/js/" + "jquery.smartWizard.js")
                 .Include("~/vendors/google-code-prettify/" + "prettify.js")
                 .Include("~/build/js/" + "custom.min.js")
                );



        }
    }
}
