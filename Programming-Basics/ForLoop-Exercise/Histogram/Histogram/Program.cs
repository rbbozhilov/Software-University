using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, p3, p4, p5 = 0;
            double p1broi = 0;
            double p2broi = 0;
            double p3broi = 0;
            double p4broi = 0;
            double p5broi = 0;

            int numbers = int.Parse(Console.ReadLine());


            for (int i = 0; i < numbers; i++)
            {

                int k = int.Parse(Console.ReadLine());

                if (k < 200)
                {
                    p1broi++;


                }
                else if (k >= 200 && k <= 399)
                {
                    p2broi++;
                }
                else if (k > 399 && k <= 599)
                {
                    p3broi++;
                }
                else if (k > 599 && k <= 799)
                {
                    p4broi++;
                }
                else if (k >= 800)
                {
                    p5broi++;
                }

            }


            p1 = (p1broi / numbers) * 100;
            p2 = (p2broi / numbers) * 100;
            p3 = (p3broi / numbers) * 100;
            p4 = (p4broi / numbers) * 100;
            p5 = (p5broi / numbers) * 100;

            Console.WriteLine("{0:F2}%\n{1:F2}%\n{2:F2}%\n{3:F2}%\n{4:F2}%", p1, p2, p3, p4, p5);
        }
    }
}
