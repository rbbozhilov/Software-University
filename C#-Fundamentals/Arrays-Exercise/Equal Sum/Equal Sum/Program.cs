using System;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int leftSum = 0;
            int rightSum = 0;
            string text = Console.ReadLine();
            string[] arrayText = text.Split();

            int[] integerArray = new int[arrayText.Length];

            int length = integerArray.Length;
            int currentIndex = 0;
            bool flag = true;


            for (int i = 0; i < length; i++)
            {


                integerArray[i] = int.Parse(arrayText[i]);


            }


            for (int i = 0; i < length; i++)
            {


                for (int k = i; k > 0; k--)
                {


                    leftSum += integerArray[i - k];


                }

                for (int j = i; j < length - 1; j++)
                {

                    rightSum += integerArray[j + 1];

                }

                if (rightSum == leftSum)
                {
                    currentIndex = i;
                    flag = true;
                    break;
                }

                else
                {
                    flag = false;
                    leftSum = 0;
                    rightSum = 0;
                }

            }


            if (length > 1)
            {
                if (flag)
                {
                    Console.WriteLine(currentIndex);
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
