using System;

namespace Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int turn = int.Parse(Console.ReadLine());
            double finalResult = 0;
            double broach1 = 0;
            double broach2 = 0;
            double broach3 = 0;
            double broach4 = 0;
            double broach5 = 0;
            double broach6 = 0;


            for (int i = 0; i < turn; i++)
            {

                double number = double.Parse(Console.ReadLine());

                if (number >= 0 && number <= 9)
                {

                    finalResult += (double)(number * 0.2);
                    broach1++;

                }
                else if (number >= 10 && number <= 19)
                {
                    finalResult += (double)(number * 0.3);
                    broach2++;
                }
                else if (number >= 20 && number <= 29)
                {
                    finalResult += (double)(number * 0.4);
                    broach3++;
                }
                else if (number >= 30 && number <= 39)
                {
                    finalResult += 50;
                    broach4++;
                }
                else if (number >= 40 && number <= 50)
                {
                    finalResult += 100;
                    broach5++;
                }
                else
                {

                    finalResult /= 2;
                    broach6++;
                }
            }

            double procentbroach1 = broach1 / turn * 100;
            double procentbroach2 = broach2 / turn * 100;
            double procentbroach3 = broach3 / turn * 100;
            double procntbroach4 = broach4 / turn * 100;
            double procentbroach5 = broach5 / turn * 100;
            double procentbroach6 = broach6 / turn * 100;

            Console.WriteLine("{0:F2}\nFrom 0 to 9: {1:F2}%\nFrom 10 to 19: {2:F2}%\nFrom 20 to 29: {3:F2}%\nFrom 30 to 39: {4:F2}%\nFrom 40 to 50: {5:F2}%", finalResult, procentbroach1, procentbroach2, procentbroach3, procntbroach4, procentbroach5);
            Console.WriteLine("Invalid numbers: {0:F2}%", procentbroach6);
        }
    }
}
