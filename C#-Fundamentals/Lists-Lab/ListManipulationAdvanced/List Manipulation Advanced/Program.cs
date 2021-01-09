using System;
using System.Collections.Generic;
using System.Linq;


namespace List_Manipulation_Advanced
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

        static string TakeElemento(string text)
        {
            string[] textArray = text.Split();
            string value = textArray[1];
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

        static void EvenNumbers(List<int> numbers)
        {


            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

        }

        static void OddNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }

        static int GetSum(List<int> numbers)
        {

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        static bool ContainsElement(List<int> numbers, int element)
        {


            return numbers.Contains(element);

        }

        static void FilterMore(List<int> numbers, int start)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > start)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }

        static void FilterMoreAnd(List<int> numbers, int start)
        {
            for (int i = 0; i < numbers.Count; i++)
            {

                if (numbers[i] >= start)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }

        static void FilterLittle(List<int> numbers, int start)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < start)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }

        static void FilterLittleAnd(List<int> numbers, int start)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= start)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }

        static bool Same(List<int> numbers, int[] array)
        {
            bool flag = true;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != numbers[i])
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }


        static void Main(string[] args)
        {


            bool flagger = false;
            List<int> numbers = new List<int>();

            numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            int[] array = numbers.ToArray();



            string word = string.Empty;

            while ((word = Console.ReadLine()) != "end")
            {

                string currentWord = TakeElement(word);

                if (currentWord == "Add")
                {
                    flagger = true;
                    int currentNumber = TakeElement(word, 1);
                    AddElement(numbers, currentNumber);
                }

                else if (currentWord == "Remove")
                {
                    flagger = true;
                    int currentNumber = TakeElement(word, 1);
                    RemoveElement(numbers, currentNumber);
                }
                else if (currentWord == "RemoveAt")
                {
                    flagger = true;
                    int currentIndex = TakeElement(word, 1);
                    RemoveInIndex(numbers, currentIndex);
                }
                else if (currentWord == "Insert")
                {
                    flagger = true;
                    int currentIndex = TakeElement(word, 1);
                    int currentElement = TakeElement(word, 2);
                    InsertElement(numbers, currentIndex, currentElement);
                }


                else if (currentWord == "PrintEven")
                {


                    EvenNumbers(numbers);


                }

                else if (currentWord == "PrintOdd")
                {

                    OddNumbers(numbers);

                }


                else if (currentWord == "GetSum")
                {


                    Console.Write(GetSum(numbers));


                }

                else if (currentWord == "Contains")
                {

                    int currentElement = TakeElement(word, 1);
                    bool flag = ContainsElement(numbers, currentElement);

                    if (flag)
                    {
                        Console.Write("Yes");
                    }
                    else
                    {
                        Console.Write("No such number");
                    }


                }


                else if (currentWord == "Filter")
                {

                    string currentCondition = TakeElemento(word);
                    int start = TakeElement(word, 2);

                    if (currentCondition == ">")
                    {
                        FilterMore(numbers, start);
                    }
                    else if (currentCondition == ">=")
                    {
                        FilterMoreAnd(numbers, start);
                    }
                    else if (currentCondition == "<")
                    {
                        FilterLittle(numbers, start);
                    }
                    else if (currentCondition == "<=")
                    {
                        FilterLittleAnd(numbers, start);
                    }


                }

                Console.WriteLine();

            }

            if (flagger)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }


        }
    }
}
