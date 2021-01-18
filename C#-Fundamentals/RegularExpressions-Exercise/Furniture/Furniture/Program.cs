using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>(?<productName>\w+)<<(?<price>(?:\d+\.\d+|\d+))!(?<counter>\d+)\b";

            Regex regex = new Regex(pattern);



            string input = string.Empty;
            double totalSum = 0;

            var products = new List<string>();

            while ((input = Console.ReadLine()) != "Purchase")
            {

                if (regex.IsMatch(input))
                {
                    Match matches = regex.Match(input);
                    products.Add(matches.Groups["productName"].Value);
                    totalSum += double.Parse(matches.Groups["price"].Value) * int.Parse(matches.Groups["counter"].Value);

                }
            }


            Console.WriteLine("Bought furniture:");

            foreach (var items in products)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("Total money spend: {0:F2}", totalSum);
        }
    }
}
