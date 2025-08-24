namespace Wordarium.Core.Water;

class Water
{
    public Water()
    {
        
    }

    public void DrawWater()
    {
        // create freshwater, saltwater
        Console.BackgroundColor = ConsoleColor.Blue;
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