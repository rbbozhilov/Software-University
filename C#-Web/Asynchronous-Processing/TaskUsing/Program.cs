using System;
using System.Threading.Tasks;

namespace SomeAsyncMethods
{
   public class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => CounterOfPrimeNumbers(5000000));

            while (true)
            {
                string someText = Console.ReadLine();
                Console.WriteLine(someText.ToUpper());
            }

        }

        static void CounterOfPrimeNumbers(int number)
        {

            int count = 0;

            for (int i = 1; i <= number; i++)
            {

                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if( i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if(isPrime == true)
                {
                    count++;
                }


            }

            Console.WriteLine(count);

        }
        

    }
}
