using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSnowBalls = int.Parse(Console.ReadLine());

            BigInteger max = int.MinValue;
            BigInteger sum = 0;
            BigInteger lastSum = 0;
            int saveSnowBallSnow = 0;
            int saveSnowBallTime = 0;
            int saveSnowBallUality = 0;
            for (int i = 0; i < numberSnowBalls; i++)
            {

                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallUality = int.Parse(Console.ReadLine());


                sum = (snowBallSnow / snowBallTime);
                lastSum = BigInteger.Pow(sum, snowBallUality);



                if (lastSum > max)
                {
                    max = lastSum;

                    saveSnowBallSnow = snowBallSnow;
                    saveSnowBallTime = snowBallTime;
                    saveSnowBallUality = snowBallUality;

                }

            }


            Console.WriteLine("{0} : {1} = {2} ({3})", saveSnowBallSnow, saveSnowBallTime, max, saveSnowBallUality);
        }
    }
}
