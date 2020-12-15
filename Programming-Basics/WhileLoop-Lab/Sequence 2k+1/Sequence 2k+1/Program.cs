using System;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int broach = 1;
            while (broach <= number)
            {
                Console.WriteLine(broach);
                broach = broach * 2 + 1;

            }
        }
    }
}
