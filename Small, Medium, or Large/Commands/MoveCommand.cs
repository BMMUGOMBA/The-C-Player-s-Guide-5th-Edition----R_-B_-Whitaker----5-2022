public class MoveCommand : IGameCommand
{
    private readonly Direction _direction;

    public MoveCommand(Direction direction)
    {
        _direction = direction;
    }

    public void Execute(FountainGame game)
    {
        game.MovePlayer(_direction);
    }
}