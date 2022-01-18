using System.IO;
using WorkShop.HTTP;
using WorkShop.MvcFramework;

namespace MvcFrameworkApp.Controllers
{
    public class StaticFilesController : Controller
    {

        public HttpResponse Favicon(HttpRequest request)
        {

            var bytes = File.ReadAllBytes("wwwroot/favicon.ico");

            var response = new HttpResponse(HttpStatusCode.Ok, "image/x-icon", bytes);

            return response;
        }

    }
}
