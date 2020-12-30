using System;

namespace Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] array = text.Split();


            int[] numbers = new int[array.Length];


            int evenSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = int.Parse(array[i]);

                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }


            }

            Console.WriteLine(evenSum);
        }
    }
}
