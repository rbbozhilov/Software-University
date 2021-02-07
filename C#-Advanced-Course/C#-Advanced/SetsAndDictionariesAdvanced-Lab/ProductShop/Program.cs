using System;
using System.Linq;
using System.Collections.Generic;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {


            string text = string.Empty;
            var shops = new Dictionary<string, Dictionary<string, double>>();

            while((text=Console.ReadLine()) !="Revision")
            {

                string[] tokens = text.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string currentShop = tokens[0];
                string currentProduct = tokens[1];
                double currentPrice = double.Parse(tokens[2]);

                if(!shops.ContainsKey(currentShop))
                {

                    shops.Add(currentShop, new Dictionary<string, double>());
                    shops[currentShop].Add(currentProduct, currentPrice);

                }

                else
                {
                    shops[currentShop].Add(currentProduct, currentPrice);
                }


            }


            shops = shops.OrderBy(x => x.Key).ToDictionary(x => x.Key, v => v.Value);

            foreach(var items in shops)
            {
                Console.WriteLine("{0}->",items.Key);

                foreach(var itens in items.Value)
                {
                    Console.WriteLine("Product: {0}, Price: {1}",itens.Key,itens.Value);
                }

            }

            

        }
    }
}
