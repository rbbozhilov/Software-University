using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    class StartUp
    {
        static void Main(string[] args)
        {


            string[] text = Console.ReadLine().Split();
            text = text.Reverse().ToArray();
            Stack<string> calculate = new Stack<string>(text);

            while (calculate.Count != 1)
            {
                int currentNumber = int.Parse(calculate.Pop());
                string operation = calculate.Pop();
                int secondNumber = int.Parse(calculate.Pop());

                if (operation == "+")
                {
                    calculate.Push((currentNumber + secondNumber).ToString());
                }

                else if (operation == "-")
                {
                    calculate.Push((currentNumber - secondNumber).ToString());
                }



            }

            Console.WriteLine(calculate.Pop());

        }
    }
}
