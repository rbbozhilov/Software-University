using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace StackSum
{
    class StartUp
    {
        static void Main(string[] args)
        {


            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> sum = new Stack<int>();

            foreach (var items in numbers)
            {
                sum.Push(items);
            }

            string text = string.Empty;

            while ((text = Console.ReadLine().ToLower()) != "end")
            {

                string[] tokens = text.Split(" ").ToArray();
                string currentCommand = tokens[0];

                if (currentCommand == "add")
                {
                    sum.Push(int.Parse(tokens[1]));
                    sum.Push(int.Parse(tokens[2]));
                }

                else
                {

                    int counter = int.Parse(tokens[1]);

                    if (sum.Count >= counter)
                    {
                        while (counter != 0)
                        {
                            sum.Pop();
                            counter--;
                        }
                    }
                }


            }


            Console.WriteLine("Sum: {0}", sum.Sum());

        }
    }
}
