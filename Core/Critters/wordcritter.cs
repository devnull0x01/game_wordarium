namespace Wordarium.Core.Critters;

public class WordCritter
{
    public string Name { get; protected set; }
    public int X { get; set; }
    public int Y { get; set; }
    
    public ConsoleColor Color = ConsoleColor.Yellow;

    public WordCritter(string name, int x, int y)
    {
        Name = name;
        X = x;
        Y = y;
    }
    
    public void Move(Random rng, int borderWidth, int borderHeight)
    {
        //Console.Write($"{Name} is moving");
        int movementX = rng.Next(-1, 2 );
        int movementY = rng.Next(-1, 2 );
        
        X += movementX;
        Y += movementY;
        
        X = Math.Clamp(X, 0, borderWidth - 1);
        Y = Math.Clamp(Y, 0, borderHeight - 1);
    }

    public void Draw()
    {
        //Console.Write($"{Name} is drawing at  ({X}, {Y})");
        Console.SetCursorPosition(X, Y);
        Console.ForegroundColor = Color;
        Console.Write(Name);
    }
}
