using System;

namespace Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            string character = Console.ReadLine();


            int asciiCode = (int)character[0];



            if (asciiCode >= 65 && asciiCode <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if (asciiCode >= 97 && asciiCode <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
