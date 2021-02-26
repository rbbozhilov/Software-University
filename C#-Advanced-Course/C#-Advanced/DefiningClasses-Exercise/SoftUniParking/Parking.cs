using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {

        //Fields

        private int capacity;
        private List<Car> cars;

        //Properties

        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new List<Car>(capacity);
        }

        //Properties

        public int Count
        {

            get
            {

                return this.cars.Count;
            }

           

        }

        //Behavior

        public Car GetCar(string registrationNumber)
        {

            Car currentCar = cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber);

            return currentCar;
        }

        public string AddCar(Car currentCar)
        {

            Car searchedCar = cars.FirstOrDefault(x => x.RegistrationNumber == currentCar.RegistrationNumber);

            if (searchedCar != null)
            {
                return "Car with that registration number, already exists!";
            }

            if (cars.Count >= capacity)
            {
                return "Parking is full!";
            }

            cars.Add(currentCar);

            return $"Successfully added new car {currentCar.Make} {currentCar.RegistrationNumber}";
        }


        public string RemoveCar(string registrationNumber)
        {

            Car searchedCar = cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber);

            if (searchedCar == null)
            {

                return "Car with that registration number, doesn't exist!";

            }

            cars.Remove(searchedCar);


            return $"Successfully removed {registrationNumber}";
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {

            foreach (var items in RegistrationNumbers)
            {

                Car searchedCar = cars.FirstOrDefault(x => x.RegistrationNumber == items);

                if (searchedCar != null)
                {


                    cars.Remove(searchedCar);

                }

            }

        }


    }
}
