using System;

namespace Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string put = Console.ReadLine();

            int length = put.Length;

            for (int i = 0; i < length; i++)
            {

                Console.WriteLine(put[i]);
            }
        }
    }
}
