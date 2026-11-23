namespace _15_Puzzle;

internal class Tile
{
    public int Number { get; }

    public Tile(int number)
    {
        Number = number;
    }
}

internal class PuzzleBoard
{
    private Tile?[,] _tiles;

    public int Rows { get; }
    public int Columns { get; }

    public PuzzleBoard(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;

        _tiles = new Tile?[rows, columns];
    }

    public bool MoveTile(int row, int column)
    {
        // Check if tile is adjacent to empty space
        // Swap tile with empty space if valid
        throw new NotImplementedException();
    }

    public bool IsSolved()
    {
        // Check whether tiles are in order
        throw new NotImplementedException();
    }

    public void Shuffle()
    {
        // Generate a solvable arrangement
        throw new NotImplementedException();
    }
}

internal class PuzzleGame
{
    public PuzzleBoard Board { get; }

    public int MoveCount { get; private set; }

    public PuzzleGame(int rows, int columns)
    {
        Board = new PuzzleBoard(rows, columns);
        MoveCount = 0;
    }

    public void Play()
    {
        // Start and manage the game
        throw new NotImplementedException();
    }
}

internal class PuzzleDisplay
{
    public void ShowBoard(PuzzleBoard board)
    {
        // Display tiles in a grid
        throw new NotImplementedException();
    }

    public void ShowMoveCount(int moves)
    {
        Console.WriteLine($"Moves: {moves}");
    }

    public void ShowVictory()
    {
        Console.WriteLine("Congratulations! You solved the puzzle.");
    }
}