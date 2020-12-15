using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static bool Checker(int number)
        {

            bool check = false;

            int broach = 0;


            for (int i = 1; i <= number; i++)
            {

                if (number % i == 0)
                {
                    broach++;
                }



            }

            if (broach > 2)
            {
                return check;
            }
            else
            {
                check = true;
                return check;
            }


        }



        static void Main(string[] args)
        {


            string text = null;
            int prostisum = 0;
            int neprostisum = 0;

            while ((text = Console.ReadLine()) != "stop")
            {

                int number = int.Parse(text);


                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                if (Checker(number) == false)
                {
                    neprostisum += number;
                }
                else
                {
                    prostisum += number;
                }


            }


            Console.WriteLine("Sum of all prime numbers is: {0}\nSum of all non prime numbers is: {1}", prostisum, neprostisum);

        }
    }
}
