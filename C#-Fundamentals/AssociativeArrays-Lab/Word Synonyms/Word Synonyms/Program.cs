using System;
using System.Collections.Generic;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentWord = Console.ReadLine();
                string currentSynonym = Console.ReadLine();

                if (!dictionary.ContainsKey(currentWord))
                {

                    dictionary.Add(currentWord, new List<string>());

                }

                dictionary[currentWord].Add(currentSynonym);

            }


            foreach (var items in dictionary)
            {

                Console.Write("{0} - ", items.Key);

                Console.WriteLine(string.Join(", ", items.Value));

            }
        }
    }
}
