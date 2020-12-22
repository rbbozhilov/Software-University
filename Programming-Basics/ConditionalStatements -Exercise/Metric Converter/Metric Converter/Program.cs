using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            float number = float.Parse(Console.ReadLine());
            string merna1 = Console.ReadLine();
            string merna2 = Console.ReadLine();

            if (merna1 == "m" && merna2 == "mm")
            {
                number *= 1000;
                Console.WriteLine("{0:F3}", number);
            }
            else if (merna1 == "mm" && merna2 == "m")
            {
                number /= 1000;
                Console.WriteLine("{0:F3}", number);
            }

            else if (merna1 == "m" && merna2 == "cm")
            {
                number *= 100;
                Console.WriteLine("{0:F3}", number);
            }
            else if (merna1 == "cm" && merna2 == "m")
            {
                number /= 100;
                Console.WriteLine("{0:F3}", number);
            }
            else if (merna1 == "cm" && merna2 == "mm")
            {
                number *= 10;
                Console.WriteLine("{0:F3}", number);
            }
            else if (merna1 == "mm" && merna2 == "cm")
            {
                number /= 10;
                Console.WriteLine("{0:F3}", number);
            }
        }
    }
}
