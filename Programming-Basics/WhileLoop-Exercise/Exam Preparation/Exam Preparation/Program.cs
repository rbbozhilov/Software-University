using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int broinezadovo = int.Parse(Console.ReadLine());

            string imezadacha = null;
            double sum = 0;
            double average = 0;
            int broachchisla = 0;
            int broachnezadovo = 0;
            bool check = true;
            string helper = null;
            while ((imezadacha = Console.ReadLine()) != "Enough")
            {
                helper = imezadacha;
                int number = int.Parse(Console.ReadLine());

                if (number <= 4)
                {
                    broachnezadovo++;


                    if (broachnezadovo == broinezadovo)
                    {
                        check = false;
                        Console.WriteLine("You need a break, {0} poor grades.", broachnezadovo);
                        break;

                    }

                }

                sum += number;
                broachchisla++;



            }

            if (check == true)
            {
                average = sum / broachchisla;

                Console.WriteLine("Average score: {0:F2}\nNumber of problems: {1}\nLast problem: {2}", average, broachchisla, helper);
            }

        }
    }
}
