using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {


        public Car()
        {
            this.Weight = "n/a";
            this.Color = "n/a";
        }

        public Car(string model, Engine engine) :this()
        {
            this.Model = model;
            this.Engine = engine;

        }

        public Car(string model, Engine engine, string weight) : this(model, engine)
        {
            this.Weight = weight;

        }

        public Car(string model,string color,Engine engine) :this(model,engine)
        {

            this.Color = color;


        }

        public Car(string model, Engine engine, string weight, string color) : this(model, engine, weight)
        {
            this.Color = color;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        
        public string Color { get; set; }



        public override string ToString()
        {


            return $"{this.Model}:\n {this.Engine.Model}:\n  Power: {this.Engine.Power}\n  Displacement: {this.Engine.Displacement}\n  Efficiency: {this.Engine.Efficiency}\n Weight: {this.Weight}\n Color: {this.Color}";

        }



    }
}
