using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Dinos
{
    abstract class DinoBase
    {
        private readonly string _whichDino;
        private readonly string _whichEra;
        private readonly bool _isCarnivore;

        public string DinoName { get; protected set; }

        public DinoBase(string whichDino, string whichEra, bool isCarnivore)
        {
            _whichDino = whichDino.ToUpper();
            _whichEra = whichEra;
            _isCarnivore = isCarnivore;
        }

        public virtual void PrintDinos()
        {
            Console.WriteLine($"{_whichDino} lived during the {_whichEra} period.");
        }

        public void Carnivore()
        {
            if (_isCarnivore)
            {
                Console.WriteLine("This dinosaur was carnivorous.");
            }
            else
            {
                Console.WriteLine("This dinosaur was an herbivore.");
            }
        }
    }
}
