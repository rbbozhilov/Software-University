using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        
        private double fuelQuantity;
        private double fuelConsumption;

        public Vehicle(double fuelUantity,double fuelConsumption)
        {
            this.fuelQuantity = fuelUantity;
            this.fuelConsumption = fuelConsumption;
        }

        private double FuelQuantity { get { return this.fuelQuantity; } set { this.fuelQuantity = value; } }
        private double FuelConsumption { get { return this.fuelConsumption; } set { this.fuelConsumption = value; } }
        protected abstract double Adition { get;  }


       public  string Driving(double distance)
        {

            double fuel = (FuelConsumption + Adition) * distance;

            if(fuel<=FuelQuantity)
            {
                FuelQuantity -= fuel;
                return string.Format("{0} travelled {1} km",this.GetType().Name,distance);
            }

            return $"{this.GetType().Name} needs refueling";

        }

        public virtual void Refuel(double liters)
        {

            FuelQuantity += liters;

        }


        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:F2}";
        }

    }
}
