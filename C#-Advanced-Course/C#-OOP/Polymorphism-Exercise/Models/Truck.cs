using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {

        private const double adition = 1.6;
        private const double refueled = 0.95;
        public Truck(double fuelUantity, double fuelConsumption) : base(fuelUantity, fuelConsumption)
        {
        }

        protected override double Adition => adition;

        public override void Refuel(double liters)
        {
            base.Refuel(liters * refueled);
        }

    }
}
