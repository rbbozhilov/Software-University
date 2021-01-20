using System;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<days>\d{2})(?<seperators>[-.\/])(?<month>[A-Z][a-z]{2})\k<seperators>(?<year>\d{4})\b";

            string text = Console.ReadLine();

            var matches = Regex.Matches(text, pattern);

            foreach (Match items in matches)
            {

                Console.WriteLine("Day: {0}, Month: {1}, Year: {2}", items.Groups["days"].Value, items.Groups["month"].Value, items.Groups["year"].Value);


            }
        }
    }
}
