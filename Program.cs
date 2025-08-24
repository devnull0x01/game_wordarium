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
        

        // create app environment
        Console.CursorVisible = false;

        /* DEPRECATED CODE
        // set up aquarium
        int aquariumWidth = Console.WindowWidth;

        // create fish
        string shark = "}=^,=,=^=,///=0>";
        string sharkWord = "SHARK";
        
        string minnow = ">-,;-,((0>";
        string minnowWord = "MINNOW";
        
        string eel = ">==========,==0>";
        string eelWord = "EEL";
        
        
        string fishType = sharkWord;
        int fishSpeed = 3;
        int fishLength = fishType.Length;
        int aquariumSpace = aquariumWidth - fishLength;
        int leftPosition = 0;
        int rightPosition;
        DEPRECATED CODE */
        
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
            
        }
        
        //while (true)
        //{
            // clear screen before every draw
            //Console.Clear();
            
            // set location of edge of fish and draw the fish
            //Console.SetCursorPosition(leftPosition, 5);
            //Console.Write(fishType);
                
            // how often redraws occur
            //Thread.Sleep(200);
                
            /*
            leftPosition += fishSpeed;
            rightPosition = leftPosition + fishType.Length;
            if (leftPosition + fishLength >= aquariumWidth)
            {
                leftPosition = 0;
            }
            */
            
            // TODO: COULDN'T GET TO WORK
            //var key = Console.ReadKey(true).Key;
            //if (key == ConsoleKey.Escape) break;
        //}
    }
}