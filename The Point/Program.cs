namespace The_Point;

internal class Point
{
    public int X {get;}
    public int Y {get;}

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point()
    {
        X = 0;
        Y = 0;
    }
}

internal class Program
{
    public static void Main (string[] args)
    {
        Point point1 = new Point(2,3);
        Point point2 = new Point(-4,0);

        Console.WriteLine($"({point1.X},{point1.Y})");
        Console.WriteLine($"({point2.X},{point2.Y})");

        Point origin = new Point();
        Console.WriteLine($"{origin.X},{origin.Y}");
    }
}