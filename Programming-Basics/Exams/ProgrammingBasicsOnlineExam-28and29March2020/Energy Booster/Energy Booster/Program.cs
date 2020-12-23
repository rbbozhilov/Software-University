using System;

namespace Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string plod = Console.ReadLine();
            string razmer = Console.ReadLine();
            int broiporuchani = int.Parse(Console.ReadLine());
            double smalldinia = 2 * 56;
            double smallananas = 2 * 42.10;
            double smallmango = 2 * 36.66;
            double smallmalina = 2 * 20;
            double bigdina = 5 * 28.70;
            double bigmango = 5 * 19.60;
            double bigananas = 5 * 24.80;
            double bigmalina = 5 * 15.20;
            double sum = 0;
            switch (plod)
            {

                case "Mango":
                    {

                        if (razmer == "small")
                        {
                            sum = broiporuchani * smallmango;


                            if (sum >= 400 && sum <= 1000)
                            {
                                sum = sum - (sum * 0.15);
                            }
                            else if (sum > 1000)
                            {
                                sum = sum - (sum * 0.5);
                            }



                        }
                        else if (razmer == "big")
                        {
                            sum = broiporuchani * bigmango;


                            if (sum >= 400 && sum <= 1000)
                            {
                                sum = sum - (sum * 0.15);
                            }
                            else if (sum > 1000)
                            {
                                sum = sum - (sum * 0.5);
                            }



                        }




                        break;
                    }

                case "Watermelon":
                    {

                        if (razmer == "small")
                        {
                            sum = broiporuchani * smalldinia;


                            if (sum >= 400 && sum <= 1000)
                            {
                                sum = sum - (sum * 0.15);
                            }
                            else if (sum > 1000)
                            {
                                sum = sum - (sum * 0.5);
                            }



                        }
                        else if (razmer == "big")
                        {
                            sum = broiporuchani * bigdina;


                            if (sum >= 400 && sum <= 1000)
                            {
                                sum = sum - (sum * 0.15);
                            }
                            else if (sum > 1000)
                            {
                                sum = sum - (sum * 0.5);
                            }



                        }

                        break;
                    }



                case "Pineapple":
                    {


                        if (razmer == "small")
                        {
                            sum = broiporuchani * smallananas;


                            if (sum >= 400 && sum <= 1000)
                            {
                                sum = sum - (sum * 0.15);
                            }
                            else if (sum > 1000)
                            {
                                sum = sum - (sum * 0.5);
                            }



                        }
                        else if (razmer == "big")
                        {
                            sum = broiporuchani * bigananas;


                            if (sum >= 400 && sum <= 1000)
                            {
                                sum = sum - (sum * 0.15);
                            }
                            else if (sum > 1000)
                            {
                                sum = sum - (sum * 0.5);
                            }



                        }
                        break;
                    }
                case "Raspberry":
                    {


                        if (razmer == "small")
                        {
                            sum = broiporuchani * smallmalina;


                            if (sum >= 400 && sum <= 1000)
                            {
                                sum = sum - (sum * 0.15);
                            }
                            else if (sum > 1000)
                            {
                                sum = sum - (sum * 0.5);
                            }



                        }
                        else if (razmer == "big")
                        {
                            sum = broiporuchani * bigmalina;


                            if (sum >= 400 && sum <= 1000)
                            {
                                sum = sum - (sum * 0.15);
                            }
                            else if (sum > 1000)
                            {
                                sum = sum - (sum * 0.5);
                            }



                        }
                        break;
                    }

            }


            Console.WriteLine("{0:F2} lv.", sum);
        }
    }
}
