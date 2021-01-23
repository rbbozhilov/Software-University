using System;
using System.Linq;

namespace The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int[] lift = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool flag = false;

            for (int i = 0; i < lift.Length; i++)
            {

                while (lift[i] != 4)
                {
                    people--;
                    lift[i]++;

                    if (people == 0)
                    {
                        flag = true;
                        break;
                    }

                }

                if (flag)
                {
                    break;
                }

            }


            if (flag)
            {

                bool emptyLift = false;

                for (int i = 0; i < lift.Length; i++)
                {
                    if (lift[i] != 4)
                    {
                        emptyLift = true;
                        break;
                    }
                }

                if (emptyLift)
                {
                    Console.WriteLine("The lift has empty spots!");

                }


            }
            else
            {
                Console.WriteLine("There isn't enough space! {0} people in a queue!", people);
            }

            Console.WriteLine(string.Join(" ", lift));
        }
    }
}
