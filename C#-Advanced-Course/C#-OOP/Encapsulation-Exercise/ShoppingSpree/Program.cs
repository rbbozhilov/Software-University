using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] personTokens = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Person> person = new List<Person>();

            for (int i = 0; i < personTokens.Length; i++)
            {

                string[] miniTokens = personTokens[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string currentName = miniTokens[0];
                double currentMoney = double.Parse(miniTokens[1]);
                try
                {

                    Person currentPerson = new Person(currentName, currentMoney);

                    person.Add(currentPerson);
                }
                catch(ArgumentException x)
                {

                    Console.WriteLine(x.Message);
                    Environment.Exit(0);

                }
                


            }

            string[] productTokens = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Product> products = new List<Product>();

            for (int i = 0; i < productTokens.Length; i++)
            {

                string[] miniTokens = productTokens[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string currentName = miniTokens[0];
                double currentCost = double.Parse(miniTokens[1]);
                try
                {


                    Product currentProduct = new Product(currentName, currentCost);
                    products.Add(currentProduct);

                }
                catch(ArgumentException x)
                {
                    Console.WriteLine(x.Message);
                    Environment.Exit(0);
                }

                

            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {

                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentName = tokens[0];
                string currentProduct = tokens[1];
                int indexPerson = person.FindIndex(x => x.Name == currentName);
                int indexProduct = products.FindIndex(x => x.Name == currentProduct);

               
                    person[indexPerson].Adder(products[indexProduct]);
                
            }

            foreach (var items in person)
            {
                if (items.BagOfProducts.Count > 0)
                {

                    Console.Write("{0} - ", items.Name);
                    Console.WriteLine(string.Join(", ", items.BagOfProducts));

                }

                else
                {
                    Console.WriteLine("{0} - Nothing bought",items.Name);
                }

            }


        }
    }
}
