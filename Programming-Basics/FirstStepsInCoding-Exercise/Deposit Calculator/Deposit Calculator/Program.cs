using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float depoziran = float.Parse(Console.ReadLine());
            int srok = int.Parse(Console.ReadLine());
            float godishenlih = float.Parse(Console.ReadLine());

            float natrupanasuma = depoziran * godishenlih / 100;
            float lixvaedin = natrupanasuma / 12;

            Console.WriteLine(depoziran + ((srok) * lixvaedin));
        }
    }
}
