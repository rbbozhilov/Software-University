using System;
using System.Linq;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            var chars = new SortedDictionary<char, int>();

            foreach(var items in text)
            {

                if(!chars.ContainsKey(items))
                {
                    chars.Add(items, 0);
                }

                chars[items]++;

            }


            foreach(var items in chars)
            {

                Console.WriteLine("{0}: {1} time/s",items.Key,items.Value);

            }

        }
    }
}
