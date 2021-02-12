using System;
using System.Linq;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            HashSet<string> elements = new HashSet<string>();
            for(int i=0;i<n;i++)
            {

                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach(var items in tokens)
                {
                    elements.Add(items);
                }



            }

            elements = elements.OrderBy(x => x).ToHashSet();

            Console.WriteLine(string.Join(" ",elements));


        }
    }
}
