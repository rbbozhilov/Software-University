using BorderControl;
using FoodShortage.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
  public  class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<IBuyer> buyers = new List<IBuyer>();

            for(int i=0;i<n;i++)
            {

                string[] tokens = Console.ReadLine().Split();

                if(tokens.Length==4)
                {

                    string currentName = tokens[0];
                    string age = tokens[1];
                    string id = tokens[2];
                    string birthDate = tokens[3];

                    IBuyer currentBuyer = new Citizener(currentName, age, id, birthDate);

                    buyers.Add(currentBuyer);

                }
                else if(tokens.Length==3)
                {
                    string name = tokens[0];
                    string age = tokens[1];
                    string group = tokens[2];

                    IBuyer currentBuyer = new Rebel(name, age, group);
                    buyers.Add(currentBuyer);

                }


            }


            string input = string.Empty;

            while((input=Console.ReadLine()) !="End")
            {

                IBuyer currentBuyer = buyers.FirstOrDefault(x => x.Name == input);

                if(currentBuyer!=null)
                {
                    currentBuyer.BuyFood();
                }


            }

            Console.WriteLine(buyers.Sum(x=>x.Food));

        }
    }
}
