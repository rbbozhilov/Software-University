using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var clothes = new Dictionary<string, Dictionary<string, int>>();

            for(int i=0;i<n;i++)
            {

                string[] input = Console.ReadLine().Split(" -> ");
                string currentColor = input[0];
                string[] currentDress = input[1].Split(",");

                if(!clothes.ContainsKey(currentColor))
                {

                    clothes.Add(currentColor, new Dictionary<string, int>());
                    
                    foreach(var items in currentDress)
                    {

                        if(!clothes[currentColor].ContainsKey(items))
                        {
                            clothes[currentColor].Add(items, 0);
                        }

                        clothes[currentColor][items]++;

                    }

                }
                else
                {

                    foreach(var items in currentDress)
                    {

                        if(!clothes[currentColor].ContainsKey(items))
                        {
                            clothes[currentColor].Add(items, 0);
                        }
                        clothes[currentColor][items]++;
                    }

                }

            }

            string[] finder = Console.ReadLine().Split();
            string currentSearchedColor = finder[0];
            string currentSearchedDress = finder[1];
            bool flag = false;
            
            if(clothes.ContainsKey(currentSearchedColor) && clothes[currentSearchedColor].ContainsKey(currentSearchedDress))
            {
                flag = true;
            }


            foreach(var items in clothes)
            {

                Console.WriteLine("{0} clothes:",items.Key);

                if (flag)
                {
                    
                    foreach(var itens in items.Value)
                    {

                        if(items.Key==currentSearchedColor && itens.Key == currentSearchedDress)
                        {
                            Console.WriteLine("* {0} - {1} (found!)",itens.Key,itens.Value);
                        }
                        else
                        {
                            Console.WriteLine("* {0} - {1}", itens.Key, itens.Value);
                        }

                    }


                }
                else
                {
                    foreach (var itens in items.Value)
                    {

                        Console.WriteLine("* {0} - {1}", itens.Key, itens.Value);


                    }
                }

            }
            

        }
    }
}
