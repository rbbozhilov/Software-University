using System;

namespace National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmp = int.Parse(Console.ReadLine());
            int secondEmp = int.Parse(Console.ReadLine());
            int thirdEmp = int.Parse(Console.ReadLine());

            int people = int.Parse(Console.ReadLine());


            int answers = firstEmp + secondEmp + thirdEmp;
            int count = 0;


            while (true)
            {


                if (people <= 0)
                {
                    Console.WriteLine("Time needed: {0}h.", count);
                    break;
                }

                count++;

                if (count % 4 == 0 && count != 0)
                {

                    continue;
                }

                people -= answers;



            }
        }
    }
}
