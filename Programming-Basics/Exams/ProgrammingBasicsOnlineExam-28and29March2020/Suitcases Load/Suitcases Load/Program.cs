using System;

namespace Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacityBagage = double.Parse(Console.ReadLine());



            string text = string.Empty;
            int countSuccess = 0;
            int counterOfInputs = 0;
            bool flag = false;
            while ((text = Console.ReadLine()) != "End")
            {

                double currentObem = double.Parse(text);

                counterOfInputs++;


                if (counterOfInputs % 3 == 0)
                {
                    capacityBagage -= currentObem + (currentObem * 0.1);
                }
                else
                {
                    capacityBagage -= currentObem;
                }


                if (capacityBagage >= 0)
                {
                    countSuccess++;
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }



            }


            if (flag)
            {

                Console.WriteLine("Congratulations! All suitcases are loaded!\nStatistic: {0} suitcases loaded.", countSuccess);

            }
            else
            {
                Console.WriteLine("No more space!\nStatistic: {0} suitcases loaded.", countSuccess);
            }
        }
    }
}
