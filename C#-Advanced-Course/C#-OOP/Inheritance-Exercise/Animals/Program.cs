using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string input = string.Empty;
            List<Animal> animals = new List<Animal>();

            while ((input = Console.ReadLine()) != "Beast!")
            {

                string currentAnimal = input;
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentName = tokens[0];
                int currentAge = int.Parse(tokens[1]);
                string currentGender = tokens[2];

               
                if (input == "Frog")
                {

                    Frog currentFrog = new Frog(currentName, currentAge, currentGender);

                    animals.Add(currentFrog);

                }

                else if (input == "Dog")
                {
                    Dog currentDog = new Dog(currentName, currentAge, currentGender);
                    animals.Add(currentDog);
                   

                }

                else if (input == "Cat")
                {
                    Cat currentCat = new Cat(currentName, currentAge, currentGender);
                    animals.Add(currentCat);
                   
                }

                else if (input == "Kitten")
                {
                    Kitten kitty = new Kitten(currentName, currentAge);
                    animals.Add(kitty);
                    
                   
                }

                else if (input == "Tomcat")
                {
                    Tomcat tom = new Tomcat(currentName, currentAge);
                    animals.Add(tom);
                  
                }

            }


            foreach(var items in animals)
            {
                Console.WriteLine(items.ToString());
            }


        }
    }
}
