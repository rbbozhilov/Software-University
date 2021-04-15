namespace AnimalFarm
{
    using System;
    using System.Collections.Generic;
    using AnimalFarm.Models;
   public  class StartUp
    {
        static void Main(string[] args)
        {


            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            List<Chicken> chikens = new List<Chicken>();

            try
            {
                var currentChicken = new Chicken(name, age);

                chikens.Add(currentChicken);
            }
            catch (ArgumentException x)
            {

                Console.WriteLine(x.Message);
            }

            if (chikens.Count > 0)
            {
                Console.WriteLine(
                    "Chicken {0} (age {1}) can produce {2} eggs per day.",
                    chikens[0].Name,
                    chikens[0].Age,
                    chikens[0].ProductPerDay);
            }


        }
    }
}
