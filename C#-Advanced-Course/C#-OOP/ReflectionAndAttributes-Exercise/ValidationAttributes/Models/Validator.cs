using System;
using System.Collections.Generic;
using System.Text;
using ValidationAttributes.Attributes;
using System.Linq;
using System.Reflection;

namespace ValidationAttributes.Models
{
   public static class Validator 
    {

        public static bool IsValid(object obj)
        {

            if(obj==null)
            {
                return false;
            }

            Type type = obj.GetType();
            var properties = type.GetProperties();

            foreach(var propertie in properties)
            {

                MyValidationAttribute[] attributes = propertie
                    .GetCustomAttributes()
                    .Where(ca => ca is MyValidationAttribute)
                    .Cast<MyValidationAttribute>()
                    .ToArray();


                foreach(var attribute in attributes)
                {
                    if(!attribute.IsValid(propertie.GetValue(obj)))
                    {
                        return false;
                    }
                }

            }


            return true;
        }


    }
}
