using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            var dictionary = new Dictionary<string, Dictionary<double, int>>();


            while ((input = Console.ReadLine()) != "buy")
            {

                string[] tokens = input.Split();

                string item = tokens[0];
                double price = double.Parse(tokens[1]);
                int uantity = int.Parse(tokens[2]);


                if (!dictionary.ContainsKey(item))
                {

                    dictionary.Add(item, new Dictionary<double, int>());

                    dictionary[item].Add(price, uantity);

                }

                else
                {

                    var currentDic = dictionary[item];
                    int currentUant = 0;


                    foreach (var items in currentDic)
                    {
                        currentUant = items.Value;

                    }

                    Dictionary<double, int> curDic = new Dictionary<double, int>();

                    curDic.Add(price, currentUant);

                    if (!dictionary[item].ContainsKey(price))
                    {


                        dictionary[item] = curDic;

                        dictionary[item][price] += uantity;



                    }

                    else
                    {
                        dictionary[item][price] += uantity;
                    }

                }


            }


            foreach (var items in dictionary)
            {

                var dict = items.Value;

                foreach (var itens in dict)
                {
                    Console.WriteLine("{0} -> {1:F2}", items.Key, itens.Key * itens.Value);
                }

            }
        }
    }
}
