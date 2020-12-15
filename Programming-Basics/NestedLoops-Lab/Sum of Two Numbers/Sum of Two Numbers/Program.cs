using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicnumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int broach = 0;
            int helper = 0;
            for (int i = start; i <= end; i++)
            {

                for (int j = start; j <= end; j++)
                {
                    broach++;
                    sum = i + j;
                    if (sum == magicnumber)
                    {
                        Console.WriteLine("Combination N:{3} ({0} + {1} = {2})", i, j, sum, broach);

                        System.Environment.Exit(1);

                    }

                }
            }

            Console.WriteLine("{0} combinations - neither equals {1}", broach, magicnumber);
        }
    }
}
