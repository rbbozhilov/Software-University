using System;

namespace Small_Shop
{
    class Program
    {
        static float returning(double a)
        {

            return (float)a;
        }


        static void Main(string[] args)
        {



            string produkt = Console.ReadLine();
            string town = Console.ReadLine();
            float razmer = float.Parse(Console.ReadLine());
            float sum = 0;

            if (town == "Sofia")
            {
                if (produkt == "coffee")
                {
                    sum = razmer * returning(0.50);
                    Console.WriteLine(sum);
                }
                else if (produkt == "water")
                {
                    sum = razmer * returning(0.80);
                    Console.WriteLine(sum);
                }
                else if (produkt == "beer")
                {
                    sum = razmer * returning(1.20);
                    Console.WriteLine(sum);

                }
                else if (produkt == "sweets")
                {
                    sum = razmer * returning(1.45);
                    Console.WriteLine(sum);
                }
                else if (produkt == "peanuts")
                {
                    sum = razmer * returning(1.60);
                    Console.WriteLine(sum);
                }
            }
            else if (town == "Plovdiv")
            {
                if (produkt == "coffee")
                {
                    sum = razmer * returning(0.40);
                    Console.WriteLine(sum);
                }
                else if (produkt == "water")
                {
                    sum = razmer * returning(0.70);
                    Console.WriteLine(sum);
                }
                else if (produkt == "beer")
                {
                    sum = razmer * returning(1.15);
                    Console.WriteLine(sum);

                }
                else if (produkt == "sweets")
                {
                    sum = razmer * returning(1.30);
                    Console.WriteLine(sum);
                }
                else if (produkt == "peanuts")
                {
                    sum = razmer * returning(1.50);
                    Console.WriteLine(sum);
                }


            }
            else if (town == "Varna")
            {
                if (produkt == "coffee")
                {
                    sum = razmer * returning(0.45);
                    Console.WriteLine(sum);
                }
                else if (produkt == "water")
                {
                    sum = razmer * returning(0.70);
                    Console.WriteLine(sum);
                }
                else if (produkt == "beer")
                {
                    sum = razmer * returning(1.10);
                    Console.WriteLine(sum);

                }
                else if (produkt == "sweets")
                {
                    sum = razmer * returning(1.35);
                    Console.WriteLine(sum);
                }
                else if (produkt == "peanuts")
                {
                    sum = razmer * returning(1.55);
                    Console.WriteLine(sum);
                }

            }

        }
    }
}
