using FoodShortage.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizener : IBuyer
    {

        private string name;
        private string age;
        private string id;
        private string birthdate;
        private int food = 0;

        public Citizener(string name,string age,string id,string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Name { get; }
        public string Age { get; }

        public string Birthdate { get; }

        public string Id { get;  }
        public int Food { get { return this.food; }  }

        public void BuyFood()
        {
            this.food += 10;
        }
    }
}
