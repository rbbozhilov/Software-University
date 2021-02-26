using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
       
        

        //Constructor

        public Car(string model,double fuelAmount,double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumption;
            this.Travelled = 0;
        }


        //Properties

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double Travelled { get; set; }

        //Behevior

        public void Drive(double amountKm)
        {

            double needLiters = amountKm * FuelConsumptionPerKilometer;

            if (FuelAmount >= needLiters)
            {

                FuelAmount -= needLiters;
                Travelled += amountKm;


            }

            else
            {

                Console.WriteLine("Insufficient fuel for the drive");

            }
        }


        public override string ToString()
        {

            return $"{this.Model} {this.FuelAmount:F2} {this.Travelled}";

        }

    }
}
