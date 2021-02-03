using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePattern = @"(?:\=(?<name>[A-Z][a-zA-Z]{2,})\=|\/(?<namee>[A-Z][a-zA-Z]{2,})\/)";
            Regex nameRegex = new Regex(namePattern);


            string text = Console.ReadLine();
            List<string> names = new List<string>();


            if (nameRegex.IsMatch(text))
            {

                MatchCollection matches = nameRegex.Matches(text);

                foreach (Match match in matches)
                {

                    if (match.Groups[0].Value[0] == '/')
                    {
                        names.Add(match.Groups["namee"].Value);
                    }

                    else
                    {
                        names.Add(match.Groups["name"].Value);
                    }


                }


            }


            int sum = 0;

            foreach (var items in names)
            {
                sum += items.Length;
            }


            Console.Write("Destinations: ");
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine("Travel Points: {0}", sum);
        }
    }
}
