using System;

namespace Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char v = char.Parse(Console.ReadLine());


            char a1 = v;
            char b1 = b;
            char c1 = a;


            Console.WriteLine("{0} {1} {2}", a1, b1, c1);
        }
    }
}
