using System.Security.Cryptography.X509Certificates;

namespace The_Locked_Door;

internal enum DoorState
{
    Open,
    Closed,
    Locked
}

internal class Door
{
    private int _passcode;
    public DoorState State {get; private set;}

    public Door(int passcode)
    {
        _passcode = passcode;
        State = DoorState.Closed;
    }

    public bool Open()
    {
        if(State != DoorState.Closed)
            return false;

        State = DoorState.Open;
        return true;
        
    }

    public bool Close()
    {
        if(State != DoorState.Open)
            return false;

        State = DoorState.Closed;
        return true;
    }

    public bool Lock()
    {
        if(State != DoorState.Closed)
            return false;
        
        State = DoorState.Locked;
        return true;
    }

    public bool Unlock(int passcode)
    {
        if(State != DoorState.Locked || passcode != _passcode)
            return false;

        State = DoorState.Closed;
        return true;
    }

    public bool ChangePasscode(int currentCode, int newCode )
    {
        if(currentCode != _passcode)
            return false;

        _passcode = newCode;
        return true;
    }
}


internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter starting passcode: ");
        int passcode = int.Parse(Console.ReadLine()!);

        Door door = new Door(passcode);

        while (true)
        {
            Console.WriteLine($"\nDoor state: {door.State}");
            Console.Write("Command (open, close, lock, unlock, change, exit): ");

            string command = Console.ReadLine()!.ToLower();

            switch (command)
            {
                case "open":
                    Console.WriteLine(door.Open()
                        ? "Door opened."
                        : "Cannot open the door.");
                    break;

                case "close":
                    Console.WriteLine(door.Close()
                        ? "Door closed."
                        : "Cannot close the door.");
                    break;

                case "lock":
                    Console.WriteLine(door.Lock()
                        ? "Door locked."
                        : "Cannot lock the door.");
                    break;

                case "unlock":
                    Console.Write("Enter passcode: ");
                    int unlockCode = int.Parse(Console.ReadLine()!);

                    Console.WriteLine(door.Unlock(unlockCode)
                        ? "Door unlocked."
                        : "Incorrect code or door not locked.");
                    break;

                case "change":
                    Console.Write("Current passcode: ");
                    int current = int.Parse(Console.ReadLine()!);

                    Console.Write("New passcode: ");
                    int next = int.Parse(Console.ReadLine()!);

                    Console.WriteLine(door.ChangePasscode(current, next)
                        ? "Passcode changed."
                        : "Incorrect current passcode.");
                    break;

                case "exit":
                    return;

                default:
                    Console.WriteLine("Unknown command.");
                    break;
            }
        }
    }
}
