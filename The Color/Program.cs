using System.Net;

namespace The_Color;

internal class Color
{
    // RGB Channel properties
    public byte Red {get;}
    public byte Green {get;}
    public byte Blue {get;}

    //Constructor
    public Color(byte red, byte green, byte blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    //parameterless constructor (black)
    public Color() : this (0,0,0)
    {
        
    }

    //eight predefined colors
    public static Color White => new Color(255,255,255);
    public static Color Black => new Color(0,0,0);
    public static Color RedColor => new Color(255,0,0);
    public static Color Orange => new Color(255,165,0);
    public static Color Yellow => new Color(255,255,0);
    public static Color GreenColor = new Color(0,128,0);
    public static Color BlueColor = new Color(0,0,255);
    public static Color Purple = new Color(128,0,128);
}

internal class Program
{
    public static void Main(string[] args)
    {
        ///create a custom color using constructor
        Color customColor = new Color(255, 165, 0);

        //Get a predefined color usin a static property
        Color predefinedColor = Color.Purple;

        Console.WriteLine("Custom Color: ");
        Console.WriteLine($"R: {customColor.Red}");
        Console.WriteLine($"G: {customColor.Green}");
        Console.WriteLine($"B: {customColor.Blue}");

        Console.WriteLine("Predefined Color: ");
        Console.WriteLine($"R: {predefinedColor.Red}");
        Console.WriteLine($"G: {predefinedColor.Green}");
        Console.WriteLine($"B: {predefinedColor.Blue}");
    }
}