using System;

namespace Math_operations
{
    class Program
    {
        static double MathOperations(string choice, double firstNumber, double secondNumber)
        {

            double result = 0;
            switch (choice)
            {
                case "*":
                    {

                        result = firstNumber * secondNumber;

                        break;
                    }
                case "/":
                    {
                        result = firstNumber / secondNumber;
                        break;
                    }
                case "+":
                    {
                        result = firstNumber + secondNumber;
                        break;
                    }
                case "-":
                    {
                        result = firstNumber - secondNumber;
                        break;
                    }


            }


            return result;


        }

        static void Main(string[] args)
        {

            double firstNumber = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());


            Console.WriteLine("{0}", MathOperations(operation, firstNumber, secondNumber));


        }
    }
}
