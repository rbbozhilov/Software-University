using System;

namespace Summer_Outfit
{
    class Program
    {
        static float retur(double a)
        {

            return (float)a;
        }

        static void Main(string[] args)
        {

            int gradusi = int.Parse(Console.ReadLine());
            string vreme = Console.ReadLine();


            switch (vreme)
            {
                case "Morning":
                    {

                        if (gradusi >= 10 && gradusi <= 18)
                        {
                            Console.WriteLine("It's " + gradusi + " degrees, get your Sweatshirt and Sneakers.");
                        }
                        else if (gradusi > 18 && gradusi <= 24)
                        {
                            Console.WriteLine("It's " + gradusi + " degrees, get your Shirt and Moccasins.");
                        }
                        else if (gradusi >= 25)
                        {
                            Console.WriteLine("It's " + gradusi + " degrees, get your T-Shirt and Sandals.");
                        }
                        break;
                    }
                case "Afternoon":
                    {
                        if (gradusi >= 10 && gradusi <= 18)
                        {
                            Console.WriteLine("It's " + gradusi + " degrees, get your Shirt and Moccasins.");
                        }
                        else if (gradusi > 18 && gradusi <= 24)
                        {
                            Console.WriteLine("It's " + gradusi + " degrees, get your T-Shirt and Sandals.");
                        }
                        else if (gradusi >= 25)
                        {
                            Console.WriteLine("It's " + gradusi + " degrees, get your Swim Suit and Barefoot.");
                        }
                        break;
                    }
                case "Evening":
                    {
                        if (gradusi >= 10 && gradusi <= 18)
                        {
                            Console.WriteLine("It's " + gradusi + " degrees, get your Shirt and Moccasins.");
                        }
                        else if (gradusi > 18 && gradusi <= 24)
                        {
                            Console.WriteLine("It's " + gradusi + " degrees, get your Shirt and Moccasins.");
                        }
                        else if (gradusi >= 25)
                        {
                            Console.WriteLine("It's " + gradusi + " degrees, get your Shirt and Moccasins.");
                        }
                        break;
                    }
            }
        }
    }
}
