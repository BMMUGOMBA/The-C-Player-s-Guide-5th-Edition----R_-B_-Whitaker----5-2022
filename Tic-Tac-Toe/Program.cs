
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        Console.Write("Enter Player 1 name: ");
        string player1Name = Console.ReadLine() ?? "Player 1";

        Console.Write("Enter Player 2 name: ");
        string player2Name = Console.ReadLine() ?? "Player 2";

        Player player1 = new Player(player1Name, CellState.X);
        Player player2 = new Player(player2Name, CellState.O);

        Game game = new Game(player1, player2);

        game.Play();
    }
}
