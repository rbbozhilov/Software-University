using System;

namespace Calculations
{
    class Program
    {
        static void Calculator(string choice, int firstNumber, int secondNumber)
        {

            double result = 0;

            switch (choice)
            {
                case "add":
                    {
                        result = (double)firstNumber + (double)secondNumber;
                        break;
                    }
                case "divide":
                    {
                        result = (double)firstNumber / (double)secondNumber;
                        break;
                    }
                case "subtract":
                    {
                        result = (double)firstNumber - (double)secondNumber;
                        break;
                    }
                case "multiply":
                    {
                        result = (double)firstNumber * (double)secondNumber;
                        break;
                    }
            }

            Console.WriteLine(result);


        }

        static void Main(string[] args)
        {


            string choice = Console.ReadLine();

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());


            Calculator(choice, firstNum, secondNum);


        }
    }
}
