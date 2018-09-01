using System;
using FavoriteThings.Dinos;
using FavoriteThings.Dogs;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var utahraptor = new Utahraptor();

            var triceratops = new Triceratops();

            var stygimoloch = new Stygimoloch();

            var stegosaurus = new Stegosaurus();

            var dinos = new DinoBase[] { utahraptor, triceratops, stegosaurus, stygimoloch };

            var boxer = new Boxer();
            var rotweiler = new Rotweiler();
            var chihuahua = new Chihuahua();

            var dogs = new DogBase[] { boxer, rotweiler, chihuahua };

            Console.WriteLine("Do You want to learn about dogs or dinosaurs? (dog/dino)");

            string answer = Console.ReadLine();

            if (answer == "dino")
            {
                foreach (var dino in dinos)
                {
                    dino.PrintDinos();
                    dino.Carnivore();
                    Console.ReadLine();
                }
            } else if (answer == "dog")
            {
                foreach (var dog in dogs)
                {
                    dog.PrintDogs();
                    dog.Loyalty();
                    Console.ReadLine();
                }
            }
        }
    }
}
