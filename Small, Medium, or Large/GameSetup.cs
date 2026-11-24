public static class GameSetup
{
    public static GameSize ChooseSize()
    {
        while (true)
        {
            ColoredText.WriteLine(
                "Choose your cavern size:",
                ConsoleColor.Magenta
            );

            Console.WriteLine("1. Small  (4 x 4)");
            Console.WriteLine("2. Medium (6 x 6)");
            Console.WriteLine("3. Large  (8 x 8)");

            Console.Write("Enter your choice: ");

            string? input = ColoredText.ReadLine();

            GameSize? size = input?.Trim().ToLowerInvariant() switch
            {
                "1" or "small" => GameSize.Small,

                "2" or "medium" => GameSize.Medium,

                "3" or "large" => GameSize.Large,

                _ => null
            };

            if (size.HasValue)
            {
                return size.Value;
            }

            if (input == null)
            {
                throw new InvalidOperationException(
                    "No game size was provided."
                );
            }

            ColoredText.WriteLine(
                "Invalid choice. Please try again.",
                ConsoleColor.Red
            );
        }
    }

    public static Cavern CreateCavern(GameSize size)
    {
        return size switch
        {
            GameSize.Small => new Cavern(
                4, 4,
                new Coordinate(0, 0),
                new Coordinate(0, 2)
            ),

            GameSize.Medium => new Cavern(
                6, 6,
                new Coordinate(0, 0),
                new Coordinate(3, 4)
            ),

            GameSize.Large => new Cavern(
                8, 8,
                new Coordinate(0, 0),
                new Coordinate(6, 6)
            ),

            _ => throw new ArgumentOutOfRangeException(
                nameof(size)
            )
        };
    }
}