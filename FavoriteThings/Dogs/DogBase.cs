using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Dogs
{
    abstract class DogBase
    {
        readonly string _whichDog;
        readonly string _temperment;
        readonly bool _isLoyal;

        public string DinoName { get; protected set; }

        public DogBase(string whichDog, string temperment, bool isLoyal)
        {
            _whichDog = whichDog.ToUpper();
            _temperment = temperment;
            _isLoyal = isLoyal;
        }
        public virtual void PrintDogs()
        {
            Console.WriteLine($"The {_whichDog} is a {_temperment} dog.");
        }

        public void Loyalty()
        {
            if (_isLoyal)
            {
                Console.WriteLine("They are very loyal.");
            }
            else
            {
                Console.WriteLine("Little Sh*t.");
            }
        }
    }
}
