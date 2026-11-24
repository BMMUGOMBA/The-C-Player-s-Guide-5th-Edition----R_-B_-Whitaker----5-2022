public class Cavern
{
    private readonly RoomType[,] _rooms;

    public int Rows { get; }
    public int Columns { get; }

    public Coordinate Entrance { get; }
    public Coordinate FountainLocation { get; }

    public Cavern(int rows, int columns)
    {
        if (rows < 1 || columns < 3)
        {
            throw new ArgumentException(
                "The cavern requires at least one row and three columns."
            );
        }

        Rows = rows;
        Columns = columns;

        _rooms = new RoomType[rows, columns];

        Entrance = new Coordinate(0, 0);

        FountainLocation = new Coordinate(0, 2);

        _rooms[Entrance.Row, Entrance.Column] =
            RoomType.Entrance;

        _rooms[FountainLocation.Row, FountainLocation.Column] =
            RoomType.Fountain;
    }

    public bool IsInside(Coordinate coordinate)
    {
        return coordinate.Row >= 0 &&
               coordinate.Row < Rows &&
               coordinate.Column >= 0 &&
               coordinate.Column < Columns;
    }

    public RoomType GetRoom(Coordinate coordinate)
    {
        return _rooms[coordinate.Row, coordinate.Column];
    }
}