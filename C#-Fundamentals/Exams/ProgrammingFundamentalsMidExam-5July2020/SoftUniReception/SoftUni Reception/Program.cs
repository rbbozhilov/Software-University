using System;

namespace SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmp = int.Parse(Console.ReadLine());
            int secondEmp = int.Parse(Console.ReadLine());
            int thirdEmp = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int count = 0;

            int perHour = firstEmp + secondEmp + thirdEmp;


            while (true)
            {
                if (students <= 0)
                {
                    break;
                }

                count++;

                if (count % 4 == 0)
                {
                    continue;
                }


                students -= perHour;



            }

            Console.WriteLine("Time needed: {0}h.", count);
        }
    }
}
