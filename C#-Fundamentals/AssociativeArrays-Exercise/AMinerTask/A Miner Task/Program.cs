using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, int>();

            string currentInput = string.Empty;
            string input = string.Empty;
            int counter = 1;


            while ((input = Console.ReadLine()) != "stop")
            {


                if (counter % 2 == 1)
                {
                    currentInput = input;
                    if (!dictionary.ContainsKey(input))
                    {
                        dictionary.Add(input, 0);
                    }

                }

                else
                {

                    dictionary[currentInput] += int.Parse(input);


                }

                counter++;
            }


            foreach (var items in dictionary)
            {
                Console.WriteLine("{0} -> {1}", items.Key, items.Value);
            }
        }
    }
}
