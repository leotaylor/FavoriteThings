using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Dinos
{
    class Utahraptor : DinoBase
    {
        public bool isCarnivore { get; private set; } = true;

        public Utahraptor() : base("Utahraptor", "Early Cretacious")
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
