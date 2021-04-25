﻿using BorderControl;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Pet : Checker
    {
        private string name;
        private string birthdate;

        public Pet(string name,string birthdate)
        {

            this.Name = name;
            this.Birthdate = birthdate;

        }

        public string Name { get; set; }
      

    }
}
