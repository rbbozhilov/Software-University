using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string command = string.Empty;
            List<Trainer> trainers = new List<Trainer>();

            while((command=Console.ReadLine()) != "Tournament")
            {

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentTrainerName = tokens[0];
                string currentPokemonName = tokens[1];
                string currentPokemonElement = tokens[2];
                int currentPokemonHealth = int.Parse(tokens[3]);

                Pokemon currentPokemon = new Pokemon(currentPokemonName, currentPokemonElement, currentPokemonHealth);
                Trainer currentTrainer = trainers.FirstOrDefault(x => x.Name == currentTrainerName);

                if (currentTrainer != null)
                {
                    currentTrainer.Pokemon.Add(currentPokemon);
                }
                else
                {
                    trainers.Add(new Trainer(currentTrainerName, currentPokemon));
                }
                
               
            }
            bool flag = false;
            string secondCommand = string.Empty;

            while((secondCommand=Console.ReadLine()) !="End")
            {

                IsItHave(trainers, secondCommand);

            }

            trainers = trainers.OrderByDescending(x => x.NumberOfBadje).ToList();

            foreach(var items in trainers)
            {

                Console.WriteLine("{0} {1} {2}",items.Name,items.NumberOfBadje,items.Pokemon.Count);

            }


        }

        static void IsItHave(List<Trainer> currentTrainer,string command )
        {

            bool flag = false;

            if (command == "Fire")
            {

                foreach (var items in currentTrainer)
                {

                    foreach (var itens in items.Pokemon)
                    {
                        if (itens.Element == "Fire")
                        {
                            Trainer trainer = items;

                            flag = true;
                            trainer.NumberOfBadje++;
                            break;
                        }
                    }

                    if(flag)
                    {
                        flag = false;
                        continue;

                    }
                    else
                    {
                        for(int i=0;i<items.Pokemon.Count;i++)
                        { 

                            Trainer trainer = items;
                            Pokemon currentPokemon = items.Pokemon[i];
                            currentPokemon.Health -= 10;

                            if(currentPokemon.Health<=0)
                            {
                                trainer.Pokemon.Remove(currentPokemon);
                            }


                        }
                    }

                }
            }
            else if (command == "Water")
            {

                foreach (var items in currentTrainer)
                {

                    foreach (var itens in items.Pokemon)
                    {
                        if (itens.Element == "Water")
                        {
                            Trainer trainer = items;

                            flag = true;
                            trainer.NumberOfBadje++;
                            break;
                        }
                    }

                    if (flag)
                    {
                        flag = false;
                        continue;

                    }
                    else
                    {
                        for(int i=0;i<items.Pokemon.Count;i++)
                        { 

                            Trainer trainer = items;
                            Pokemon currentPokemon = items.Pokemon[i];
                            currentPokemon.Health -= 10;

                            if (currentPokemon.Health <= 0)
                            {
                                trainer.Pokemon.Remove(currentPokemon);
                            }


                        }
                    }

                }
            }
            else if (command == "Electricity")
            {

                foreach (var items in currentTrainer)
                {

                    foreach (var itens in items.Pokemon)
                    {
                        if (itens.Element == "Electricity")
                        {
                            Trainer trainer = items;

                            flag = true;
                            trainer.NumberOfBadje++;
                            break;
                        }
                    }

                    if (flag)
                    {
                        flag = false;
                        continue;

                    }
                    else
                    {
                        
                        for(int i=0;i<items.Pokemon.Count;i++)
                        { 
                       

                            Trainer trainer = items;
                            Pokemon currentPokemon = items.Pokemon[i];
                            currentPokemon.Health -= 10;

                            if (currentPokemon.Health <= 0)
                            {
                                trainer.Pokemon.Remove(currentPokemon);
                            }


                        }
                    }

                }
            }


            
        }


    }
}
