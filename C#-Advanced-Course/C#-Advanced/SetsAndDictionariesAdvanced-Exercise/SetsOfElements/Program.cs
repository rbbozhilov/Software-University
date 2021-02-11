using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] lengthOfElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            List<int> finalSet = new List<int>();
            for(int i=0;i<lengthOfElements[0]+lengthOfElements[1];i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(i<lengthOfElements[0])
                {
                    firstSet.Add(number);
                }
                else
                {
                    secondSet.Add(number);
                }


            }

            SameValues(finalSet, firstSet, secondSet);

            Console.WriteLine(string.Join(" ", finalSet));


        }


        static void SameValues(List<int> resultSet ,HashSet<int> firstSet,HashSet<int> secondSet)
        {

                foreach(var items in firstSet)
                {

                    int currentNumber = items;
                    if(secondSet.Contains(currentNumber))
                    {
                        resultSet.Add(currentNumber);
                    }

                }
        }

    }
}
