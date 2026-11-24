
internal class Player
{
    public string Name { get; }
    public CellState Symbol { get; }

    public Player(string name, CellState symbol)
    {
        Name = name;
        Symbol = symbol;
    }
}
