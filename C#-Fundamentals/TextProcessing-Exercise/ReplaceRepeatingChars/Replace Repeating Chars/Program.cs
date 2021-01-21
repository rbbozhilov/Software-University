using System;
using System.Text;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder stringer = new StringBuilder();


            for (int i = 0; i < input.Length - 1; i++)
            {

                if (input[i] != input[i + 1])
                {

                    stringer.Append(input[i]);

                }


                if (i == input.Length - 2 && input[i] == input[i + 1])
                {
                    stringer.Append(input[i]);
                }
                else if (i == input.Length - 2 && input[i] != input[i + 1])
                {
                    stringer.Append(input[i + 1]);
                }

            }


            Console.WriteLine(stringer);
        }
    }
}
