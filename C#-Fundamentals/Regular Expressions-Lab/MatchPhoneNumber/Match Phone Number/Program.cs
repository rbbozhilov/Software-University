using System;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([\s-])2\1(\d{3})\1(\d{4})\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(Console.ReadLine());

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
