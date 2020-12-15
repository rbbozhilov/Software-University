using System;

namespace Birthday_party
{
    class Program
    {
        static void Main(string[] args)
        {
            float naemnazalata = float.Parse(Console.ReadLine());

            float torta = naemnazalata * 20 / 100;

            float napitki = torta - (torta * 45 / 100);

            float animator = naemnazalata / 3;

            float sum = torta + napitki + animator + naemnazalata;
            Console.WriteLine(sum);
        }
    }
}
