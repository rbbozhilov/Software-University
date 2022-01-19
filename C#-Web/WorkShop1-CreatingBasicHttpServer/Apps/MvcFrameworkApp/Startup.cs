using MvcFrameworkApp.Controllers;
using System.Collections.Generic;
using WorkShop.HTTP;
using WorkShop.MvcFramework;

namespace MvcFrameworkApp
{
    public class Startup : IMvcApplication
    {
        public void Configure(List<Route> routeTable)
        {
            routeTable.Add(new Route("/", HttpMethod.Get, new HomeController().HomePage));
            routeTable.Add(new Route("/about", HttpMethod.Get, new HomeController().About));
            routeTable.Add(new Route("/users/login", HttpMethod.Get, new UsersController().Login));
            routeTable.Add(new Route("/users/register", HttpMethod.Get, new UsersController().Register));

            routeTable.Add(new Route("/favicon.ico",HttpMethod.Get, new StaticFilesController().Favicon));

            routeTable.Add(new Route("/css/bootstrap.min.css", HttpMethod.Get, new StaticFilesController().BootStrapCss));
            routeTable.Add(new Route("/css/custom.css", HttpMethod.Get, new StaticFilesController().CustomCss));

            routeTable.Add(new Route("/js/bootstrap.bundle.min.js", HttpMethod.Get, new StaticFilesController().BootStrapJs));
            routeTable.Add(new Route("/js/custom.js", HttpMethod.Get, new StaticFilesController().CustomJs));
        }

        public void ConfigureServices()
        {
            
        }
    }
}
