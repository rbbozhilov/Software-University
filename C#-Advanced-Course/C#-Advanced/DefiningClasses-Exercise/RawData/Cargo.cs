using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
   public class Cargo
    {

        public Cargo()
        {

        }

        public Cargo(int weight,string type)
        {
            this.Weight = weight;
            this.Type = type;
        }

        public string Type { get; set; }
        public int Weight { get; set; }



    }
}
