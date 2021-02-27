using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
   public class Trainer
    {

        public Trainer(string name,Pokemon pokemon)
        {
            this.Pokemon = new List<Pokemon>();
            this.Name = name;
            this.Pokemon.Add(pokemon);
            this.NumberOfBadje = 0;
        }




        public string Name { get; set; }
        public int NumberOfBadje { get; set; }
        public List<Pokemon> Pokemon { get; set; }



    }
}
