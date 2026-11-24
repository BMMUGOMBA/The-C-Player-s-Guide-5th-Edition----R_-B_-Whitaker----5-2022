public class Player
{
    public Coordinate Position{ get; private set;}
    
    public Player(Coordinate startingPosition)
    {
        Position = startingPosition;
    }

    public void MoveTo(Coordinate coordinate)
    {
        Position = coordinate;
    }
}