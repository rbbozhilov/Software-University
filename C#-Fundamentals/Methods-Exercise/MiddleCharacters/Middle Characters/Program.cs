using System;

namespace Middle_Characters
{
    class Program
    {
        static void CharsPrint(string text)
        {


            int length = text.Length;

            if (length % 2 == 0)
            {

                Console.Write(text[length / 2 - 1]);
                Console.WriteLine(text[length / 2]);

            }
            else
            {
                Console.WriteLine((char)text[length / 2]);
            }

        }


        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            CharsPrint(text);


        }
    }
}
