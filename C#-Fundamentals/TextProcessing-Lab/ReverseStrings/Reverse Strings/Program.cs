using System;
using System.Linq;
using System.Text;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {

                char[] reversedString = input.Reverse().ToArray();

                Console.WriteLine("{0} = {1}", input, string.Join("", reversedString));

            }
        }
    }
}
