using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static string TakeElement(string text, int index)
        {

            string[] stringArray = text.Split();

            return stringArray[index];

        }

        static int TakeElement(int index, string text)
        {

            string[] stringArray = text.Split();

            int currentNumber = int.Parse(stringArray[index]);

            return currentNumber;


        }





        static void Main(string[] args)
        {


            List<int> vagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int capacity = int.Parse(Console.ReadLine());


            string text = string.Empty;


            while ((text = Console.ReadLine()) != "end")
            {

                string currentWord = TakeElement(text, 0);

                if (currentWord == "Add")
                {
                    int currentNumber = TakeElement(1, text);
                    vagons.Add(currentNumber);
                }
                else
                {
                    int currentNumber = int.Parse(text);

                    for (int i = 0; i < vagons.Count; i++)
                    {

                        if (vagons[i] + currentNumber <= capacity)
                        {
                            vagons[i] += currentNumber;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", vagons));
        }
    }
}
