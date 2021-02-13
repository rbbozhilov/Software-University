using System;
using System.Linq;
using System.Collections.Generic;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());

            for(int i=0;i<n;i++)
            {

                int currentNumber = int.Parse(Console.ReadLine());

                if(!numbers.ContainsKey(currentNumber))
                {
                    numbers[currentNumber] = 0;
                }

                numbers[currentNumber]++;

            
            }

            int searchedEvenNumber = 0;

            foreach(var items in numbers)
            {

                if(items.Value%2==0)
                {
                    searchedEvenNumber = items.Key;
                    Console.WriteLine(searchedEvenNumber);
                    break;
                }


            }


        }
    }
}
