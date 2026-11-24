public class FountainGame
{
    private readonly Cavern _cavern;
    private readonly Player _player;
    private readonly Fountain _fountain;
    private readonly CommandParser _commandParser;

    public FountainGame(Cavern cavern)
    {
        _cavern = cavern;

        _player = new Player(cavern.Entrance);

        _fountain = new Fountain();

        _commandParser = new CommandParser();
    }

    public bool HasWon =>
        _fountain.IsEnabled &&
        _player.Position == _cavern.Entrance;

    public void Run()
    {
        DisplayIntroduction();

        while (!HasWon)
        {
            DisplayRoom();

            ColoredText.Write(
                "What do you want to do? ",
                ConsoleColor.White
            );

            string? input = ColoredText.ReadLine();

            if (input == null)
            {
                return;
            }

            IGameCommand? command =
                _commandParser.Parse(input);

            if (command == null)
            {
                ColoredText.WriteLine(
                    "Invalid command. Try again.",
                    ConsoleColor.Red
                );

                continue;
            }

            command.Execute(this);
        }

        DisplayVictory();
    }

    public void MovePlayer(Direction direction)
    {
        Coordinate current = _player.Position;

        Coordinate destination = direction switch
        {
            Direction.North => current with
            {
                Row = current.Row - 1
            },

            Direction.South => current with
            {
                Row = current.Row + 1
            },

            Direction.East => current with
            {
                Column = current.Column + 1
            },

            Direction.West => current with
            {
                Column = current.Column - 1
            },

            _ => throw new ArgumentOutOfRangeException(
                nameof(direction)
            )
        };

        if (!_cavern.IsInside(destination))
        {
            ColoredText.WriteLine(
                "You cannot move in that direction. A wall blocks your path.",
                ConsoleColor.Red
            );

            return;
        }

        _player.MoveTo(destination);
    }

    public void EnableFountain()
    {
        RoomType currentRoom =
            _cavern.GetRoom(_player.Position);

        if (currentRoom != RoomType.Fountain)
        {
            ColoredText.WriteLine(
                "The Fountain of Objects is not in this room.",
                ConsoleColor.Red
            );

            return;
        }

        if (_fountain.IsEnabled)
        {
            ColoredText.WriteLine(
                "The fountain is already enabled.",
                ConsoleColor.Blue
            );

            return;
        }

        _fountain.Enable();

        ColoredText.WriteLine(
            "You have activated the Fountain of Objects!",
            ConsoleColor.Green
        );
    }

    private void DisplayRoom()
    {
        Console.WriteLine(new string('-', 75));

        ColoredText.WriteLine(
            $"You are in the room at {_player.Position}.",
            ConsoleColor.White
        );

        RoomType currentRoom =
            _cavern.GetRoom(_player.Position);

        switch (currentRoom)
        {
            case RoomType.Entrance:

                ColoredText.WriteLine(
                    "You see light in this room coming from outside the cavern. This is the entrance.",
                    ConsoleColor.Yellow
                );

                break;

            case RoomType.Fountain:

                if (_fountain.IsEnabled)
                {
                    ColoredText.WriteLine(
                        "You hear the rushing waters from the Fountain of Objects. It has been reactivated!",
                        ConsoleColor.Blue
                    );
                }
                else
                {
                    ColoredText.WriteLine(
                        "You hear water dripping in this room. The Fountain of Objects is here!",
                        ConsoleColor.Blue
                    );
                }

                break;
        }
    }

    private void DisplayIntroduction()
    {
        ColoredText.WriteLine(
            "THE FOUNTAIN OF OBJECTS",
            ConsoleColor.Magenta
        );

        ColoredText.WriteLine(
            "You enter a cavern filled with unnatural darkness.",
            ConsoleColor.Magenta
        );

        ColoredText.WriteLine(
            "Find the Fountain of Objects, enable it, and return to the entrance.",
            ConsoleColor.Magenta
        );

        Console.WriteLine();

        ColoredText.WriteLine(
            "Available commands:",
            ConsoleColor.White
        );

        Console.WriteLine("move north");
        Console.WriteLine("move south");
        Console.WriteLine("move east");
        Console.WriteLine("move west");
        Console.WriteLine("enable fountain");
    }

    private void DisplayVictory()
    {
        Console.WriteLine(new string('-', 75));

        ColoredText.WriteLine(
            $"You are in the room at {_player.Position}.",
            ConsoleColor.White
        );

        ColoredText.WriteLine(
            "The Fountain of Objects has been reactivated, and you have escaped with your life!",
            ConsoleColor.Magenta
        );

        ColoredText.WriteLine(
            "You win!",
            ConsoleColor.Green
        );
    }
}