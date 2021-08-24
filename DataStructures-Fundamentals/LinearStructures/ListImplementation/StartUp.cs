using System;
using System.Collections.Generic;

namespace ListImplementation
{
   public class StartUp
    {
        static void Main(string[] args)
        {

            var list = new List<int>(5);
            
            
            var myList = new MyList<int>();
            

            myList.Add(2);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(10);

            myList.Insert(2, 50);

            

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
          
        }
    }
}
