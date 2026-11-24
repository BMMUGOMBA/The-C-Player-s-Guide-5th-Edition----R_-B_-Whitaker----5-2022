internal class Program
{
    static void Main(string[] args)
    {
        GameSize size = GameSetup.ChooseSize();

        Cavern cavern = GameSetup.CreateCavern(size);

        FountainGame game = new FountainGame(cavern);

        game.Run();
    }
}