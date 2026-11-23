namespace Rock_Paper_Scissors;

internal enum Choice
{
    Rock,
    Paper,
    Scissors
}

internal enum RoundResult
{
    Player1Wins,
    Player2Wins,
    Draw
}

internal class Player
{
    public string Name { get; }

    public Player(string name)
    {
        Name = name;
    }

    public Choice GetChoice()
    {
        // Obtain the human player's choice
        throw new NotImplementedException();
    }
}

internal class Round
{
    public Choice Player1Choice { get; }
    public Choice Player2Choice { get; }

    public Round(Choice player1Choice, Choice player2Choice)
    {
        Player1Choice = player1Choice;
        Player2Choice = player2Choice;
    }

    public RoundResult DetermineWinner()
    {
        // Compare both choices
        // Return Player1Wins, Player2Wins, or Draw
        throw new NotImplementedException();
    }
}

internal class Game
{
    public Player Player1 { get; }
    public Player Player2 { get; }

    public int Player1Wins { get; private set; }
    public int Player2Wins { get; private set; }
    public int Draws { get; private set; }

    public Game(Player player1, Player player2)
    {
        Player1 = player1;
        Player2 = player2;
    }

    public void PlayRound()
    {
        // 1. Get both players' choices
        // 2. Create a Round
        // 3. Determine the winner
        // 4. Update the scores
        // 5. Display the result
    }
}