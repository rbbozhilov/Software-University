using System;
using System.IO;
using System.Text;
using WorkShop.HTTP;
using WorkShop.MvcFramework;

namespace MvcFrameworkApp.Controllers
{
    public class HomeController : Controller
    {

        public HttpResponse HomePage(HttpRequest request)
        {
            return this.View();
        }

        public HttpResponse About(HttpRequest request)
        {
            return this.View();
        }

    }
}
