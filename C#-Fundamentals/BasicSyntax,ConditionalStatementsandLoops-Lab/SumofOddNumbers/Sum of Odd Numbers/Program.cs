using System;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputIndex = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int counterOdd = 1;
            for (int i = 0; i < inputIndex; i++)
            {


                Console.WriteLine(counterOdd);


                sumOdd += counterOdd;
                counterOdd += 2;
            }

            Console.WriteLine("Sum: " + sumOdd);
        }
    }
}
