using System;

namespace Cinema
{
    class Program
    {
        static float retur(double a)
        {

            return (float)a;
        }

        static void Main(string[] args)
        {

            string type = Console.ReadLine();
            int red = int.Parse(Console.ReadLine());
            int kolona = int.Parse(Console.ReadLine());

            float sum = 0;

            if (type == "Normal")
            {

                sum = red * kolona * retur(7.50);
                Console.WriteLine("{0:F2} leva", sum);

            }
            else if (type == "Premiere")
            {

                sum = red * kolona * retur(12.00);
                Console.WriteLine("{0:F2} leva", sum);

            }
            else if (type == "Discount")
            {
                sum = red * kolona * retur(5.00);
                Console.WriteLine("{0:F2} leva", sum);
            }

        }
    }
}
