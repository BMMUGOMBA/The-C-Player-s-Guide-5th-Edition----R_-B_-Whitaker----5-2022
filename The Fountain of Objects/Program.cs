internal class Program
{
    static void Main(string[] args)
    {
        Cavern cavern = new Cavern(4, 4);

        FountainGame game = new FountainGame(cavern);

        game.Run();
    }
}