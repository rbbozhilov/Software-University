using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int duljina = int.Parse(Console.ReadLine());
            int shirok = int.Parse(Console.ReadLine());
            int visok = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            double obem = duljina * shirok * visok;
            double obshto = obem * 0.001;
            double procente = procent * 0.01;
            double litra = obshto * (1 - procente);
            Console.WriteLine(litra);
        }
    }
}
