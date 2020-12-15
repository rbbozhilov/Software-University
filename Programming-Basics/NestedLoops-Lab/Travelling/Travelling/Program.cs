using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = null;


            double sum = 0;
            while (true)
            {

                text = Console.ReadLine();
                if (text == "End")
                {
                    break;
                }
                double budjet = double.Parse(Console.ReadLine());



                while (sum < budjet)
                {


                    double numbers = double.Parse(Console.ReadLine());

                    sum += numbers;




                }
                Console.WriteLine("Going to {0}!", text);

                sum = 0;
            }
        }
    }
}
