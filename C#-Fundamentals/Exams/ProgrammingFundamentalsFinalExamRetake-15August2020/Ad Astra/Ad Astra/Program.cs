using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string currentPattern = @"(?:\#(?<item>[A-Za-z\s]+)\#(?<date>\d{2}\/\d{2}\/\d{2})\#(?<calories>\d{1,5})\#|\|(?<itemm>[A-Za-z\s]+)\|(?<datee>\d{2}\/\d{2}\/\d{2})\|(?<caloriess>\d{1,5})\|)";
            Regex currentRegex = new Regex(currentPattern);
            int currentCalories = 0;
            int calPerDay = 2000;
            List<string> food = new List<string>();



            if (currentRegex.IsMatch(text))
            {

                MatchCollection matches = currentRegex.Matches(text);

                foreach (Match items in matches)
                {

                    int calories = 0;

                    if (items.Groups[0].Value[0] == '#')
                    {

                        calories = int.Parse(items.Groups["calories"].Value);


                    }

                    else
                    {
                        calories = int.Parse(items.Groups["caloriess"].Value);

                    }

                    currentCalories += calories;

                }


            }

            currentCalories /= calPerDay;

            Console.WriteLine("You have food to last you for: {0} days!", currentCalories);

            if (currentRegex.IsMatch(text))
            {

                MatchCollection matches = currentRegex.Matches(text);

                foreach (Match items in matches)
                {

                    if (items.Groups[0].Value[0] == '#')
                    {
                        Console.WriteLine("Item: {0}, Best before: {1}, Nutrition: {2}", items.Groups["item"].Value, items.Groups["date"].Value, items.Groups["calories"].Value);
                    }

                    else
                    {
                        Console.WriteLine("Item: {0}, Best before: {1}, Nutrition: {2}", items.Groups["itemm"].Value, items.Groups["datee"].Value, items.Groups["caloriess"].Value);

                    }

                }


            }

        }
    }
}
