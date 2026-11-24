
internal class Game
{
    private readonly Board _board;
    private readonly GameDisplay _display;
    private readonly Player _player1;
    private readonly Player _player2;

    private Player _currentPlayer;

    public Game(Player player1, Player player2)
    {
        _player1 = player1;
        _player2 = player2;

        _board = new Board();
        _display = new GameDisplay();

        _currentPlayer = _player1;
    }

    public void Play()
    {
        while (true)
        {
            _display.ShowBoard(_board);

            int position = _display.GetMove(_currentPlayer);

            if (position == 0)
                return;

            bool moveSuccessful =
                _board.PlaceMark(position, _currentPlayer.Symbol);

            if (!moveSuccessful)
            {
                _display.ShowMessage(
                    "Invalid move. Choose an available square.");

                continue;
            }

            GameResult result = _board.GetResult();

            if (result != GameResult.InProgress)
            {
                _display.ShowBoard(_board);

                if (result == GameResult.Draw)
                {
                    _display.ShowMessage("The game is a draw!");
                }
                else
                {
                    _display.ShowMessage(
                        $"{_currentPlayer.Name} wins!");
                }

                return;
            }

            SwitchPlayer();
        }
    }

    private void SwitchPlayer()
    {
        _currentPlayer = _currentPlayer == _player1
            ? _player2
            : _player1;
    }
}
