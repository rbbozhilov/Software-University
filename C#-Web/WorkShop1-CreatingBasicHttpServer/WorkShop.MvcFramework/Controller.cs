using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WorkShop.HTTP;

namespace WorkShop.MvcFramework
{
    public abstract class Controller
    {

        public HttpResponse View([CallerMemberName]string viewPath  = null)
        {
            string viewHtml = File.ReadAllText("Views/" + this.GetType().Name.Replace("Controller",string.Empty) + "/" + viewPath + ".html");
            string layoutHtml = File.ReadAllText("Views/Shared/_Layout.html");
            string responseHtml = layoutHtml.Replace("@RenderBody()", viewHtml);

            var responseHTTP = new HttpResponse(HttpStatusCode.Ok, "text/html", Encoding.UTF8.GetBytes(responseHtml));
         
            responseHTTP.Headers.Add(new Header("Server", "LionSky"));
          
            responseHTTP.Cookies.Add(new ResponseCookie("sid", Guid.NewGuid().ToString()) { HttpOnly = true, MaxAge = 60 * 24 * 60 * 60 });

            return responseHTTP;
        }

        public HttpResponse FileResponse(string filePath,string contentType)
        {

            var bytes = File.ReadAllBytes(filePath);

            var response = new HttpResponse(HttpStatusCode.Ok, contentType, bytes);

            return response;
        }


    }
}
