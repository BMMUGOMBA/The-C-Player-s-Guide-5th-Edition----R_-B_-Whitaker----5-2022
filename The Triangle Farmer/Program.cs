namespace The_Triangle_Farmer;

internal class Program
{
    static void Main(string[] args)
    {

        double area;
        string baseh;
        string height;
        double b;
        double h;

        Console.WriteLine("Calculating Area of Triangle");
        Console.WriteLine("Enter Height");
        height = Console.ReadLine();
        Console.WriteLine("Enter base");
        baseh = Console.ReadLine();
        b= Convert.ToDouble(baseh);
        h= Convert.ToDouble(height);

        area = (b * h)/2;

        Console.WriteLine("The Area of the triangle is: " + area);

        



    }
}