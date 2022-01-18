using MvcFrameworkApp.Controllers;
using System.Collections.Generic;
using System.Threading.Tasks;
using WorkShop.HTTP;
using WorkShop.HTTP.Contracts;
using WorkShop.MvcFramework;

namespace MvcFrameworkApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IHttpServer server = new HttpServer();

            List<Route> routeTable = new List<Route>();

            routeTable.Add(new Route("/", new HomeController().HomePage));
            routeTable.Add(new Route("/about", new HomeController().About));
            routeTable.Add(new Route("/users/login", new UsersController().Login));
            routeTable.Add(new Route("/users/register", new UsersController().Register));
            routeTable.Add(new Route("/favicon.ico", new StaticFilesController().Favicon));



            await Host.RunAsync(routeTable);
        }


    }
}
