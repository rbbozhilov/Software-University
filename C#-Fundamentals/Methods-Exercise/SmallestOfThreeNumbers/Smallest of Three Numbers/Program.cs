using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static int SmallestNumber(int firstNum, int secondNum, int thirdNum)
        {


            int smallest = 0;

            if (firstNum < secondNum)
            {

                smallest = firstNum;

            }
            else
            {
                smallest = secondNum;
            }

            if (smallest < thirdNum)
            {
                return smallest;
            }
            else
            {
                return thirdNum;
            }

        }


        static void Main(string[] args)
        {


            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());


            Console.WriteLine(SmallestNumber(firstNumber, secondNumber, thirdNumber));


        }
    }
}
