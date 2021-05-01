using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension.Models
{
    public abstract class Vehicle
    {

        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;
        

        public Vehicle(double fuelUantity, double fuelConsumption , double tankCapacity)
        {
            this.fuelQuantity = fuelUantity;
            this.fuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        private double FuelQuantity { get { return this.fuelQuantity; } 
            set
            {

                if (value > TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            } 
        }
        private double FuelConsumption { get { return this.fuelConsumption; } set { this.fuelConsumption = value; } }
        private double TankCapacity { get; set; }
      
        protected abstract double Adition { get; }



        public virtual string Driving(double distance, bool isConditioner)
        {
            double fuel = 0;

            if (isConditioner)
            {
                fuel = (FuelConsumption + Adition) * distance;
            }
            else
            {
                fuel = FuelConsumption * distance;
            }

            if (fuel <= FuelQuantity)
            {
                FuelQuantity -= fuel;
                return string.Format("{0} travelled {1} km", this.GetType().Name, distance);
            }

            return $"{this.GetType().Name} needs refueling";

        }

        public virtual void Refuel(double liters)
        {

            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                double refuel = FuelQuantity + liters;

                if (refuel > TankCapacity)
                {
                    Console.WriteLine("Cannot fit {0} fuel in the tank", liters);
                }

                else
                {
                    fuelQuantity = refuel;
                }
            }

        }


        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:F2}";
        }

    }
}
