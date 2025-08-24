using System.Dynamic;
using System.Threading;

namespace AquariumApp;
using Wordarium.Core.Critters;
using Wordarium.Core.Aquarium;
using Wordarium.Core.Water;

class Program
{
    static void Main(string[] args)
    {
        // create cursorless environment
        Console.CursorVisible = false;
        
        // define the tank
        int aquariumWidth = Console.WindowWidth;
        int aquariumHeight = Console.WindowHeight;
        
        // define the water
        Water water = new Water();
        water.DrawWater();
        
        // create a random generator for movement
        Random rng = new Random();
        
        // create a critter
        WordCritter critter = new WordCritter("Goldfish", 100, 50);
        WordCritter critter2 = new WordCritter("Shark", 15, 20);
        //Console.WriteLine($"{critter.Name} at ({critter.X}, {critter.Y})");
        //Console.WriteLine($"{critter2.Name} at ({critter2.X}, {critter2.Y})");
        
        while (true)
        {
            Console.Clear();
            critter.Move(rng, aquariumWidth, aquariumHeight);
            critter.Draw();
            critter2.Move(rng, aquariumWidth, aquariumHeight);
            critter2.Draw();
            
            Thread.Sleep(200);
            
            // TODO: COULDN'T GET TO WORK
            //var key = Console.ReadKey(true).Key;
            //if (key == ConsoleKey.Escape) break;
        }
    }
}