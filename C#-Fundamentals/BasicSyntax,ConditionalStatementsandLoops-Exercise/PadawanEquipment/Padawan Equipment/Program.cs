using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightSabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            double totalSum = 0;

            double procent = Math.Ceiling(students + (students * 0.1));

            double allSabers = priceLightSabers * procent;

            double allRobes = students * priceRobes;

            int count = 0;

            for (int i = 1; i <= students; i++)
            {
                if (i % 6 == 0)
                {
                    count++;
                }
            }

            double allBelts = priceBelts * (students - count);


            totalSum = allBelts + allRobes + allSabers;

            if (money >= totalSum)
            {
                Console.WriteLine("The money is enough - it would cost {0:F2}lv.", totalSum);
            }
            else
            {
                Console.WriteLine("Ivan Cho will need {0:F2}lv more.", Math.Abs(money - totalSum));
            }
        }
    }
}
