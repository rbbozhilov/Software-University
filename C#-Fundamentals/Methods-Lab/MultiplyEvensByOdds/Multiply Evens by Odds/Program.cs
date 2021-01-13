using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void GetMultipleOfEvenAndOdds(int[] even, int[] odd, int number)
        {

            int currentNumber = 0;
            int countEven = 0;
            int countOdd = 0;
            while (number != 0)
            {

                currentNumber = number;
                currentNumber %= 10;

                if (currentNumber % 2 == 0)
                {
                    even[countEven] = currentNumber;
                    countEven++;

                }
                else if (currentNumber % 2 == 1)
                {
                    odd[countOdd] = currentNumber;
                    countOdd++;
                }

                number /= 10;

            }


        }


        static int GetSumOfEvenDigits(int[] even, int[] odd)
        {



            int sum = 0;

            for (int i = 0; i < even.Length; i++)
            {

                sum += even[i];
            }


            return sum;
        }

        static int GetSumOfOddDigits(int[] even, int[] odd)
        {



            int sum = 0;

            for (int i = 0; i < odd.Length; i++)
            {

                sum += odd[i];
            }


            return sum;

        }

        static void Main(string[] args)
        {


            string text = Console.ReadLine();

            int number = int.Parse(text);
            if (number < 0)
            {
                number = Math.Abs(number);
            }




            int[] even = new int[text.Length];
            int[] odd = new int[text.Length];


            GetMultipleOfEvenAndOdds(even, odd, number);



            Console.WriteLine(GetSumOfEvenDigits(even, odd) * GetSumOfOddDigits(even, odd));


        }
    }
}
