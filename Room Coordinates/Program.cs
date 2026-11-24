internal class Program
{
    static void Main(string[] args)
    {
        Coordinate room1 = new Coordinate(2, 2);
        Coordinate room2 = new Coordinate(2, 3);
        Coordinate room3 = new Coordinate(3, 2);
        Coordinate room4 = new Coordinate(3, 3);
        Coordinate room5 = new Coordinate(4, 2);
        Coordinate room6 = new Coordinate(2, 2);

        Console.WriteLine(room1.IsAdjacent(room2));
        Console.WriteLine(room1.IsAdjacent(room3));
        Console.WriteLine(room1.IsAdjacent(room4));
        Console.WriteLine(room1.IsAdjacent(room5));
        Console.WriteLine(room1.IsAdjacent(room6));
    }
}