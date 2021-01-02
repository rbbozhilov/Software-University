using System;
using System.Linq;

namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            words = words.Where(x => x.Length % 2 == 0).ToArray();

            foreach (var items in words)
            {
                Console.WriteLine(items);
            }
        }
    }
}
