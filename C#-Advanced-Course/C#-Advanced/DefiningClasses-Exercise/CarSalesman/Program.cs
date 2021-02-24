using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
  public  class StartUp
    {
        static void Main(string[] args)
        {

            int numberOfEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for(int i=0;i<numberOfEngines;i++)
            {

                string[] tokens = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                int length = tokens.Length;
                string currentModel = tokens[0];
                int currentPower = int.Parse(tokens[1]);

                if(length==2)
                {
                    Engine currentEngine = new Engine(currentModel, currentPower);
                    engines.Add(currentEngine);
                }
                else if(length==3)
                {

                    if(Char.IsDigit(tokens[2][0]))
                    {
                        Engine currentEngine = new Engine(currentModel, currentPower, tokens[2]);
                        engines.Add(currentEngine);
                    }
                    else
                    {
                        Engine currentEngine = new Engine(currentModel, tokens[2], currentPower);
                        engines.Add(currentEngine);
                    }
                    
                }
                else if(length==4)
                {
                    Engine currentEngine = new Engine(currentModel, currentPower,tokens[2], tokens[3]);
                    engines.Add(currentEngine);
                }


            }

            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for(int i=0;i<numberOfCars;i++)
            {

                string[] tokens = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                int length = tokens.Length;
                string currentModel = tokens[0];
                Engine currentEngine = engines.FirstOrDefault(x => x.Model == tokens[1]);

                if(length==2)
                {
                    Car currentCar = new Car(currentModel, currentEngine);
                    cars.Add(currentCar);
                }
                else if(length==3)
                {

                    if(Char.IsDigit(tokens[2][0]))
                    {
                        Car currentCar = new Car(currentModel, currentEngine, tokens[2]);
                        cars.Add(currentCar);
                    }
                    else
                    {
                        Car currentCar = new Car(currentModel, tokens[2], currentEngine);
                        cars.Add(currentCar);
                    }


                   
                }
                else if(length==4)
                {
                    Car curentCar = new Car(currentModel, currentEngine, tokens[2], tokens[3]);
                    cars.Add(curentCar);
                }


            }


            foreach(var items in cars)
            {
                Console.WriteLine(items.ToString());
            }

        }
    }
}
