using System;
using System.Collections.Generic;

namespace RawData
{
    public class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for(int i=0;i<n;i++)
            {

                string[] tokens = Console.ReadLine().Split();

                string currentModel = tokens[0];
                int currentEngineSpeed = int.Parse(tokens[1]);
                int currentEnginePower = int.Parse(tokens[2]);
                int currentCargoWeight = int.Parse(tokens[3]);
                string currentCargoType = tokens[4];
                double firstTirePr = double.Parse(tokens[5]);
                int firstTireAge = int.Parse(tokens[6]);
                double secondTirePr = double.Parse(tokens[7]);
                int secondTireAge = int.Parse(tokens[8]);
                double thirdTirePr = double.Parse(tokens[9]);
                int thirdTireAge = int.Parse(tokens[10]);
                double fourthTirePr = double.Parse(tokens[11]);
                int fourthTireAge = int.Parse(tokens[12]);

                Engine currentEngine = new Engine(currentEngineSpeed, currentEnginePower);
                Cargo currentCargo = new Cargo(currentCargoWeight, currentCargoType);
                List<Tire> tires = new List<Tire>();
                tires.Add(new Tire(firstTireAge, firstTirePr));
                tires.Add(new Tire(secondTireAge, secondTirePr));
                tires.Add(new Tire(thirdTireAge, thirdTirePr));
                tires.Add(new Tire(fourthTireAge, fourthTirePr));


                Car currentCar = new Car(currentModel, currentEngine, tires.ToArray(), currentCargo);

                cars.Add(currentCar);

            }

            string finalCommand = Console.ReadLine();
            List<Car> finalList = new List<Car>();

            if(finalCommand== "fragile")
            {

                foreach(var items in cars)
                {

                    if(items.Cargo.Type=="fragile")
                    {
                        

                       foreach(var itens in items.Tires)
                        {
                            if(itens.Pressure<1)
                            {
                                finalList.Add(items);
                                break;
                            }
                        }
                        
                     

                    }


                }

            }
            else if(finalCommand== "flamable")
            {

                foreach (var items in cars)
                {

                    if (items.Cargo.Type == "flamable")
                    {
                       
                        if(items.Engine.Power>250)
                        {
                            finalList.Add(items);
                        }

                    }


                }


            }


            foreach(var items in finalList)
            {

                Console.WriteLine(items.Model);

            }

        }
    }
}
