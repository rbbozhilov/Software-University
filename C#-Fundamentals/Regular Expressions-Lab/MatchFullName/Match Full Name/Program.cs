using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            var regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(Console.ReadLine());

            foreach (var items in matches)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine();
        }
    }
}
