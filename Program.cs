using System.Dynamic;
using System.Threading;

namespace AquariumApp;
using Wordarium.Core.Critters;
using Wordarium.Core.Aquarium;
using Wordarium.Core.Water;
using Wordarium.Core.Aquarium;

class Program
{
    static void Main(string[] args)
    {
        // create cursorless environment
        Console.CursorVisible = false;
        
        // create aquarium
        int aquariumWidth = Console.WindowWidth;
        int aquariumHeight = Console.WindowHeight;
        //Console.WriteLine($"console width: {Console.WindowWidth}, height: {Console.WindowHeight}");
        Aquarium aquarium = new Aquarium(aquariumWidth, aquariumHeight);
        
        
        // create water
        Water water = new Water();
        
        // erratic fish movement
        Random rng = new Random();
        
        // create a critter
        WordCritter critter = new WordCritter("Goldfish", 100, 50);
        WordCritter critter2 = new WordCritter("Shark", 15, 20);
        //Console.WriteLine($"{critter.Name} at ({critter.X}, {critter.Y})");
        //Console.WriteLine($"{critter2.Name} at ({critter2.X}, {critter2.Y})");
        
        while (true)
        {
            Console.Clear();
            
            // draw the aquarium
            aquarium.DrawAquarium();
            
            // draw the water
            water.DrawWater();
            
            // draw the critters
            critter.Move(rng, aquarium.InnerWidth, aquarium.InnerHeight);
            critter2.Move(rng, aquarium.InnerWidth, aquarium.InnerHeight);
            
            critter.Draw();
            critter2.Draw();
            
            Thread.Sleep(200);
            
            //Console.ResetColor();
            
            // TODO: COULDN'T GET TO WORK
            //var key = Console.ReadKey(true).Key;
            //if (key == ConsoleKey.Escape) break;
        }
    }
}