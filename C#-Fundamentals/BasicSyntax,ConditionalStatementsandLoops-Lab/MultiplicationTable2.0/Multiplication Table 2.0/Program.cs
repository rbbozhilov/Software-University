using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputIndex = int.Parse(Console.ReadLine());
            int inputOtherIndex = int.Parse(Console.ReadLine());
            int counter = inputOtherIndex;

            for (int i = inputOtherIndex; i <= 10; i++)
            {


                Console.WriteLine("{0} X {1} = {2}", inputIndex, counter, counter * inputIndex);
                counter++;


            }
            if (inputOtherIndex > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", inputIndex, counter, counter * inputIndex);
            }
        }
    }
}
