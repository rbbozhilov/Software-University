using System;

namespace Sum_Numberss
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;


            while (sum < number)
            {

                int next = int.Parse(Console.ReadLine());

                sum += next;

            }
            Console.WriteLine(sum);
        }
    }
}
