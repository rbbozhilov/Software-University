using System;
using System.Collections.Generic;

namespace Vehicle_Catalogue
{
    class Program
    {

        class Truck
        {

            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }

        }

        class Car
        {

            public string Brand { get; set; }
            public string Model { get; set; }
            public int HoursPower { get; set; }

        }



        class Catalog
        {

            public Catalog()
            {
                Cars = new Car();
                Trucks = new Truck();
            }


            public Car Cars { get; set; }
            public Truck Trucks { get; set; }

            public string Type { get; set; }

        }


        static void SortCar(List<Catalog> typeCars)
        {

            Catalog currentCar = new Catalog();
            Catalog currentCarIn = new Catalog();
            for (int i = 0; i < typeCars.Count; i++)
            {

                currentCar = typeCars[i];

                for (int j = 0; j < typeCars.Count; j++)
                {

                    currentCarIn = typeCars[j];


                    if (currentCar.Cars.Model[0] < currentCarIn.Cars.Model[0])
                    {

                        Catalog temp = typeCars[i];

                        typeCars[i] = currentCarIn;
                        typeCars[j] = temp;

                    }

                }


            }

        }


        static void SortTruck(List<Catalog> typeTrucks)
        {

            Catalog currentTruck = new Catalog();
            Catalog currentTruckIn = new Catalog();
            for (int i = 0; i < typeTrucks.Count; i++)
            {

                currentTruck = typeTrucks[i];

                for (int j = 0; j < typeTrucks.Count; j++)
                {

                    currentTruckIn = typeTrucks[j];


                    if (currentTruck.Trucks.Model[0] < currentTruckIn.Trucks.Model[0])
                    {

                        Catalog temp = typeTrucks[i];

                        typeTrucks[i] = currentTruckIn;
                        typeTrucks[j] = temp;

                    }

                }


            }

        }

        static void Main(string[] args)
        {



            string text = string.Empty;

            List<Catalog> cars = new List<Catalog>();
            List<Catalog> trucks = new List<Catalog>();

            while ((text = Console.ReadLine()) != "end")
            {


                string[] arrayString = text.Split('/');

                Catalog currentType = new Catalog();

                currentType.Type = arrayString[0];

                if (currentType.Type == "Car")
                {

                    currentType.Cars.Brand = arrayString[1];
                    currentType.Cars.Model = arrayString[2];
                    currentType.Cars.HoursPower = int.Parse(arrayString[3]);

                    cars.Add(currentType);

                }

                else if (currentType.Type == "Truck")
                {

                    currentType.Trucks.Brand = arrayString[1];
                    currentType.Trucks.Model = arrayString[2];
                    currentType.Trucks.Weight = int.Parse(arrayString[3]);

                    trucks.Add(currentType);



                }

            }


            if (cars.Count > 0)
            {


                Console.WriteLine("Cars:");

                SortCar(cars);
                foreach (Catalog items in cars)
                {
                    Console.WriteLine("{0}: {1} - {2}hp", items.Cars.Brand, items.Cars.Model, items.Cars.HoursPower);
                }

            }

            if (trucks.Count > 0)
            {


                Console.WriteLine("Trucks:");
                SortTruck(trucks);


                foreach (Catalog items in trucks)
                {
                    Console.WriteLine("{0}: {1} - {2}kg", items.Trucks.Brand, items.Trucks.Model, items.Trucks.Weight);
                }

            }

        }
    }
}
