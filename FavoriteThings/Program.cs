using System;
using FavoriteThings.Dinos;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var utahraptor = new Utahraptor();

            var triceratops = new Triceratops();

            var stygimoloch = new Stygimoloch();

            var stegasaurus = new Stegosaurus();

            var dinos = new DinoBase[] { utahraptor, triceratops, stegasaurus, stygimoloch };

            foreach(var dino in dinos)
            {
                dino.PrintDinos();
                dino.Carnivore();
                Console.ReadLine();
            }
        }
    }
}
