using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Attributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {

        private readonly int minValue;
        private readonly int maxValue;

        public MyRangeAttribute(int minValue,int maxValue)
        {

            ValidateRange(maxValue, minValue);

            this.minValue = minValue;
            this.maxValue = maxValue;


        }


        public override bool IsValid(object obj)
        {
            if(obj is Int32)
            {
                int value = (int)obj;

                if(value < minValue || value>maxValue)
                {
                    return false;
                }

                return true;
            }
            else
            {
                throw new ArgumentException("Cannot validate given data type!");
            }
        }


        private void ValidateRange(int max,int min)
        {
            if(min>max)
            {
                throw new ArgumentException("Invalid range!");
            }
        }


    }
}
