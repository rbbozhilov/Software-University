using System;

namespace Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string other = Console.ReadLine();


            Console.WriteLine("{0}{1}{2}", firstName, other, lastName);
        }
    }
}
