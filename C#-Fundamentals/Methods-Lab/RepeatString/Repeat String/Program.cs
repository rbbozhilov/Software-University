using System;

namespace Repeat_String
{
    class Program
    {
        static string RepeatString(string text, int number)
        {

            string newString = string.Empty;

            for (int i = 0; i < number; i++)
            {

                newString += text;

            }


            return newString;

        }




        static void Main(string[] args)
        {


            string text = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(text, number));


        }
    }
}
