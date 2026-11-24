public static class ColoredText
{
    public static void WriteLine(
        string message,
        ConsoleColor color)
    {
        ConsoleColor previousColor =
            Console.ForegroundColor;

        try
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);
        }
        finally
        {
            Console.ForegroundColor = previousColor;
        }
    }

    public static void Write(
        string message,
        ConsoleColor color)
    {
        ConsoleColor previousColor =
            Console.ForegroundColor;

        try
        {
            Console.ForegroundColor = color;

            Console.Write(message);
        }
        finally
        {
            Console.ForegroundColor = previousColor;
        }
    }

    public static string? ReadLine()
    {
        ConsoleColor previousColor =
            Console.ForegroundColor;

        try
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            return Console.ReadLine();
        }
        finally
        {
            Console.ForegroundColor = previousColor;
        }
    }
}