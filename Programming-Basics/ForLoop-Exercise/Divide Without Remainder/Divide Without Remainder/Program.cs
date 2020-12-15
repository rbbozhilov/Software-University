using System;

namespace Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, p3 = 0;
            double p1broi = 0;
            double p2broi = 0;
            double p3broi = 0;


            int numbers = int.Parse(Console.ReadLine());
            int[] k = new int[numbers];

            for (int i = 0; i < numbers; i++)
            {

                k[i] = int.Parse(Console.ReadLine());

                if (k[i] % 2 == 0)
                {
                    p1broi++;


                }



            }
            for (int i = 0; i < numbers; i++)
            {

                if (k[i] % 3 == 0)
                {
                    p2broi++;
                }

            }

            for (int i = 0; i < numbers; i++)
            {
                if (k[i] % 4 == 0)
                {
                    p3broi++;
                }
            }

            p1 = (p1broi / numbers) * 100;
            p2 = (p2broi / numbers) * 100;
            p3 = (p3broi / numbers) * 100;


            Console.WriteLine("{0:F2}%\n{1:F2}%\n{2:F2}%", p1, p2, p3);
        }
    }
}
