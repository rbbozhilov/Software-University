using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class StartUp
    {
        static void Main(string[] args)
        {


            int maxOrders = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool flag = true;

            Queue<int> allOrders = new Queue<int>(input);

            Console.WriteLine(allOrders.Max());

            while (allOrders.Count > 0)
            {

                int helper = maxOrders - allOrders.Peek();

                if (helper < 0)
                {
                    Console.WriteLine("Orders left: " + string.Join(" ", allOrders));
                    flag = false;
                    break;
                }

                maxOrders -= allOrders.Dequeue();


            }

            if (flag)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
