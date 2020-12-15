using System;

namespace Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string print = Console.ReadLine();
            while (print != "Stop")
            {
                Console.WriteLine(print);
                print = Console.ReadLine();
            }
        }
    }
}
