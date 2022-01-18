using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop.HTTP;

namespace WorkShop.MvcFramework
{
    public abstract class Controller
    {

        public HttpResponse View(string viewPath)
        {
            string responseHtml = File.ReadAllText(viewPath);
            var responseHTTP = new HttpResponse(HttpStatusCode.Ok, "text/html", Encoding.UTF8.GetBytes(responseHtml));
            responseHTTP.Headers.Add(new Header("Server", "LionSky"));
            responseHTTP.Cookies.Add(new ResponseCookie("sid", Guid.NewGuid().ToString()) { HttpOnly = true, MaxAge = 60 * 24 * 60 * 60 });

            return responseHTTP;
        }

    }
}
