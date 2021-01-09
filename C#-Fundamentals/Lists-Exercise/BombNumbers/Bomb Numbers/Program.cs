using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();


            int[] array = text.Split().Select(int.Parse).ToArray();

            string[] other = Console.ReadLine().Split();


            int power = int.Parse(other[0]);
            int numbers = int.Parse(other[1]);


            for (int i = 0; i < array.Length; i++)
            {


                if (array[i] == power)
                {

                    int start = Math.Max(0, i - numbers);
                    int end = Math.Min(array.Length - 1, i + numbers);


                    for (int j = i; j <= end; j++)
                    {
                        array[j] = 0;
                    }


                    for (int k = start; k < i; k++)
                    {
                        array[k] = 0;
                    }


                }


            }


            Console.WriteLine(array.Sum());

        }
    }
}
