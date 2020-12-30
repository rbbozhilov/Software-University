using System;

namespace Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            string[] stringArray = input.Split();

            int[] integerArray = new int[stringArray.Length];

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < integerArray.Length; i++)
            {

                integerArray[i] = int.Parse(stringArray[i]);


                if (integerArray[i] % 2 == 0)
                {
                    evenSum += integerArray[i];
                }
                else
                {
                    oddSum += integerArray[i];
                }


            }

            Console.WriteLine(evenSum - oddSum);
        }
    }
}
