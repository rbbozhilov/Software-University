using System;
using System.Collections.Generic;
using System.Linq;

namespace Plant_Discovery
{
    public class Plant
    {

        public Plant(string planet, int rarity, double rating)
        {
            this.Planet = planet;
            this.Rarity = rarity;
            this.Rating = rating;

        }

        public string Planet { get; set; }
        public int Rarity { get; set; }
        public double Rating { get; set; }


        public override string ToString()
        {
            return $"- {this.Planet}; Rarity: {this.Rarity}; Rating: {this.Rating:F2}";
        }

    }


    public class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var plantAndRarity = new Dictionary<string, int>();
            var plantAndRating = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string currentPlant = input[0];
                int currentRarity = int.Parse(input[1]);

                if (!plantAndRarity.ContainsKey(currentPlant))
                {

                    plantAndRarity.Add(currentPlant, currentRarity);
                    plantAndRating.Add(currentPlant, new List<double>());

                }

                else
                {
                    plantAndRarity[currentPlant] = currentRarity;
                }


            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Exhibition")
            {

                string[] tokens = command.Split(new char[] { '-', ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];

                if (!plantAndRarity.ContainsKey(tokens[1]))
                {
                    Console.WriteLine("error");
                    continue;
                }

                if (currentCommand == "Rate")
                {


                    string currentPlant = tokens[1];
                    double rating = double.Parse(tokens[2]);


                    plantAndRating[currentPlant].Add(rating);




                }

                else if (currentCommand == "Update")
                {


                    string currentPlant = tokens[1];
                    int newRarity = int.Parse(tokens[2]);


                    plantAndRarity[currentPlant] = newRarity;




                }

                else if (currentCommand == "Reset")
                {
                    string currentPlant = tokens[1];


                    plantAndRating[currentPlant] = new List<double>();




                }

                else
                {
                    Console.WriteLine("error");
                }

            }

            List<Plant> plants = new List<Plant>();

            foreach (var items in plantAndRarity)
            {

                double sum = plantAndRating[items.Key].Sum();

                if (sum != 0)
                {
                    sum = plantAndRating[items.Key].Average();
                }

                else
                {
                    sum = 0;
                }

                Plant currentPlant = new Plant(items.Key, items.Value, sum);

                plants.Add(currentPlant);


            }

            plants = plants.OrderByDescending(x => x.Rarity).ThenByDescending(x => x.Rating).ToList();
            Console.WriteLine("Plants for the exhibition:");
            foreach (var items in plants)
            {
                Console.WriteLine(items);
            }

        }
    }
}
