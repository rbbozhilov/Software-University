using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Triagle(int input)
        {


            for (int i = 1; i <= input; i++)
            {


                for (int j = 1; j < i; j++)
                {

                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }




            for (int k = input; k >= 1; k--)
            {


                for (int d = 1; d <= k; d++)
                {
                    Console.Write(d + " ");
                }
                Console.WriteLine();

            }

        }

        static void Main(string[] args)
        {


            int input = int.Parse(Console.ReadLine());



            Triagle(input);


        }
    }
}
