using System;

namespace Strong_number
{
    class Program
    {
        static int Factorial(int n)
        {

            int sum = 0;
            for (int i = n; i >= 1; i--)
            {

                sum *= i;
                if (n == i)
                {
                    sum = n;
                }
            }

            if (n == 0)
            {
                sum = 1;
            }

            return sum;
        }


        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int finalSum = 0;
            int value = 0;
            int i = number;
            int result = number;

            while (i != 0)
            {

                result %= 10;

                value = result;
                i /= 10;
                result = i;
                finalSum += Factorial(value);

            }

            if (finalSum == number)
            {
                Console.WriteLine("yes");

            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
