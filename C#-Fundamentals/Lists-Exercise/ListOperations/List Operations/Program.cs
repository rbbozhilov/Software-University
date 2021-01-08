using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
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

            int value = int.Parse(stringArray[index]);

            return value;
        }

        static double TakeElementDouble(int index, string text)
        {

            string[] stringArray = text.Split();

            double value = double.Parse(stringArray[index]);

            return value;
        }


        static void AddNumber(List<double> numbers, double element)
        {
            numbers.Add(element);
        }


        static void Insert(List<double> numbers, double element, int index)
        {
            numbers.Insert(index, element);
        }


        static void RemoveAt(List<double> numbers, int index)
        {
            numbers.RemoveAt(index);
        }


        static void ShiftLeft(List<double> numbers, int times)
        {


            for (int i = 0; i < times; i++)
            {

                double keeper = numbers[0];

                for (int j = 0; j < numbers.Count - 1; j++)
                {

                    numbers[j] = numbers[j + 1];


                }

                numbers[numbers.Count - 1] = keeper;
            }


        }



        static void ShiftRight(List<double> numbers, int times)
        {

            for (int i = 0; i < times; i++)
            {

                double keeper = numbers[numbers.Count - 1];

                for (int j = 0; j < numbers.Count - 1; j++)
                {

                    numbers[numbers.Count - j - 1] = numbers[numbers.Count - j - 2];


                }

                numbers[0] = keeper;
            }

        }

        static void Main(string[] args)
        {



            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();


            string text = string.Empty;


            while ((text = Console.ReadLine()) != "End")
            {

                string currentWord = TakeElement(text, 0);


                switch (currentWord)
                {

                    case "Add":
                        {
                            double currentNumber = TakeElement(1, text);
                            AddNumber(numbers, currentNumber);
                            break;
                        }
                    case "Remove":
                        {
                            int currentNumber = TakeElement(1, text);

                            if (currentNumber >= numbers.Count || currentNumber < 0)
                            {
                                Console.WriteLine("Invalid index");
                            }
                            else
                            {
                                RemoveAt(numbers, currentNumber);
                            }
                            break;
                        }
                    case "Shift":
                        {
                            string secondWord = TakeElement(text, 1);
                            int currentNumber = TakeElement(2, text);

                            if (secondWord == "left")
                            {
                                ShiftLeft(numbers, currentNumber);

                            }
                            else if (secondWord == "right")
                            {
                                ShiftRight(numbers, currentNumber);
                            }

                            break;
                        }
                    case "Insert":
                        {

                            int currentIndex = TakeElement(2, text);


                            if (currentIndex >= numbers.Count || currentIndex < 0)
                            {
                                Console.WriteLine("Invalid index");
                            }
                            else
                            {
                                double currentElement = TakeElement(1, text);
                                Insert(numbers, currentElement, currentIndex);
                            }

                            break;
                        }

                }

            }


            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
