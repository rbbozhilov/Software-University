using System;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Func<string, bool> checker = Check;

            for (int i = 0; i < input.Length; i++)
            {

                if (checker(input[i]))
                {
                    Console.WriteLine(input[i]);
                }


            }

        }


        static bool Check(string currentWord)
        {

            if (currentWord[0] == currentWord.ToUpper()[0])
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

}


