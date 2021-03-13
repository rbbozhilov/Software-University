using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] prices = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).Select(s => s * 1.2m).ToArray();


            prices.ToList().ForEach(s => Console.WriteLine("{0:F2}", s));
        }
    }
}
