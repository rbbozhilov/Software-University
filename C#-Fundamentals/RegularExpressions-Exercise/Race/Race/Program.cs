using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var racers = new Dictionary<string, int>();

            string input = Console.ReadLine();

            List<string> names = new List<string>();
            names = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();


            foreach (var items in names)
            {
                racers.Add(items, 0);
            }


            string text = string.Empty;

            while ((text = Console.ReadLine()) != "end of race")
            {

                StringBuilder currentName = new StringBuilder();
                int currentNumber = 0;


                foreach (var items in text)
                {

                    if (char.IsLetter(items))
                    {
                        currentName.Append(items);
                    }
                    else if (char.IsDigit(items))
                    {
                        currentNumber += int.Parse(items.ToString());
                    }

                }

                if (racers.ContainsKey(currentName.ToString()))
                {
                    racers[currentName.ToString()] += currentNumber;
                }
            }


            racers = racers.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, v => v.Value);

            int counter = 0;
            foreach (var items in racers)
            {
                counter++;

                if (counter == 1 && items.Value != 0)
                {
                    Console.WriteLine("1st place: {0}", items.Key);
                }
                else if (counter == 2 && items.Value != 0)
                {
                    Console.WriteLine("2nd place: {0}", items.Key);
                }
                else if (counter == 3 && items.Value != 0)
                {
                    Console.WriteLine("3rd place: {0}", items.Key);
                    break;
                }
            }
        }
    }
}
