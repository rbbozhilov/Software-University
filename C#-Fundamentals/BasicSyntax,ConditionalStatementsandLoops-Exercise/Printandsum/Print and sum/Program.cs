using System;

namespace Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {


                if (i == end)
                {
                    Console.WriteLine(i);
                    sum += i;
                    break;
                }

                Console.Write(i + " ");

                sum += i;

            }


            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
