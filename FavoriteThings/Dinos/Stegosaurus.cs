using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Dinos
{
    class Stegosaurus : DinoBase
    {
        public bool isCarnivore { get; private set; } = false;

        public Stegosaurus() : base("Stegosaurus", "Late Jurassic")
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
