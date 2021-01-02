using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var dic = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {

                if (!dic.ContainsKey(numbers[i]))
                {
                    dic.Add(numbers[i], 0);
                }

                dic[numbers[i]]++;

            }

            dic = dic.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var items in dic)
            {
                Console.WriteLine("{0} -> {1}", items.Key, items.Value);
            }
        }
    }
}
