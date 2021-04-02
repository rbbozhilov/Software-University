using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
   public  class RandomList : List<string>
    {

        public string RandomString()
        {

            Random number = new Random();
            int index = number.Next(0, this.Count);
            string currentValue = this[index];
            this.Remove(this[index]);
            return currentValue;
        }


    }
}
