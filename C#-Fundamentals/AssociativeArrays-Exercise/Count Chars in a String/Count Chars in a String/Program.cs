using System;
using System.Collections.Generic;


namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<char, int>();


            string[] text = Console.ReadLine().Split();

            for (int i = 0; i < text.Length; i++)
            {

                for (int j = 0; j < text[i].Length; j++)
                {

                    if (!dictionary.ContainsKey(text[i][j]))
                    {

                        dictionary.Add(text[i][j], 0);

                    }

                    dictionary[text[i][j]]++;

                }


            }


            foreach (var items in dictionary)
            {
                Console.WriteLine("{0} -> {1}", items.Key, items.Value);
            }

        }
    }
}
