using System;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] monsters = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            int bitCoins = 0;
            int health = 100;


            for (int i = 0; i < monsters.Length; i++)
            {

                string[] tokens = monsters[i].Split();
                string currentCommand = tokens[0];
                int currentValue = int.Parse(tokens[1]);

                if (currentCommand == "potion")
                {
                    int currentHealth = 0;
                    if (health < 100)
                    {
                        while (health != 100 && currentValue != 0)
                        {
                            health++;
                            currentHealth++;
                            currentValue--;
                        }
                    }

                    Console.WriteLine("You healed for {0} hp.", currentHealth);
                    Console.WriteLine("Current health: {0} hp.", health);

                }

                else if (currentCommand == "chest")
                {

                    Console.WriteLine("You found {0} bitcoins.", currentValue);

                    bitCoins += currentValue;


                }

                else
                {
                    health -= currentValue;

                    if (health > 0)
                    {
                        Console.WriteLine("You slayed {0}.", currentCommand);

                    }
                    else
                    {
                        Console.WriteLine("You died! Killed by {0}.", currentCommand);
                        Console.WriteLine("Best room: {0}", i + 1);
                        Environment.Exit(0);
                    }


                }

            }


            Console.WriteLine("You've made it!\nBitcoins: {0}\nHealth: {1}", bitCoins, health);
        }
    }
}
