using System.Dynamic;
using System.Threading;

namespace AquariumApp;

class Program
{
    static void Main(string[] args)
    {
        /*
        ConsoleUtility.Header("Welcome to Wordarium");
        Console.WriteLine("Let the critters swim!");
        ConsoleUtility.Footer();
        */

        // create app environment
        Console.CursorVisible = false;

        // set up aquarium
        int aquariumWidth = Console.WindowWidth;

        // create fish
        string shark = "> , ^ //0>";
        
        string minnow = ">, O>";
        string eel = ">--,----'----0>";
    
        
        
        string fishType = minnow;
        int fishSpeed = 4;
        int fishLength = fishType.Length;
        int aquariumSpace = aquariumWidth - fishLength;
        int leftPosition = 0;
        int rightPosition;
        
        
        while (true)
        {
            // clear screen before every draw
            Console.Clear();
            
            // set location of edge of fish and draw the fish
            Console.SetCursorPosition(leftPosition, 5);
            Console.Write(fish);
                
            // how often redraws occur
            Thread.Sleep(100);
                
            leftPosition += fishSpeed;
            rightPosition = leftPosition + fish.Length;
            if (rightPosition >= (aquariumSpace - 1))
            {
                leftPosition = 0;
            }
            
            //var key = Console.ReadKey(true).Key;
            //if (key == ConsoleKey.Escape) break;
        }
        
        

        
    }
}

class Aquarium
{
    public string aquarium = "";
    
    public Aquarium()
    {
        // constructor
    }

    public void DrawAqauarium()
    {
        // do something
    }
}

class Water
{
    public Water()
    {
        // constructor
    }

    public void DrawWater()
    {
        // create freshwater, saltwater
    }

    public void ClearTheWater()
    {
        // when water cleaning tablets are dropped in,
        // or algae eaters are introduced, or a 
        // tank cleaning occurs, the water becomes clearer
        // this makes it more likely that the fish see the food
        // being fed to them, and the health of the fish improves, but
        // it could make it more likely that a shark sees a fish and attacks it
    }

    public void DirtyTheWater()
    {
        // as the time between last cleaning increases and fish population increases
        // the water becomes dirtier.  This makes it less likely that fish will 
        // see the food being dropped into the water and increases the likelihood
        // that the fish get sicker
    }
}

public abstract class Fish
{
    // attributes
    public string Name { get; protected set; }
    public double Speed { get; protected set; }
    public (int X, int Y) Position { get; protected set; }
    
    // constructor
    protected Fish(string name, double speed, int startX, int startY)
    {
        Name = name;
        Speed = speed;
        Position = (startX, startY);
    }
    
    // abstract methods - must be overridden
    public abstract void Move(int maxWidth, int maxHeight);
    public abstract void Eat(string foodType);
    
    // shared helper
    public override string ToString()
    {
        return $"{Name} at ({Position.X}, {Position.Y}) Speed={Speed}";
    }
    
   
}