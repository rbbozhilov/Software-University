using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int noshtuvki = int.Parse(Console.ReadLine());
            double sumstudio = 0;
            double sumapartment = 0;

            switch (month)
            {


                case "May":
                    {
                        sumstudio = 50 * noshtuvki;
                        sumapartment = 65 * noshtuvki;


                        if (noshtuvki > 14)
                        {
                            sumapartment -= sumapartment * 0.1;
                            sumstudio -= sumstudio * 0.3;
                        }
                        else if (noshtuvki > 7 && noshtuvki <= 14)
                        {
                            sumstudio -= sumstudio * 0.05;
                        }

                        break;
                    }
                case "June":
                    {

                        sumstudio = 75.20 * noshtuvki;
                        sumapartment = 68.70 * noshtuvki;


                        if (noshtuvki > 14)
                        {
                            sumapartment -= sumapartment * 0.1;
                            sumstudio -= sumstudio * 0.2;
                        }



                        break;
                    }
                case "July":
                    {

                        sumstudio = 76 * noshtuvki;
                        sumapartment = 77 * noshtuvki;

                        if (noshtuvki > 14)
                        {
                            sumapartment -= sumapartment * 0.1;

                        }



                        break;
                    }
                case "August":
                    {

                        sumstudio = 76 * noshtuvki;
                        sumapartment = 77 * noshtuvki;

                        if (noshtuvki > 14)
                        {
                            sumapartment -= sumapartment * 0.1;

                        }



                        break;
                    }
                case "September":
                    {


                        sumstudio = 75.20 * noshtuvki;
                        sumapartment = 68.70 * noshtuvki;


                        if (noshtuvki > 14)
                        {
                            sumapartment -= sumapartment * 0.1;
                            sumstudio -= sumstudio * 0.2;
                        }



                        break;
                    }
                case "October":
                    {

                        sumstudio = 50 * noshtuvki;
                        sumapartment = 65 * noshtuvki;


                        if (noshtuvki > 14)
                        {
                            sumapartment -= sumapartment * 0.1;
                            sumstudio -= sumstudio * 0.3;
                        }
                        else if (noshtuvki > 7 && noshtuvki <= 14)
                        {
                            sumstudio -= sumstudio * 0.05;
                        }


                        break;
                    }
            }

            Console.WriteLine("Apartment: {0:F2} lv.\nStudio: {1:F2} lv.", sumapartment, sumstudio);
        }
    }
}
