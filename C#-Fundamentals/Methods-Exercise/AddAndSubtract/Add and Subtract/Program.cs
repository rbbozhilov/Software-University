using System;

namespace Add_and_Subtract
{
    class Program
    {
        static int SumDigits(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int Substract(int firstNumber, int secondNumber, int number)
        {
            return SumDigits(firstNumber, secondNumber) - number;
        }


        static void Main(string[] args)
        {

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Substract(firstNumber, secondNumber, thirdNumber));



        }
    }
}
