using System;

namespace Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var totalFood = double.Parse(Console.ReadLine());

            var catFood = 0.0;
            var dogFood = 0.0;
            double biscuits = 0;

            var eatenFoodByCat = 0.0;
            var eatenFoodByDog = 0.0;

            for (int i = 1; i <= days; i++)
            {
                dogFood = int.Parse(Console.ReadLine());
                catFood = int.Parse(Console.ReadLine());


                eatenFoodByCat += catFood;
                eatenFoodByDog += dogFood;


                if (i % 3 == 0)
                {
                    biscuits += (dogFood + catFood) * 0.1;
                }



            }

            var sum = eatenFoodByCat + eatenFoodByDog;
            var eatenFood = sum / totalFood * 100;
            var eatenFromDog = eatenFoodByDog / sum * 100;
            var eatenFromCat = eatenFoodByCat / sum * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{eatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{eatenFromDog:f2}% eaten from the dog.");
            Console.WriteLine($"{eatenFromCat:f2}% eaten from the cat.");
        }
    }
}
