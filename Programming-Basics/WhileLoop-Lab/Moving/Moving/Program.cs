using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int shirokprost = int.Parse(Console.ReadLine());
            int duljinasvobod = int.Parse(Console.ReadLine());
            int visochinasvobod = int.Parse(Console.ReadLine());
            string text = null;
            int svobodnomesto = shirokprost * duljinasvobod * visochinasvobod;
            int totalsum = 0;
            bool check = true;
            int finish = 0;
            while ((text = Console.ReadLine()) != "Done")
            {

                int kashon = int.Parse(text);

                totalsum += kashon;

                if (totalsum > svobodnomesto)
                {
                    check = false;
                    break;

                }


            }


            if (check == true)
            {
                finish = svobodnomesto - totalsum;
                Console.WriteLine("{0} Cubic meters left.", finish);

            }
            else
            {
                finish = Math.Abs(svobodnomesto - totalsum);
                Console.WriteLine("No more free space! You need {0} Cubic meters more.", finish);

            }
        }
    }
}
