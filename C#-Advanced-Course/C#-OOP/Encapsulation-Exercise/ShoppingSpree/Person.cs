using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {

        private string name;
        private double money;
        private List<Product> products;

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            products = new List<Product>();

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new System.ArgumentException("Name cannot be empty");
                    
                }
                this.name = value;
            }
        }
        public double Money
        {
            get
            {
                return this.money;

            }
           private  set
            {

                if(value<0)
                {
                    throw new ArgumentException("Money cannot be negative");
                    
                }

                this.money = value;
            }
        }
        public IReadOnlyCollection<Product> BagOfProducts 
        {
            get
            {
                return this.products.AsReadOnly();
            }
            
        }

        public void Adder(Product currentProduct)
        {

            if(currentProduct.Cost<=this.money)
            {
                this.money -= currentProduct.Cost;
                Console.WriteLine("{0} bought {1}",this.name,currentProduct.Name);
                products.Add(currentProduct);
            }
            else
            {

                Console.WriteLine("{0} can't afford {1}",this.name,currentProduct.Name);

            }
           
            
        }

    }
}
