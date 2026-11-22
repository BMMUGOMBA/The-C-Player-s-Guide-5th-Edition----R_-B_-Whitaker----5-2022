namespace Simula_s_Test;

public enum Chest
{
    Open,
    Closed,
    Locked
}

internal class Program
{
    static void Main(string[] args)
    {
        Chest chest = Chest.Open;

string command;

while (true)
{
    if (chest == Chest.Open)
    {
        Console.Write("The chest is open. What do you want to do? ");
        command = Console.ReadLine();
        if (command == "close") chest = Chest.Closed;
    }
    else if (chest == Chest.Closed)
    {
        Console.Write("The chest is closed. What do you want to do? ");
        command = Console.ReadLine();
        if (command == "lock") { chest = Chest.Locked; }
        else if (command == "open") { chest = Chest.Open; }
    }
    else if (chest == Chest.Locked)
    {
        Console.Write("The chest is locked. What do you want to do? ");
        command = Console.ReadLine();
        if (command == "unlock") chest = Chest.Closed;
    }
}
    }
}