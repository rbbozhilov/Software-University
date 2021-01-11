using System;

namespace Vowels_Count
{
    class Program
    {
        static int VowelsCount(string text)
        {

            int count = 0;


            for (int i = 0; i < text.Length; i++)
            {

                char currentLetter = text[i];
                if (currentLetter == 'O' || currentLetter == 'o' || currentLetter == 'U' || currentLetter == 'u' || currentLetter == 'e' || currentLetter == 'E' || currentLetter == 'i' || currentLetter == 'I' || currentLetter == 'a' || currentLetter == 'A' || currentLetter == 'y' || currentLetter == 'Y')
                {
                    count++;
                }


            }

            return count;
        }


        static void Main(string[] args)
        {


            string text = Console.ReadLine();


            Console.WriteLine(VowelsCount(text));


        }
    }
}
