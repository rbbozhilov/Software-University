using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> characters = new List<char>();
            List<char> numbers = new List<char>();
            List<char> others = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {

                if (char.IsDigit(input[i]))
                {

                    numbers.Add(input[i]);
                }

                else if (char.IsLetter(input[i]))
                {
                    characters.Add(input[i]);
                }

                else
                {
                    others.Add(input[i]);
                }

            }


            Console.WriteLine("{0}\n{1}\n{2}", string.Join("", numbers), string.Join("", characters), string.Join("", others));
        }
    }
}
