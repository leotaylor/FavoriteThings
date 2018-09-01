using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Dinos
{
    class Stygimoloch : DinoBase
    {
        public bool isCarnivore { get; private set; } = false;

        public Stygimoloch() : base("Stygimoloch", "Early Cretacious")
        { }

        public override void Carnivore()
        {
            if (isCarnivore)
            {
                Console.WriteLine("This dino was carnivorous.");
            }
            else
            {
                Console.WriteLine("This dino was an herbivore.");
            }
        }
    }
}
