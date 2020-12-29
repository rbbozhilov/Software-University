using System;

namespace Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] arrayText = text.Split();

            int length = arrayText.Length;

            int[] array = new int[length];


            for (int i = 0; i < length; i++)
            {


                array[i] = int.Parse(arrayText[i]);

            }



            int wantedSum = int.Parse(Console.ReadLine());

            int currentSum = 0;


            for (int i = 0; i < length; i++)
            {


                for (int j = i; j < length - 1; j++)
                {


                    currentSum = array[i] + array[j + 1];

                    if (currentSum == wantedSum)
                    {
                        Console.Write(array[i] + " " + array[j + 1]);
                        Console.WriteLine();
                    }


                }


            }
        }
    }
}
