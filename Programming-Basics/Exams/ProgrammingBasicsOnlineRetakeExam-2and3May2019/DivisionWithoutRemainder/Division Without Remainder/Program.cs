using System;

namespace Division_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;


            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {


                int input = int.Parse(Console.ReadLine());

                if (input % 2 == 0)
                {
                    p1++;
                }
                if (input % 3 == 0)
                {
                    p2++;
                }
                if (input % 4 == 0)
                {
                    p3++;
                }


            }

            double percentP1 = 0;
            double percentp2 = 0;
            double percentp3 = 0;


            percentP1 = (double)p1 / (double)n;
            percentp2 = (double)p2 / (double)n;
            percentp3 = (double)p3 / (double)n;


            Console.WriteLine("{0:F2}%\n{1:F2}%\n{2:F2}%", percentP1 * 100, percentp2 * 100, percentp3 * 100);
        }
    }
}
