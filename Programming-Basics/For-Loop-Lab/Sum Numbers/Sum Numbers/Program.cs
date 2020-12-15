using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {

                k = int.Parse(Console.ReadLine());
                sum += k;


            }

            Console.WriteLine(sum);
        }
    }
}
