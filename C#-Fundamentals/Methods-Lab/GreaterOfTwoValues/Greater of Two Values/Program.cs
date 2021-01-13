using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static int IntGreat()
        {

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }


        }

        static char CharGreat()
        {
            char firstNumber = char.Parse(Console.ReadLine());
            char secondNumber = char.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }

        }

        static string StringGreat()
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            int firstNum = 0;
            int secondNum = 0;

            for (int i = 0; i < firstNumber.Length; i++)
            {

                firstNum += (int)firstNumber[i];


            }
            for (int i = 0; i < secondNumber.Length; i++)
            {
                secondNum += (int)secondNumber[i];
            }

            if (firstNum > secondNum)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }


        }

        static void Print(string text)
        {

            switch (text)
            {
                case "int":
                    {
                        Console.WriteLine(IntGreat());
                        break;
                    }
                case "char":
                    {
                        Console.WriteLine(CharGreat());
                        break;
                    }
                case "string":
                    {
                        Console.WriteLine(StringGreat());
                        break;
                    }
            }


        }



        static void Main(string[] args)
        {


            string text = Console.ReadLine();

            Print(text);



        }
    }
}
