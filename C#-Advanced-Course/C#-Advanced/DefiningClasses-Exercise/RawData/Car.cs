using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
   public class Car
    {

        public Car(string model)
        {
            this.Model = model;
            this.Engine = new Engine();
            this.Tires = new Tire[4];
            this.Cargo = new Cargo();
        }

        public Car(string model,Engine engine,Tire[] tires,Cargo cargo) : this(model)
        {
            this.Engine = engine;
            this.Tires = tires;
            this.Cargo = cargo;
        }


        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }
        public Cargo Cargo { get; set; }


    }
}
