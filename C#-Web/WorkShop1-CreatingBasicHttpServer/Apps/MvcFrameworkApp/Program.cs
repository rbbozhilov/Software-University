using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using WorkShop.HTTP;
using WorkShop.HTTP.Contracts;

namespace MvcFrameworkApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IHttpServer server = new HttpServer();


            server.AddRoute("/", HomePage);

            server.AddRoute("/about", About);

            server.AddRoute("/users/login", Login);
            server.AddRoute("/favicon.ico", Favicon);

            await server.StartAsync(2929);
        }

        static HttpResponse HomePage(HttpRequest request)
        {

            string responseHtml = "<h1> Welcome to our site HomePage! </h1>";
            var responseHTTP = new HttpResponse(HttpStatusCode.Ok, "text/html", Encoding.UTF8.GetBytes(responseHtml));
            responseHTTP.Headers.Add(new Header("Server", "LionSky"));
            responseHTTP.Cookies.Add(new ResponseCookie("sid", Guid.NewGuid().ToString()) { HttpOnly = true, MaxAge = 60 * 24 * 60 * 60 });


            return responseHTTP;
        }

        static HttpResponse About(HttpRequest request)
        {

            string responseHtml = "<h1> About page </h1>";
            var responseHTTP = new HttpResponse(HttpStatusCode.Ok, "text/html", Encoding.UTF8.GetBytes(responseHtml));
            responseHTTP.Headers.Add(new Header("Server", "LionSky"));
            responseHTTP.Cookies.Add(new ResponseCookie("sid", Guid.NewGuid().ToString()) { HttpOnly = true, MaxAge = 60 * 24 * 60 * 60 });


            return responseHTTP;


        }

        static HttpResponse Login(HttpRequest request)
        {

            string responseHtml = "<h1> Login page </h1>";
            var responseHTTP = new HttpResponse(HttpStatusCode.Ok, "text/html", Encoding.UTF8.GetBytes(responseHtml));
            responseHTTP.Headers.Add(new Header("Server", "LionSky"));
            responseHTTP.Cookies.Add(new ResponseCookie("sid", Guid.NewGuid().ToString()) { HttpOnly = true, MaxAge = 60 * 24 * 60 * 60 });


            return responseHTTP;


        }

        static HttpResponse Favicon(HttpRequest request)
        {

            var bytes = File.ReadAllBytes("wwwroot/favicon.ico");

            var response = new HttpResponse(HttpStatusCode.Ok, "image/x-icon", bytes);

            return response;
        }


    }
}
