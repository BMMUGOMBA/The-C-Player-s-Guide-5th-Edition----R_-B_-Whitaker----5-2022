public readonly struct Coordinate
{
    public int Row { get; }
    public int Column { get; }

    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public bool IsAdjacent(Coordinate other)
    {
        int rowDifference = Math.Abs(Row - other.Row);

        int columnDifference = Math.Abs(Column - other.Column);

        return rowDifference + columnDifference == 1;
    }

    public override string ToString()
    {
        return $"({Row}, {Column})";
    }
}