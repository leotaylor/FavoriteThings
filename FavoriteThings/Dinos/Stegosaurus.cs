using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Dinos
{
    class Stegosaurus
    {
        public string Dino { get; private set; } = "Stegosaurus";
        public string TimePeriod { get; private set; } = "Late Jurasssic";
        public bool isCarnivore { get; private set; } = false;

        public void printTimePeriod()
        {
            Console.WriteLine($"{Dino} lived during the {TimePeriod} period.");
        }

        public void Carnivore()
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
