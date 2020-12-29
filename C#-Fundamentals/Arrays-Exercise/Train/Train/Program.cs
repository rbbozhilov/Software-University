using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {

                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];

            }

            for (int i = 0; i < array.Length; i++)
            {

                Console.Write(array[i] + " ");

            }

            Console.WriteLine("\n{0}", sum);
        }
    }
}
