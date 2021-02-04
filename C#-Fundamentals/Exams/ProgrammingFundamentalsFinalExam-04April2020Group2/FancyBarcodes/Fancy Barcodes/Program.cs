using System;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePattern = @"^@#+(?<name>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+$";
            Regex nameRegex = new Regex(namePattern);
            string numberPattern = @"\d";
            Regex numberRegex = new Regex(numberPattern);



            int barcodes = int.Parse(Console.ReadLine());

            for (int i = 0; i < barcodes; i++)
            {

                string barcode = Console.ReadLine();

                if (nameRegex.IsMatch(barcode))
                {

                    Match match = nameRegex.Match(barcode);

                    string currentName = match.Groups["name"].Value;

                    if (char.IsUpper(currentName[currentName.Length - 1]))
                    {

                        if (numberRegex.IsMatch(barcode))
                        {
                            MatchCollection matches = numberRegex.Matches(barcode);
                            string currentNumber = string.Empty;

                            foreach (Match items in matches)
                            {
                                currentNumber += items;
                            }


                            Console.WriteLine($"Product group: {currentNumber}");

                        }

                        else
                        {
                            Console.WriteLine("Product group: 00");
                        }


                    }


                }

                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }
        }
    }
}
