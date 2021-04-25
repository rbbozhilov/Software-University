using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BorderControl
{
   public  class Robot : Checker
    {
        private string model;
        private string id;

        public Robot(string model,string id)
        {
            this.Model = model;
            this.Id = id;
        }


        public string Model { get; }
        public string Id { get; set; }

    }
}
