using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {

        //Fields

        private string make;
        private string model;
        private int horsePower;
        private string registrationNumber;


        public Car(string make,string model,int horsePower,string registrationNumber)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsePower;
            this.RegistrationNumber = registrationNumber;
        }


        //Properties

        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                this.make = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            set
            {
                this.horsePower = value;
            }
        }
        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            set
            {
                this.registrationNumber = value;
            }
        }





        public override string ToString()
        {
            string result = $"Make: {this.Make}{Environment.NewLine}";
            result += $"Model: {this.Model}{Environment.NewLine}";
            result += $"HorsePower: {this.HorsePower}{Environment.NewLine}";
            result += $"RegistrationNumber: {this.RegistrationNumber}";

            return result;
        }


    }
}
