using System;

namespace Factorial_Division
{
    class Program
    {
        static long Factorial(long number)
        {

            long result = 1;
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                for (int i = (int)number; i >= 1; i--)
                {
                    result *= i;
                }
                return result;
            }

        }

        static void Main(string[] args)
        {

            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", (double)Factorial(firstNumber) / (double)Factorial(secondNumber));


        }
    }
}
