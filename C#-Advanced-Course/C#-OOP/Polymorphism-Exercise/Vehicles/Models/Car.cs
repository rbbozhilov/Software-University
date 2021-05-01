using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {


        private const double adition = 0.9;

        public Car(double fuelUantity, double fuelConsumption) : base(fuelUantity, fuelConsumption)
        {
        }

        protected override double Adition => adition;



    }
}
