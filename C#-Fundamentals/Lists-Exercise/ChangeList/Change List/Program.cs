using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static int TakeElement(string text, int index)
        {
            string[] stringArray = text.Split();
            int number = int.Parse(stringArray[index]);
            return number;
        }

        static string TakeElement(string text)
        {
            string[] textArray = text.Split();
            string value = textArray[0];
            return value;
        }

        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            string text = string.Empty;


            while ((text = Console.ReadLine()) != "end")
            {

                string currentWord = TakeElement(text);

                if (currentWord == "Delete")
                {

                    int currentNumber = TakeElement(text, 1);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (currentNumber == numbers[i])
                        {
                            numbers.Remove(numbers[i]);
                        }
                    }




                    numbers.Remove(currentNumber);
                }
                else if (currentWord == "Insert")
                {

                    int currentIndex = TakeElement(text, 2);
                    int currentElement = TakeElement(text, 1);

                    numbers.Insert(currentIndex, currentElement);

                }

            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
