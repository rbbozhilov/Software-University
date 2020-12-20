using System;

namespace Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            if (a != "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Wrong password!");
            }
            else
            {
                Console.WriteLine("Welcome");
            }
        }
    }
}
