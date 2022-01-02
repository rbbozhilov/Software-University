using System;
using System.Threading;

namespace AllEvenNumbersInRangeUsingThread
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type start number =");
            long start = long.Parse(Console.ReadLine());

            Console.Write("Type end number =");
            long end = long.Parse(Console.ReadLine());

            Thread threadForEvenNumbers = new Thread(() => EvenNumbers(start, end));
            threadForEvenNumbers.Start();
            
            Console.WriteLine("Main method finished");
        }

        static void EvenNumbers(long start,long end)
        {

            for (long i = start; i <= end; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Thread finished");
        }


    }
}
