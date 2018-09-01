using System;
using FavoriteThings.Dinos;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var utahraptor = new Utahraptor();
            utahraptor.printTimePeriod();
            utahraptor.Carnivore();
            Console.WriteLine();
            Console.ReadLine();

            var triceratops = new Triceratops();
            triceratops.printTimePeriod();
            triceratops.Carnivore();
            Console.WriteLine();
            Console.ReadLine();

            var stygimoloch = new Stygimoloch();
            stygimoloch.printTimePeriod();
            stygimoloch.Carnivore();
            Console.WriteLine();
            Console.ReadLine();

            var stegasaurus = new Stegosaurus();
            stegasaurus.printTimePeriod();
            stegasaurus.Carnivore();
            Console.ReadLine();
        }
    }
}
