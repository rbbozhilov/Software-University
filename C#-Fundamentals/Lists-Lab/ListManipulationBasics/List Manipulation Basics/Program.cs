using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Basics
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


        static void AddElement(List<int> adder, int number)
        {
            adder.Add(number);
        }

        static void RemoveElement(List<int> remover, int number)
        {
            remover.Remove(number);
        }

        static void RemoveInIndex(List<int> removerIndex, int index)
        {
            removerIndex.RemoveAt(index);
        }


        static void InsertElement(List<int> insert, int element, int index)
        {
            insert.Insert(index, element);
        }

        static void Main(string[] args)
        {



            List<int> numbers = new List<int>();

            numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            string word = string.Empty;

            while ((word = Console.ReadLine()) != "end")
            {

                string currentWord = TakeElement(word);

                if (currentWord == "Add")
                {
                    int currentNumber = TakeElement(word, 1);
                    AddElement(numbers, currentNumber);
                }

                else if (currentWord == "Remove")
                {
                    int currentNumber = TakeElement(word, 1);
                    RemoveElement(numbers, currentNumber);
                }
                else if (currentWord == "RemoveAt")
                {
                    int currentIndex = TakeElement(word, 1);
                    RemoveInIndex(numbers, currentIndex);
                }
                else if (currentWord == "Insert")
                {
                    int currentIndex = TakeElement(word, 1);
                    int currentElement = TakeElement(word, 2);
                    InsertElement(numbers, currentIndex, currentElement);
                }
            }




            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}
