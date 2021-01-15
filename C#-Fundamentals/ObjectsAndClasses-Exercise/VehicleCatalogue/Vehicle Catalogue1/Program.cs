using System;
using System.Collections.Generic;

namespace Vehicle_Catalogue1
{
    class Car
    {

        public Car(string model, string color, int horsepower)
        {
            Model = model;
            Color = color;
            HorsePower = horsepower;
            Type = "Car";
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }



    }


    class Truck
    {

        public Truck(string model, string color, int horsepower)
        {
            Model = model;
            Color = color;
            HorsePower = horsepower;
            Type = "Truck";
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }


    }

    class Catalogue
    {

        public Catalogue()
        {
            car = new List<Car>();
            truck = new List<Truck>();
        }

        public List<Car> car { get; set; }
        public List<Truck> truck { get; set; }



        public double AverageCar(List<Car> cars)
        {

            double sum = 0;

            foreach (var items in cars)
            {
                sum += items.HorsePower;
            }
            double average = sum / cars.Count;
            if (sum == 0)
            {
                return 0;
            }
            return average;
        }

        public double AverageTruck(List<Truck> trucks)
        {
            double sum = 0;

            foreach (Truck items in trucks)
            {
                sum += items.HorsePower;
            }




            double average = sum / trucks.Count;

            if (sum == 0)
            {
                return 0;
            }
            return average;
        }

    }


    class Program
    {

        static void Main(string[] args)
        {


            string input = string.Empty;

            Catalogue vehicles = new Catalogue();

            while ((input = Console.ReadLine()) != "End")
            {


                string[] currentInput = input.Split();
                string currentType = currentInput[0];
                string currentModel = currentInput[1];
                string currentColor = currentInput[2];
                int currentHorsePower = int.Parse(currentInput[3]);


                if (currentType == "car")
                {

                    Car currentCar = new Car(currentModel, currentColor, currentHorsePower);

                    vehicles.car.Add(currentCar);

                }
                else
                {
                    Truck currentTruck = new Truck(currentModel, currentColor, currentHorsePower);

                    vehicles.truck.Add(currentTruck);
                }


            }

            string searchingModel = string.Empty;

            while ((searchingModel = Console.ReadLine()) != "Close the Catalogue")
            {

                if (vehicles.car.Exists(s => s.Model == searchingModel))
                {

                    Car currentCar = vehicles.car.Find(items => items.Model == searchingModel);

                    Console.WriteLine("Type: {0}\nModel: {1}\nColor: {2}\nHorsepower: {3}", currentCar.Type, currentCar.Model, currentCar.Color, currentCar.HorsePower);


                }
                else
                {
                    Truck currentTruck = vehicles.truck.Find(items => items.Model == searchingModel);

                    Console.WriteLine("Type: {0}\nModel: {1}\nColor: {2}\nHorsepower: {3}", currentTruck.Type, currentTruck.Model, currentTruck.Color, currentTruck.HorsePower);

                }

            }

            Console.WriteLine("Cars have average horsepower of: {0:F2}.\nTrucks have average horsepower of: {1:F2}.", vehicles.AverageCar(vehicles.car), vehicles.AverageTruck(vehicles.truck));





        }
    }
}
