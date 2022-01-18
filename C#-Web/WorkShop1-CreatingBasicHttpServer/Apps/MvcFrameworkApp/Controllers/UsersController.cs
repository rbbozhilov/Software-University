using System;
using System.IO;
using System.Text;
using WorkShop.HTTP;
using WorkShop.MvcFramework;

namespace MvcFrameworkApp.Controllers
{
    public class UsersController : Controller
    {

        public HttpResponse Login(HttpRequest request)
        {
            return this.View("Views/User/Login.html");
        }

        public HttpResponse Register(HttpRequest request)
        {
            return this.View("Views/User/Register.html");
        }

    }
}
