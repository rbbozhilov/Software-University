using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension.Models
{
    public class Car : Vehicle
    {


        private const double adition = 0.9;

        public Car(double fuelUantity, double fuelConsumption, double tankCapacity) : base(fuelUantity, fuelConsumption, tankCapacity)
        {
        }

        protected override double Adition => adition;



    }
}
