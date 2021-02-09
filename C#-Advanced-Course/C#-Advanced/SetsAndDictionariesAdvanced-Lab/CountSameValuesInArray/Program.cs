using System;
using System.Linq;
using System.Collections.Generic;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {


            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var dictionary = new Dictionary<double, int>();

            for(int i=0;i<numbers.Length;i++)
            {

                if(!dictionary.ContainsKey(numbers[i]))
                {
                    dictionary.Add(numbers[i], 0);
                }

                dictionary[numbers[i]]++;

            }


            foreach(var items in dictionary)
            {

                Console.WriteLine("{0} - {1} times",items.Key,items.Value);


            }

        }
    }
}
