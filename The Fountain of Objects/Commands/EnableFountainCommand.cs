public class EnableFountainCommand : IGameCommand
{
    public void Execute(FountainGame game)
    {
        game.EnableFountain();
    }
}