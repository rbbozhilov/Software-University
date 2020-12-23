using System;

namespace Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string srok = Console.ReadLine();
            string type = Console.ReadLine();
            string internet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());
            double price = 0;

            switch (srok)
            {


                case "one":
                    {

                        if (type == "Small")
                        {

                            price = 9.98;

                        }
                        else if (type == "Middle")
                        {
                            price = 18.99;
                        }
                        else if (type == "Large")
                        {

                            price = 25.98;

                        }
                        else if (type == "ExtraLarge")
                        {
                            price = 35.99;

                        }


                        if (price <= 10 && internet == "yes")
                        {
                            price += 5.50;
                        }
                        else if (price <= 30 && price > 10 && internet == "yes")
                        {
                            price += 4.35;
                        }
                        else if (price > 30 && internet == "yes")
                        {
                            price += 3.85;
                        }



                        break;
                    }



                case "two":
                    {

                        if (type == "Small")
                        {

                            price = 8.58;

                        }
                        else if (type == "Middle")
                        {
                            price = 17.09;
                        }
                        else if (type == "Large")
                        {

                            price = 23.59;

                        }
                        else if (type == "ExtraLarge")
                        {
                            price = 31.79;

                        }


                        if (price <= 10 && internet == "yes")
                        {
                            price += 5.50;
                        }
                        else if (price <= 30 && price > 10 && internet == "yes")
                        {
                            price += 4.35;
                        }
                        else if (price > 30 && internet == "yes")
                        {
                            price += 3.85;
                        }


                        price = price - (price * 0.0375);



                        break;
                    }



            }

            Console.WriteLine("{0:F2} lv.", price * months);
        }
    }
}
