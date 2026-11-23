namespace Hangman;

internal class WordProvider
{
    private string[] _words =
    {
        "PROGRAM",
        "COMPUTER",
        "OBJECT",
        "VARIABLE",
        "METHOD"
    };

    public string GetRandomWord()
    {
        // Select and return a random word
        throw new NotImplementedException();
    }
}

internal class WordPuzzle
{
    private string _secretWord;

    private List<char> _guessedLetters = new();

    public WordPuzzle(string secretWord)
    {
        _secretWord = secretWord;
    }

    public bool GuessLetter(char letter)
    {
        // Check for duplicate guesses
        // Record new guesses
        // Return whether the letter exists
        throw new NotImplementedException();
    }

    public string GetVisibleWord()
    {
        // Return letters already guessed
        // Hide unguessed letters with underscores
        throw new NotImplementedException();
    }

    public bool IsSolved()
    {
        // Check whether every letter has been guessed
        throw new NotImplementedException();
    }
}

internal class HangmanGame
{
    private WordPuzzle _puzzle;

    public int RemainingAttempts { get; private set; }

    public HangmanGame(string secretWord)
    {
        _puzzle = new WordPuzzle(secretWord);

        RemainingAttempts = 5;
    }

    public void ProcessGuess(char letter)
    {
        // Ask WordPuzzle whether the guess is correct
        // Decrease attempts for a new incorrect guess
        // Check whether the player won or lost
    }

    public bool HasWon()
    {
        return _puzzle.IsSolved();
    }

    public bool HasLost()
    {
        return RemainingAttempts == 0;
    }
}

internal class HangmanDisplay
{
    public void ShowGame(HangmanGame game)
    {
        // Display the visible word
        // Display remaining attempts
        // Display incorrect guesses
    }

    public char GetGuess()
    {
        // Read a letter from the player
        throw new NotImplementedException();
    }
}