using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Dinos
{
    abstract class DinoBase
    {
        private readonly string _whichDino;
        private readonly string _whichEra;

        public string DinoName { get; protected set; }

        public DinoBase(string whichDino, string whichEra)
        {
            _whichDino = whichDino.ToUpper();
            _whichEra = whichEra;
        }

        public virtual void PrintDinos()
        {
            Console.WriteLine($"{_whichDino} lived during the {_whichEra} period.");
        }

        public abstract void Carnivore();
    }
}
