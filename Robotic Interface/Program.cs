
internal class Program
{
    static void Main(string[] args)
    {
        Robot robot = new Robot();

        Console.WriteLine("Program your robot.");
        Console.WriteLine("Available commands:");
        Console.WriteLine("on, off, north, south, east, west");

        for (int i = 0; i < robot.Commands.Length; i++)
        {
            while (true)
            {
                Console.Write($"Enter command {i + 1}: ");

                string? input = Console.ReadLine();

                if (input == null)
                {
                    return;
                }

                IRobotCommand? command = input.Trim()
                    .ToLower() switch
                {
                    "on" => new OnCommand(),
                    "off" => new OffCommand(),
                    "north" => new NorthCommand(),
                    "south" => new SouthCommand(),
                    "east" => new EastCommand(),
                    "west" => new WestCommand(),
                    _ => null
                };

                if (command == null)
                {
                    Console.WriteLine("Invalid command.");
                    continue;
                }

                robot.Commands[i] = command;

                break;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Executing commands:");

        robot.Run();
    }
}
