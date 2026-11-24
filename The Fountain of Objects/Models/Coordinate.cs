public readonly record struct Coordinate(int Row, int Column)
{
    public bool IsAdjacent(Coordinate other)
    {
        int rowDifference = Math.Abs(Row - other.Row);

        int columnDifference = Math.Abs(Column - other.Column);

        return rowDifference + columnDifference == 1;
    }

    public override string ToString()
    {
        return $"(Row={Row}, Column={Column})";
    }
}