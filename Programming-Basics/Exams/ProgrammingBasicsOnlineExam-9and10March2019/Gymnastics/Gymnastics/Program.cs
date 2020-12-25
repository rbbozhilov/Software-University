using System;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string ured = Console.ReadLine();

            double mark = 0;

            switch (ured)
            {

                case "ribbon":
                    {


                        if (country == "Bulgaria")
                        {

                            mark = 9.600 + 9.400;


                        }


                        else if (country == "Russia")
                        {

                            mark = 9.100 + 9.400;
                        }

                        else if (country == "Italy")
                        {
                            mark = 9.200 + 9.500;
                        }


                        break;
                    }

                case "hoop":
                    {


                        if (country == "Bulgaria")
                        {

                            mark = 9.550 + 9.750;


                        }


                        else if (country == "Russia")
                        {

                            mark = 9.300 + 9.800;
                        }

                        else if (country == "Italy")
                        {
                            mark = 9.450 + 9.350;
                        }


                        break;
                    }



                case "rope":
                    {


                        if (country == "Bulgaria")
                        {

                            mark = 9.500 + 9.400;


                        }


                        else if (country == "Russia")
                        {

                            mark = 9.600 + 9.000;
                        }

                        else if (country == "Italy")
                        {
                            mark = 9.700 + 9.150;
                        }


                        break;
                    }




            }


            double percent = ((20 - mark) / 20) * 100;


            Console.WriteLine("The team of {3} get {0:F3} on {1}.\n{2:F2}%", mark, ured, percent, country);
        }
    }
}
