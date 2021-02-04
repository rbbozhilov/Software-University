using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesofCodeVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            var nameAndHp = new Dictionary<string, int>();
            var nameAndMana = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentName = input[0];
                int hp = int.Parse(input[1]);
                int mana = int.Parse(input[2]);

                nameAndHp.Add(currentName, hp);
                nameAndMana.Add(currentName, mana);



            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {

                string[] tokens = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];

                if (currentCommand == "CastSpell")
                {

                    string currentName = tokens[1];
                    int mpNeed = int.Parse(tokens[2]);
                    string spellName = tokens[3];

                    if (nameAndMana.ContainsKey(currentName))
                    {

                        int sum = nameAndMana[currentName] - mpNeed;

                        if (sum >= 0)
                        {
                            nameAndMana[currentName] -= mpNeed;
                            Console.WriteLine("{0} has successfully cast {1} and now has {2} MP!", currentName, spellName, nameAndMana[currentName]);
                        }

                        else
                        {
                            Console.WriteLine("{0} does not have enough MP to cast {1}!", currentName, spellName);
                        }

                    }

                }

                else if (currentCommand == "TakeDamage")
                {

                    string currentName = tokens[1];
                    int damage = int.Parse(tokens[2]);
                    string attacker = tokens[3];

                    if (nameAndHp.ContainsKey(currentName))
                    {
                        nameAndHp[currentName] -= damage;

                        if (nameAndHp[currentName] > 0)
                        {
                            Console.WriteLine("{0} was hit for {1} HP by {2} and now has {3} HP left!", currentName, damage, attacker, nameAndHp[currentName]);
                        }

                        else
                        {

                            Console.WriteLine("{0} has been killed by {1}!", currentName, attacker);

                            nameAndHp.Remove(currentName);
                            nameAndMana.Remove(currentName);


                        }


                    }


                }

                else if (currentCommand == "Recharge")
                {

                    string currentName = tokens[1];
                    int currentAmount = int.Parse(tokens[2]);

                    if (nameAndMana.ContainsKey(currentName))
                    {

                        int sum = currentAmount + nameAndMana[currentName];

                        if (sum > 200)
                        {
                            sum = 200 - nameAndMana[currentName];
                            nameAndMana[currentName] = 200;
                        }

                        else
                        {
                            nameAndMana[currentName] += currentAmount;
                            sum = currentAmount;
                        }

                        Console.WriteLine("{0} recharged for {1} MP!", currentName, sum);

                    }


                }

                else if (currentCommand == "Heal")
                {

                    string currentName = tokens[1];
                    int health = int.Parse(tokens[2]);

                    if (nameAndHp.ContainsKey(currentName))
                    {

                        int sum = health + nameAndHp[currentName];

                        if (sum > 100)
                        {
                            sum = 100 - nameAndHp[currentName];
                            nameAndHp[currentName] = 100;
                        }

                        else
                        {
                            nameAndHp[currentName] += health;
                            sum = health;
                        }


                        Console.WriteLine("{0} healed for {1} HP!", currentName, sum);

                    }

                }


            }


            nameAndHp = nameAndHp.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var items in nameAndHp)
            {

                Console.WriteLine(items.Key);
                Console.WriteLine("  HP: {0}", items.Value);
                Console.WriteLine("  MP: {0}", nameAndMana[items.Key]);


            }
        }
    }
}
