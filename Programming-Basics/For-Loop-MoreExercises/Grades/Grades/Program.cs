using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
             int students = int.Parse(Console.ReadLine());

            double sum = 0;
            double average = 0;
            double broach3=0;
            double broach4=0;
            double broach5=0;
            double broach2 = 0;


            for(int i=0;i<students;i++)
            {

                double grade = double.Parse(Console.ReadLine());
                sum +=grade;
                if(grade>=3 &&grade <=3.99)
                {
                    broach3++;
                }
                else if(grade>=4 && grade<=4.99)
                {
                    broach4++;
                }
                else if(grade>=5)
                {
                    broach5++;
                }
                else if(grade<3)
                {
                    broach2++;
                }



            }

            average = (double)(sum / students);

            double topStudents=broach5/students * 100;
            double studentsbroach4=broach4 / students * 100;
            double studentsBroach3=broach3/students*100;
            double studentsbroach2=broach2/students*100;

            Console.WriteLine("Top students: {0:F2}%\nBetween 4.00 and 4.99: {1:F2}%\nBetween 3.00 and 3.99: {2:F2}%\nFail: {3:F2}%\nAverage: {4:F2}", topStudents, studentsbroach4, studentsBroach3, studentsbroach2, average);
        }
    }
}
