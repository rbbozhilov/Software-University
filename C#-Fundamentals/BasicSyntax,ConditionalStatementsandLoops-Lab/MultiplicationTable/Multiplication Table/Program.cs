using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputIndex = int.Parse(Console.ReadLine());

            int counter = 1;

            for (int i = 0; i < 10; i++)
            {


                Console.WriteLine("{0} X {1} = {2}", inputIndex, counter, counter * inputIndex);
                counter++;


            }
        }
    }
}
