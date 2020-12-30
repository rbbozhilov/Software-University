using System;

namespace Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[] array = new int[input];


            int length = array.Length;

            for (int i = 0; i < length; i++)
            {


                array[i] = int.Parse(Console.ReadLine());


            }

            for (int i = length - 1; i >= 0; i--)
            {


                Console.Write(array[i] + " ");
            }
        }
    }
}
