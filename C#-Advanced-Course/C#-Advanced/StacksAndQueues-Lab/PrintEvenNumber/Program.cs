using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumber
{
  public  class StartUp
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> evenNumber = new Queue<int>(numbers);
            List<int> even = new List<int>();
            int count = evenNumber.Count;

            for (int i = 0; i < count; i++)
            {
                if (evenNumber.Peek() % 2 == 0)
                {

                    even.Add(evenNumber.Dequeue());

                }
                else
                {
                    evenNumber.Dequeue();
                }
            }


            Console.WriteLine(string.Join(", ", even));

        }
    }
}
