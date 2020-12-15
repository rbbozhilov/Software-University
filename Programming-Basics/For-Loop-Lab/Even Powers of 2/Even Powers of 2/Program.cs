using System;

namespace Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());


            int result = 1;

            for (int i = 0; i <= k; i += 2)
            {

                Console.WriteLine(result);
                result *= 4;

            }
        }
    }
}
