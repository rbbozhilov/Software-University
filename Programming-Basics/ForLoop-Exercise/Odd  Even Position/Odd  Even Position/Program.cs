using System;

namespace Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddsum = 0;
            double oddmax = double.MinValue;
            double oddmin = double.MaxValue;
            double evensum = 0;
            double evenmax = double.MinValue;
            double evenmin = double.MaxValue;


            for (int i = 1; i <= n; i++)
            {
                double currentnumber = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evensum += currentnumber;

                    if (currentnumber > evenmax)
                    {
                        evenmax = currentnumber;
                    }
                    if (currentnumber < evenmin)
                    {
                        evenmin = currentnumber;
                    }


                }
                else
                {
                    oddsum += currentnumber;

                    if (currentnumber > oddmax)
                    {
                        oddmax = currentnumber;
                    }
                    if (currentnumber < oddmin)
                    {
                        oddmin = currentnumber;
                    }
                }


            }


            Console.WriteLine("OddSum={0:f2},", oddsum);

            if (oddmin == double.MaxValue)
            {

                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine("OddMin={0:f2},", oddmin);
            }

            if (oddmax == double.MinValue)
            {

                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine("OddMax={0:f2},", oddmax);
            }

          
            Console.WriteLine("EvenSum={0:F2},", evensum);

            if (evenmin == double.MaxValue)
            {

                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine("EvenMin={0:f2},", evenmin);
            }
           

            if (evenmax == double.MinValue)
            {

                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax={0:f2}", evenmax);
            }
            
        }
    }
}
