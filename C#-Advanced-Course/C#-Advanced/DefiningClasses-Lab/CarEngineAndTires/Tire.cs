﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
   public class Tire
    {

        //Fields

        private int year;
        private double pressure;

        //Constructor

        public Tire(int year,double pressure)
        {

            this.Year = year;
            this.Pressure = pressure;

        }


        //Properties

        public int Year { get; set; }
        public double Pressure { get; set; }


    }
}
