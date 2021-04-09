﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {

        private const decimal cakePrice = 5;
        private const double grams = 250;
        private const double calories = 1000;


        public Cake(string name) : base(name,cakePrice,grams,calories)
        {

        }

    }
}
