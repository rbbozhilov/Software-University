using System;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int dni = int.Parse(Console.ReadLine());
            int sladkari = int.Parse(Console.ReadLine());
            int torti = int.Parse(Console.ReadLine());
            float torta;
            double gofr;
            double pala;
            int gofreti = int.Parse(Console.ReadLine());
            int palach = int.Parse(Console.ReadLine());

            double subranipari;

            torta = torti * 45;
            gofr = gofreti * 5.80;
            pala = palach * 3.20;
            double obshtasuma = (torta + gofr + pala) * sladkari;
            double cel = obshtasuma * dni;
            subranipari = cel - cel / 8;
            Console.WriteLine(subranipari);
        }
    }
}
