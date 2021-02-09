using System;
using System.Linq;
using System.Collections.Generic;


namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {


            var dictionary = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] tokens = Console.ReadLine().Split();
                string currentContinent = tokens[0];
                string currentCountry = tokens[1];
                string currentCity = tokens[2];

                if (!dictionary.ContainsKey(currentContinent))
                {

                    dictionary.Add(currentContinent, new Dictionary<string, List<string>>());
                    dictionary[currentContinent].Add(currentCountry, new List<string>());
                    dictionary[currentContinent][currentCountry].Add(currentCity);

                }

                else
                {

                    if (!dictionary[currentContinent].ContainsKey(currentCountry))
                    {
                        dictionary[currentContinent].Add(currentCountry, new List<string>());
                        dictionary[currentContinent][currentCountry].Add(currentCity);
                    }

                    else
                    {

                        if (!dictionary[currentContinent].ContainsKey(currentCountry))
                        {
                            dictionary[currentContinent].Add(currentCountry, new List<string>() { currentCity });

                        }
                        else
                        {
                            dictionary[currentContinent][currentCountry].Add(currentCity);
                        }
                    }

                }


            }


            foreach (var items in dictionary)
            {

                Console.WriteLine("{0}:", items.Key);

                foreach (var itens in items.Value)
                {

                    Console.Write("{0} -> ", itens.Key);
                    Console.WriteLine(string.Join(", ", itens.Value));

                }




            }

        }
    }
}
