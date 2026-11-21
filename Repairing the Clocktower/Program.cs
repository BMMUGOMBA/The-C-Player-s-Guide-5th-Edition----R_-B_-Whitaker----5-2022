namespace Repairing_the_Clocktower;

internal class Program
{
    static void Main(string[] args)
    {
        int number;
        string numberText;

        Console.Title="Controlling Clock Tower";
        Console.WriteLine("Enter Number");
        numberText = Console.ReadLine();
        number = Convert.ToInt32(numberText);

        if(number % 2 == 0)
        {
            Console.WriteLine("Tick");

        }
        else
             Console.WriteLine("Tock");

    }
}