using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Dinos
{
    class Triceratops : DinoBase
    {
        public bool isCarnivore { get; private set; } = false;

        public Triceratops() : base("Triceratops", "Late Cretacious")
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
