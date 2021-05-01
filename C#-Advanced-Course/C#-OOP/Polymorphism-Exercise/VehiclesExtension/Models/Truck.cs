using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension.Models
{
    public class Truck : Vehicle
    {

        private const double adition = 1.6;


        public Truck(double fuelUantity, double fuelConsumption, double tankCapacity) : base(fuelUantity, fuelConsumption, tankCapacity)
        {
        }

        protected override double Adition => adition;

        

    }
}
