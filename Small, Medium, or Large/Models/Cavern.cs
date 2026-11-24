public class Cavern
{
    private readonly RoomType[,] _rooms;

    public int Rows { get; }
    public int Columns { get; }

    public Coordinate Entrance { get; }
    public Coordinate FountainLocation { get; }

    public Cavern(
        int rows,
        int columns,
        Coordinate entrance,
        Coordinate fountainLocation)
    {
        if (rows < 1 || columns < 1)
        {
            throw new ArgumentException(
                "Invalid cavern dimensions."
            );
        }

        Rows = rows;
        Columns = columns;

        _rooms = new RoomType[rows, columns];

        if (!IsInside(entrance) ||
            !IsInside(fountainLocation))
        {
            throw new ArgumentException(
                "Room location is outside the cavern."
            );
        }

        if (entrance == fountainLocation)
        {
            throw new ArgumentException(
                "The entrance and fountain cannot occupy the same room."
            );
        }

        Entrance = entrance;
        FountainLocation = fountainLocation;

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