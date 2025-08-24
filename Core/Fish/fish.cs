namespace Wordarium.Core.Fish;

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
