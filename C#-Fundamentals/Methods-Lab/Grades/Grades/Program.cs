using System;

namespace Grades
{
    class Program
    {
        static void PrintGrade(double number)
        {


            string result = string.Empty;

            if (number >= 2 && number <= 2.99)
            {
                result = "Fail";
            }
            else if (number >= 3 && number <= 3.49)
            {
                result = "Poor";
            }
            else if (number >= 3.50 && number <= 4.49)
            {
                result = "Good";
            }
            else if (number >= 4.50 && number <= 5.49)
            {
                result = "Very good";
            }
            else
            {

                result = "Excellent";

            }
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {


            double number = double.Parse(Console.ReadLine());



            PrintGrade(number);

        }
    }
}
