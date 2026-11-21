namespace The_Four_Sisters_and_the_Duckbear;

internal class Program
{
    static void Main(string[] args)
    {
        /*
        3 kings Melik, Casik and Balik
        estate, dutch and province
        estate 1 point, dutch 3, province 6
        total = 1xestate + 3xdutch + 6 x province*/
        string EstateText;
        string DutchText;
        string ProvinceText;
        string kingName;
        int Estate;
        int Dutch;
        int Province;
        int Total;
        

        Console.WriteLine("Welcome to Kingdom Calculation Portal Enter Your Name");
        kingName = Console.ReadLine();
        Console.WriteLine("Hello King " + kingName + " Enter your number of your estates");
        EstateText= Console.ReadLine();
        Console.WriteLine("Hello King " + kingName + " Enter your number of your dutches");
        DutchText= Console.ReadLine();
        Console.WriteLine("Hello King " + kingName + " Enter your number of your provinces");
        ProvinceText= Console.ReadLine();

        Estate = Convert.ToInt16(EstateText);
        Dutch = Convert.ToInt16(DutchText);
        Province = Convert.ToInt16(ProvinceText);

        Total = Estate + 3 * Dutch + 6 * Province;

        Console.WriteLine("Hello King " + kingName + " you have a total of " + Total + " Kingdom points");


    }
}