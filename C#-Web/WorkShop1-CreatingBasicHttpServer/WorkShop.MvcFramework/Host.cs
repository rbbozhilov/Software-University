using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop.HTTP;
using WorkShop.HTTP.Contracts;

namespace WorkShop.MvcFramework
{
    public static class Host
    {

        public static async Task RunAsync(IMvcApplication application)
        {

            List<Route> routeTable = new List<Route>();

            application.ConfigureServices();
            application.Configure(routeTable);

            IHttpServer server = new HttpServer();

        

            foreach (var route in routeTable)
            {
                server.AddRoute(route.Path, route.Action);
            }

            await server.StartAsync(2929);
        }

    }
}
