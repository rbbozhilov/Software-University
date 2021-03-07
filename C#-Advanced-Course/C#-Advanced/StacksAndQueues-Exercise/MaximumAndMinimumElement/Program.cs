using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>();

            int numOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCommands; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split();

                int currentCommand = int.Parse(tokens[0]);

                if (currentCommand == 1)
                {
                    int currentElement = int.Parse(tokens[1]);
                    stack.Push(currentElement);
                }
                else if (currentCommand == 2)
                {
                    if (stack.Count > 0)
                    {

                        stack.Pop();

                    }

                }
                else if (currentCommand == 3)
                {
                    if (stack.Count > 0)
                    {

                        Console.WriteLine(stack.Max());

                    }
                }
                else if (currentCommand == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }

            }

            Console.WriteLine(string.Join(", ", stack));

        }
    }
}
