internal class Program
{
    static void Main(string[] args)
    {
        Sword original = new Sword(
            Material.Iron,
            Gemstone.None,
            100,
            20
        );

        Sword variation1 = original with
        {
            Material = Material.Steel,
            Gemstone = Gemstone.Emerald
        };

        Sword variation2 = original with
        {
            Material = Material.Binarium,
            Gemstone = Gemstone.Bitstone,
            Length = 120,
            CrossguardWidth = 25
        };

        Console.WriteLine(original);
        Console.WriteLine(variation1);
        Console.WriteLine(variation2);
    }
}