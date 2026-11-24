public class CommandParser
{
    public IGameCommand? Parse(string input)
    {
        return input.Trim().ToLowerInvariant() switch
        {
            "move north" =>
                new MoveCommand(Direction.North),

            "move south" =>
                new MoveCommand(Direction.South),

            "move east" =>
                new MoveCommand(Direction.East),

            "move west" =>
                new MoveCommand(Direction.West),

            "enable fountain" =>
                new EnableFountainCommand(),

            _ => null
        };
    }
}