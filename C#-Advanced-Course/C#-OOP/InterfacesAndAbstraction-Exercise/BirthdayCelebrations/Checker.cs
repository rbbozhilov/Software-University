using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
   public abstract class Checker
    {



        public string Birthdate { get; set; }


        public string Validation(string birthdate,string currentBirthdate)
        {

            string[] tokensBirth = birthdate.Split("/");
            

            if(tokensBirth[2]== currentBirthdate)
            {
                return birthdate;
            }

            else
            {
                return "false";
            }

        }


    }
}
