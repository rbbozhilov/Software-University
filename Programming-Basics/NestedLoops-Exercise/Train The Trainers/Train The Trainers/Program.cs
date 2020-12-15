using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = null;
            double sum = 0;
            double average = 0;
            int number = int.Parse(Console.ReadLine());
            double finalsum = 0;
            double finalaverage = 0;
            int broach = 0;
            while ((text = Console.ReadLine()) != "Finish")
            {

                for (int i = 0; i < number; i++)
                {

                    double grades = double.Parse(Console.ReadLine());

                    sum += grades;

                }

                average = (double)sum / number;
                finalsum += average;
                broach++;
                Console.WriteLine("{0} - {1:F2}.", text, average);
                average = 0;
                sum = 0;
            }

            finalaverage = (double)finalsum / broach;

            Console.WriteLine("Student's final assessment is {0:F2}.", finalaverage);
        }
    }
}
