using FoodShortage.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Rebel : IBuyer
    {

        private string name;
        private string age;
        private string group;
        private int food = 0;

        public Rebel(string name, string age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public string Name { get; }
        public string Age { get; }
        public string Group { get; }

        public int Food => this.food;

        public void BuyFood()
        {
            this.food += 5; 
        }
    }
}
