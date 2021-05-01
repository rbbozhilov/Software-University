using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension.Models
{
    class Bus : Vehicle
    {

        private const double adition = 1.4;

        public Bus(double fuelUantity, double fuelConsumption, double tankCapacity) : base(fuelUantity, fuelConsumption, tankCapacity)
        {
        }

        protected override double Adition => adition;

       
      

    }
}
