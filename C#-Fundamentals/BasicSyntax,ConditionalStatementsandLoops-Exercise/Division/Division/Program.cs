using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int maxValue = Int32.MinValue;
            int counter = 0;
            int[] arr = { 2, 3, 6, 7, 10 };



            for (int i = 0; i < 5; i++)
            {

                if (number % arr[i] == 0)
                {
                    maxValue = arr[i];
                    counter++;
                }

            }


            if (counter != 0)
            {

                Console.WriteLine("The number is divisible by {0}", maxValue);

            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
