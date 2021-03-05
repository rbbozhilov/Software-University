using System;
using System.Collections.Generic;

namespace SuperMarket
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string text = string.Empty;
            Queue<string> customers = new Queue<string>();


            while ((text = Console.ReadLine()) != "End")
            {

                if (text == "Paid" && customers.Count != 0)
                {
                    int count = customers.Count;

                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }

                }

                else
                {
                    customers.Enqueue(text);
                }


            }

            Console.WriteLine("{0} people remaining.", customers.Count);

        }
    }
}
