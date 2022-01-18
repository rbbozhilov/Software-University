using MvcFrameworkApp.Controllers;
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


            server.AddRoute("/", new HomeController().HomePage);
            server.AddRoute("/about", new HomeController().About);
            server.AddRoute("/users/login", new UsersController().Login);
            server.AddRoute("/users/register", new UsersController().Register);
            server.AddRoute("/favicon.ico", new StaticFilesController().Favicon);

            await server.StartAsync(2929);
        }


    }
}
