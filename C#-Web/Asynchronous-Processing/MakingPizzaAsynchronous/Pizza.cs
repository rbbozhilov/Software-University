using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MakingPizzaAsynchronous
{
    public class Pizza : IPizza
    {

        public Pizza()
        {

        }


        public async Task CheeseAsync()
        {
            await Task.Delay(5000);
            Console.WriteLine("breading of yellow cheese");
            Console.WriteLine("cheese ready!");
        }


        public async Task DoughAsync()
        {
            await Task.Delay(4000);
            Console.WriteLine("Baking pizza");
            Console.WriteLine("The pizza is ready!");
        }


        public async Task MushRoomsAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("mushroom cutting");
            Console.WriteLine("Ready! mushrooms");
        }


        public async Task PotatoesAsync()
        {
            await Task.Delay(2000);
            Console.WriteLine("potatoe cutting");
            Console.WriteLine("Ready potatoes");
        }


        public async Task TomatoesAsync()
        {
            await Task.Delay(920);
            Console.WriteLine("tomatoe cutting");
            Console.WriteLine("Ready tomatoes");
        }
    }
}
