using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int boia = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int chasove = int.Parse(Console.ReadLine());


            double kolichestvoNailon = (double)(nailon + 2) * 1.50;

            double neobhodimoBoia = ((double)boia + ((double)boia * 0.1)) * 14.50;



            double razreditelNeobhodim = razreditel * 5;

            double finalSum = kolichestvoNailon + neobhodimoBoia + razreditelNeobhodim + 0.40;


            double payWorkers = (finalSum * 0.3) * chasove;

            double totalSum = finalSum + payWorkers;

            Console.WriteLine("Total expenses: {0:F2} lv.", totalSum);
        }
    }
}
