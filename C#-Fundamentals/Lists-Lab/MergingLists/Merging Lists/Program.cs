using System;
using System.Linq;
using System.Collections.Generic;

namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = new List<int>();
            List<int> secondList = new List<int>();
            List<int> finalList = new List<int>();

            bool flag = true;
            firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int lengthFinalList = firstList.Count + secondList.Count;


            int minList = Math.Min(firstList.Count, secondList.Count);


            if (firstList.Count > secondList.Count)
            {
                flag = false;
            }
            int i = 0;
            for (i = 0; i < minList; i++)
            {

                finalList.Add(firstList[i]);
                finalList.Add(secondList[i]);
            }



            if (flag)
            {
                for (int k = i; i <= secondList.Count - 1; i++)
                {


                    finalList.Add(secondList[i]);
                }

            }
            else
            {
                for (int k = i; i <= firstList.Count - 1; i++)
                {


                    finalList.Add(firstList[i]);
                }



            }

            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
