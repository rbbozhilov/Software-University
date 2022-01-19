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
      
            await Host.RunAsync(new Startup());
        }


    }
}
