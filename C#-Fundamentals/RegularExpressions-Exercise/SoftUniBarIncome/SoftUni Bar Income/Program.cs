using System;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternName = @"%(?<name>[A-Z][a-z]+)%";
            string patterProduct = @"<(?<product>\w+)>";
            string patternCounter = @"\|(?<counter>\d+)\|";
            string patternPrice = @"(?<price>[0-9.0-9]+)\$";



            Regex regexName = new Regex(patternName);
            Regex regexProduct = new Regex(patterProduct);
            Regex regexCounter = new Regex(patternCounter);
            Regex regexPrice = new Regex(patternPrice);




            string text = string.Empty;
            double totalPrice = 0;
            while ((text = Console.ReadLine()) != "end of shift")
            {

                if (regexName.IsMatch(text) && regexProduct.IsMatch(text) && regexCounter.IsMatch(text) && regexPrice.IsMatch(text))
                {
                    Match currentName = regexName.Match(text);
                    Match currentProduct = regexProduct.Match(text);
                    Match currentCounter = regexCounter.Match(text);
                    Match currentPrice = regexPrice.Match(text);

                    Console.WriteLine("{0}: {1} - {2:F2}", currentName.Groups["name"].Value, currentProduct.Groups["product"].Value, int.Parse(currentCounter.Groups["counter"].Value) * double.Parse(currentPrice.Groups["price"].Value));
                    totalPrice += double.Parse(currentPrice.Groups["price"].Value) * int.Parse(currentCounter.Groups["counter"].Value);
                }

            }

            Console.WriteLine("Total income: {0:F2}", totalPrice);
        }
    }
}
