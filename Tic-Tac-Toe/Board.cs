
internal class Board
{
    private readonly CellState[] _squares = new CellState[9];

    private static readonly int[,] WinningLines =
    {
        { 0, 1, 2 },
        { 3, 4, 5 },
        { 6, 7, 8 },
        { 0, 3, 6 },
        { 1, 4, 7 },
        { 2, 5, 8 },
        { 0, 4, 8 },
        { 2, 4, 6 }
    };

    public CellState GetSquare(int position)
    {
        return _squares[position - 1];
    }

    public bool PlaceMark(int position, CellState symbol)
    {
        if (position < 1 || position > 9)
            return false;

        if (symbol == CellState.Empty)
            return false;

        int index = position - 1;

        if (_squares[index] != CellState.Empty)
            return false;

        _squares[index] = symbol;
        return true;
    }

    public GameResult GetResult()
    {
        for (int line = 0; line < 8; line++)
        {
            int a = WinningLines[line, 0];
            int b = WinningLines[line, 1];
            int c = WinningLines[line, 2];

            if (_squares[a] == CellState.Empty)
                continue;

            if (_squares[a] == _squares[b] &&
                _squares[b] == _squares[c])
            {
                return _squares[a] == CellState.X
                    ? GameResult.XWins
                    : GameResult.OWins;
            }
        }

        foreach (CellState square in _squares)
        {
            if (square == CellState.Empty)
                return GameResult.InProgress;
        }

        return GameResult.Draw;
    }
}
