using System;

namespace Top_Number
{
    class Program
    {
        static bool SumOfDigits(int number)
        {

            int sum = 0;
            int currentNumber = 0;
            bool flag = false;
            int count = 0;
            while (number != 0)
            {

                currentNumber = number;
                currentNumber %= 10;
                if (currentNumber % 2 == 1)
                {
                    count++;

                }
                sum += currentNumber;
                number /= 10;

            }

            if ((sum % 8 == 0 || sum % 16 == 0 || sum % 88 == 0) && count > 0)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {

                if (SumOfDigits(i))
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
