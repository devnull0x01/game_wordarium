namespace Wordarium.Core.Aquarium;


public class Aquarium
{
    private int requestedWidth;
    private int requestedHeight;
    
    // These are the actual inner dimensions used after clamping.
    public int InnerWidth  { get; private set; }
    public int InnerHeight { get; private set; }
    
    public Aquarium(int aquariumWidth, int aquariumHeight)
    {
        requestedWidth = aquariumWidth;
        requestedHeight = aquariumHeight;
    }

    public void DrawAquarium()
    {
        // Ensure we don't draw on the last column/row to avoid auto-wrap.
        int winW = Console.WindowWidth;   // columns are 0..winW-1
        int winH = Console.WindowHeight;  // rows    are 0..winH-1

        // Borders take 2 columns/rows; also leave 1 column/row margin on the right/bottom.
        InnerWidth  = Math.Max(1, Math.Min(requestedWidth,  winW - 3)); // (winW-2 is right border; -1 more to avoid wrap)
        InnerHeight = Math.Max(1, Math.Min(requestedHeight, winH - 3)); // (winH-2 is bottom border; -1 more to avoid wrap)

        int right  = 1 + InnerWidth;   // x of right border
        int bottom = 1 + InnerHeight;  // y of bottom border

        Console.Clear();

        var old = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.White;

        // Top border
        Console.SetCursorPosition(0, 0);
        Console.Write("+");
        for (int x = 1; x <= InnerWidth; x++) Console.Write("-");
        Console.Write("+");

        // Sides
        for (int y = 1; y <= InnerHeight; y++)
        {
            Console.SetCursorPosition(0, y);
            Console.Write("|");
            Console.SetCursorPosition(right, y);
            Console.Write("|");
        }

        // Bottom border
        Console.SetCursorPosition(0, bottom);
        Console.Write("+");
        for (int x = 1; x <= InnerWidth; x++) Console.Write("-");
        Console.Write("+");

        Console.ForegroundColor = old;
    }
    
    // Example helper for drawing inside the tank without touching the border
    public void DrawInside(int x, int y, char ch, ConsoleColor color)
    {
        // Clamp to inner area (1..width, 1..height)
        if (x < 1 || x > InnerHeight || y < 1 || y > InnerWidth) return;
        var old = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.SetCursorPosition(x, y);
        Console.Write(ch);
        Console.ForegroundColor = old;
    }
}