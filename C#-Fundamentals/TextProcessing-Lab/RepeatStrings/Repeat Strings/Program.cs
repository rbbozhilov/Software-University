using System;

namespace Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string result = string.Empty;

            for (int i = 0; i < tokens.Length; i++)
            {

                for (int j = 0; j < tokens[i].Length; j++)
                {
                    result += tokens[i];
                }


            }

            Console.WriteLine(result);
        }
    }
}
