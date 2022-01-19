using System.IO;
using WorkShop.HTTP;
using WorkShop.MvcFramework;

namespace MvcFrameworkApp.Controllers
{
    public class StaticFilesController : Controller
    {

        public HttpResponse Favicon(HttpRequest request)
        {
            return this.FileResponse("wwwroot/favicon.ico", "image/x-icon");
        }


        public HttpResponse BootStrapCss(HttpRequest request)
        {
            return this.FileResponse("wwwroot/css/bootstrap.min.css", "text/css");
        }


        public HttpResponse CustomCss(HttpRequest request)
        {
            return this.FileResponse("wwwroot/css/custom.css", "text/css");
        }

        public HttpResponse CustomJs(HttpRequest request)
        {
            return this.FileResponse("wwwroot/js/custom.js", "text/javascript");
        }

        public HttpResponse BootStrapJs(HttpRequest request)
        {
            return this.FileResponse("wwwroot/js/bootstrap.bundle.min.js", "text/javascript");
        }

    }
}
