using System;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            int[] example = new int[n * 2];
            int[] finalFirstArray = new int[n];
            int[] finalSecondArray = new int[n];
            bool firstFlag = false;
            bool secondFlag = false;


            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();


                string[] other = text.Split();


                firstArray[i] = int.Parse(other[0]);
                secondArray[i] = int.Parse(other[1]);



            }



            for (int i = 0; i < n; i++)
            {

                if (i % 2 == 0)
                {
                    firstFlag = true;
                    secondFlag = false;

                }
                else
                {
                    firstFlag = false;
                    secondFlag = true;
                }


                if (firstFlag)
                {
                    finalFirstArray[i] = firstArray[i];
                }
                else
                {
                    finalFirstArray[i] = secondArray[i];
                }


                if (!secondFlag)
                {
                    finalSecondArray[i] = secondArray[i];
                }
                else
                {
                    finalSecondArray[i] = firstArray[i];
                }


            }



            for (int i = 0; i < n; i++)
            {
                Console.Write(finalFirstArray[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(finalSecondArray[i] + " ");
            }
        }
    }
}
