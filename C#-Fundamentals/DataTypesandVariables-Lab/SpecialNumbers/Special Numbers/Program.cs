using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            bool checker = false;
            int currentNumber = 0;
            int otherCurrentNumber = 0;
            for (int i = 1; i <= number; i++)
            {


                currentNumber = i;
                otherCurrentNumber = i;

                while (otherCurrentNumber != 0)
                {




                    otherCurrentNumber /= 10;

                    sum += currentNumber % 10;
                    currentNumber /= 10;

                }


                if (sum == 5)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else if (sum == 7)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else if (sum == 11)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }

                sum = 0;
            }
        }
    }
}
