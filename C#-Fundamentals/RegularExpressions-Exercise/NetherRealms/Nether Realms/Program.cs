using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Nether_Realms
{
    class Demon
    {

        public Demon(string name, int health, double damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }


        public override string ToString()
        {
            return $"{this.Name} - {this.Health} health, { this.Damage:F2} damage";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {


            List<Demon> demon = new List<Demon>();

            string numberPattern = @"[-+]?[0-9]+\.?[0-9]*";
            Regex numberReg = new Regex(numberPattern);

            string[] demons = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var demone in demons)
            {
                string filter = "0123456789+-*/.";

                int health = demone.Where(x => !filter.Contains(x)).Sum(x => x);

                double damage = CalculateDamage(numberReg, demone);

                Demon currentDemon = new Demon(demone, health, damage);

                demon.Add(currentDemon);


            }

            demon = demon.OrderBy(x => x.Name).ToList();

            foreach (var item in demon)
            {
                Console.WriteLine(item);
            }

        }

        private static double CalculateDamage(Regex numberReg, string demon)
        {

            MatchCollection matches = numberReg.Matches(demon);
            double sum = 0;

            foreach (Match items in matches)
            {
                sum += double.Parse(items.Value);
            }


            foreach (var items in demon)
            {
                if (items == '*')
                {
                    sum *= 2;
                }

                else if (items == '/')
                {
                    sum /= 2;
                }
            }


            return sum;
        }
    }
}
