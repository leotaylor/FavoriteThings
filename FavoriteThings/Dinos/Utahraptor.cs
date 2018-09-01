using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Dinos
{
    class Utahraptor
    {
        public string Dino { get; private set; } = "Utahraptor";
        public string TimePeriod { get; private set; } = "Early Cretacious";
        public bool isCarnivore { get; private set; } = true;

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
