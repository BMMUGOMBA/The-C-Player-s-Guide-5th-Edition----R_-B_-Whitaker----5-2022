
internal class GameDisplay
{
    public void ShowBoard(Board board)
    {
        Console.WriteLine();

        for (int row = 0; row < 3; row++)
        {
            for (int column = 0; column < 3; column++)
            {
                int position = row * 3 + column + 1;

                CellState square = board.GetSquare(position);

                string value = square == CellState.Empty
                    ? position.ToString()
                    : square.ToString();

                Console.Write($" {value} ");

                if (column < 2)
                    Console.Write("|");
            }

            Console.WriteLine();

            if (row < 2)
                Console.WriteLine("---+---+---");
        }

        Console.WriteLine();
    }

    public int GetMove(Player player)
    {
        while (true)
        {
            Console.Write(
                $"{player.Name} ({player.Symbol}), choose a square (1-9): ");

            string? input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("Input ended.");
                return 0;
            }

            if (int.TryParse(input, out int position))
                return position;

            Console.WriteLine("Please enter a number.");
        }
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}
