using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MakingPizzaAsynchronous
{
    class Program
    {
        static async Task Main(string[] args)
        {

            await BakingPizzaAsync();

            
            
        }

        public static async Task BakingPizzaAsync()
        {
            Pizza pizza = new Pizza();

            await Task.WhenAll(pizza.PotatoesAsync(),
                               pizza.TomatoesAsync(),
                               pizza.MushRoomsAsync(),
                               pizza.CheeseAsync());

            await Task.Run(pizza.DoughAsync);
        }


    }
}
