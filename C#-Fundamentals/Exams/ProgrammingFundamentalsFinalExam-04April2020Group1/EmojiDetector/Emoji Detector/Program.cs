using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Numerics;

namespace Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string namePattern = @"(?<start>[:*]{2})(?<name>[A-Z][a-z]{2,})(?<end>[:*]{2})";
            Regex nameRegex = new Regex(namePattern);
            string numberPattern = @"\d";
            Regex numberRegex = new Regex(numberPattern);
            BigInteger number = new BigInteger();
            BigInteger currentNumber = new BigInteger();
            number = 1;
            List<string> names = new List<string>();
            List<string> coolEmoji = new List<string>();
            List<string> fullName = new List<string>();
            currentNumber = 0;

            if (nameRegex.IsMatch(text))
            {



                MatchCollection matches = nameRegex.Matches(text);

                foreach (Match items in matches)
                {

                    if ((items.Groups["start"].Value[0] == items.Groups["start"].Value[1]) && (items.Groups["end"].Value[0] == items.Groups["end"].Value[1]) && items.Groups["start"].Value == items.Groups["end"].Value)
                    {

                        names.Add(items.Groups["name"].Value);
                        fullName.Add(items.Groups[0].Value);

                    }
                }

                MatchCollection numberMatches = numberRegex.Matches(text);

                foreach (Match items in numberMatches)
                {

                    number *= int.Parse(items.Value);

                }


                for (int i = 0; i < names.Count; i++)
                {

                    foreach (var items in names[i])
                    {

                        currentNumber += items;

                    }

                    if (currentNumber >= number)
                    {
                        coolEmoji.Add(fullName[i]);
                    }



                    currentNumber = 0;

                }

            }


            Console.WriteLine("Cool threshold: {0}", number);

            Console.WriteLine("{0} emojis found in the text. The cool ones are:", names.Count);

            foreach (var items in coolEmoji)
            {
                Console.WriteLine(items);
            }
        }
    }
}
