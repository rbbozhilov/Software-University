using System;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] array = text.Split();


            for (int i = 0; i < array.Length / 2; i++)
            {

                var value = array[i];

                array[i] = array[array.Length - 1 - i];
                array[array.Length - i - 1] = value;

            }


            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
