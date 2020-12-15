using System;

namespace Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int max = 0;

            int min = 0;

            int k = int.Parse(Console.ReadLine());
            max = k;
            min = k;
            int t = 1;

            while (t < n)
            {

                t++;
                k = int.Parse(Console.ReadLine());
                if (k > max)
                {
                    max = k;

                }
                else if (k < min)
                {
                    min = k;
                }
            }


            Console.WriteLine("Max number: {0}\nMin number: {1}", max, min);
        }
    }
}
