using System;
using System.Threading;

namespace CreatingThreads
{
   public class Program
    {
        static void Main(string[] args)
        {

            Thread firstThread = new Thread(firstMainMethodThread);
            Thread secondThread = new Thread(secondMainMethodThread);
            Thread thirdThread = new Thread(thirdMainMethodThread);

            firstThread.Start();
            secondThread.Start();
            thirdThread.Start();

            Console.WriteLine("end of main method");
        }


        static void firstMainMethodThread()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Hi from first thread");
        }

        static void secondMainMethodThread()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Hi from second thread");
        }

        static void thirdMainMethodThread()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Hi from third thread");
        }

    }
}
