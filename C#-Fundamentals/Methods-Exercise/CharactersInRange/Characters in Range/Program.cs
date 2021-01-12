using System;

namespace Characters_in_Range
{
    class Program
    {
        static void CharactersBetween(char firtChar, char secondChar)
        {

            bool flag = false;
            if (firtChar < secondChar)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            if (flag)
            {
                for (int i = firtChar + 1; i < secondChar; i++)
                {

                    Console.Write((char)i + " ");

                }

            }
            else
            {

                for (int i = secondChar + 1; i < firtChar; i++)
                {
                    Console.Write((char)i + " ");
                }

            }
        }

        static void Main(string[] args)
        {


            char A = char.Parse(Console.ReadLine());
            char B = char.Parse(Console.ReadLine());

            CharactersBetween(A, B);


        }
    }
}
