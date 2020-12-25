using System;

namespace Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesControl = int.Parse(Console.ReadLine());
            int secondsControl = int.Parse(Console.ReadLine());
            double ulei = double.Parse(Console.ReadLine());
            int secondsForHundred = int.Parse(Console.ReadLine());


            int sumControl = minutesControl * 60 + secondsControl;

            double timeLose = (double)ulei / 120;


            double totalTimelose = (double)timeLose * 2.5;

            double timeOfMarin = (double)((ulei / 100) * secondsForHundred - totalTimelose);

            if (timeOfMarin <= sumControl)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!\nHis time is {0:F3}.", timeOfMarin);
            }
            else
            {

                Console.WriteLine("No, Marin failed! He was {0:F3} second slower.", Math.Abs(timeOfMarin - sumControl));


            }
        }
    }
}
