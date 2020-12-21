using System;

namespace Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());
            string karta = Console.ReadLine();


            double benzin = 2.22;
            double dizel = 2.33;
            double gaz = 0.93;
            double obshtasuma = 0;

            if (karta == "Yes")
            {

                double benzinotstupka = 0.18 * liters;
                double gazotstupka = 0.8 * liters;
                double dieselotstupka = 0.12 * liters;


                if ((liters >= 20 && liters <= 25))
                {
                    if (fuel == "Diesel")
                    {
                        obshtasuma = (dizel - 0.12) * liters;
                        obshtasuma = obshtasuma - (obshtasuma * 0.08);
                    }
                    else if (fuel == "Gas")
                    {
                        obshtasuma = (gaz - 0.08) * liters;
                        obshtasuma = obshtasuma - (obshtasuma * 0.08);
                    }
                    else if (fuel == "Gasoline")
                    {
                        obshtasuma = (benzin - 0.18) * liters;
                        obshtasuma = obshtasuma - (obshtasuma * 0.08);
                    }

                }
                else if (liters > 25)
                {
                    if (fuel == "Diesel")
                    {
                        obshtasuma = (dizel - 0.12) * liters;
                        obshtasuma = obshtasuma - (obshtasuma * 0.1);
                    }
                    else if (fuel == "Gas")
                    {
                        obshtasuma = (gaz - 0.08) * liters;
                        obshtasuma = obshtasuma - (obshtasuma * 0.1);
                    }
                    else if (fuel == "Gasoline")
                    {
                        obshtasuma = (benzin - 0.18) * liters;
                        obshtasuma = obshtasuma - (obshtasuma * 0.1);
                    }

                }
                else if (liters < 20)
                {
                    if (fuel == "Diesel")
                    {
                        obshtasuma = (dizel - 0.12) * liters;

                    }
                    else if (fuel == "Gas")
                    {
                        obshtasuma = (gaz - 0.08) * liters;

                    }
                    else if (fuel == "Gasoline")
                    {
                        obshtasuma = (benzin - 0.18) * liters;

                    }
                }
            }

            else if (karta == "No")
            {
                if ((liters >= 20 && liters <= 25))
                {
                    if (fuel == "Diesel")
                    {
                        obshtasuma = dizel * liters;
                        obshtasuma = obshtasuma - (obshtasuma * 0.08);
                    }
                    else if (fuel == "Gas")
                    {
                        obshtasuma = gaz * liters;
                        obshtasuma = obshtasuma - (obshtasuma * 0.08);
                    }
                    else if (fuel == "Gasoline")
                    {
                        obshtasuma = benzin * liters;
                        obshtasuma = obshtasuma - (obshtasuma * 0.08);
                    }

                }
                else if (liters > 25)
                {
                    if (fuel == "Diesel")
                    {
                        obshtasuma = dizel * liters;
                        obshtasuma = obshtasuma - (obshtasuma * 0.1);
                    }
                    else if (fuel == "Gas")
                    {
                        obshtasuma = gaz * liters;
                        obshtasuma = obshtasuma - (obshtasuma * 0.1);
                    }
                    else if (fuel == "Gasoline")
                    {
                        obshtasuma = benzin * liters;
                        obshtasuma = obshtasuma - (obshtasuma * 0.1);
                    }


                }

                else if (liters < 20)
                {
                    if (fuel == "Diesel")
                    {
                        obshtasuma = dizel * liters;

                    }
                    else if (fuel == "Gas")
                    {
                        obshtasuma = gaz * liters;

                    }
                    else if (fuel == "Gasoline")
                    {
                        obshtasuma = benzin * liters;

                    }
                }

            }


            Console.WriteLine("{0:F2} lv.", obshtasuma);
        }
    }
}
