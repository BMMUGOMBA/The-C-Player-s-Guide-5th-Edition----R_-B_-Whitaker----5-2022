namespace The_Four_Sisters_and_the_Duckbear;

internal class Program
{
    static void Main(string[] args)
    {
        int collectedEggs;
        string collectdEggsText;
        int numberOfSisters = 4;
        int sisterShare;
        int duckBearShare;

        Console.WriteLine("Enter Number of Eggs Collected");
        collectdEggsText = Console.ReadLine();

        collectedEggs = Convert.ToInt16(collectdEggsText);
        sisterShare = collectedEggs / numberOfSisters;
        duckBearShare = collectedEggs % numberOfSisters;
        
        Console.WriteLine("The number of eggs collected is " + collectdEggsText + " and each sister gets " + sisterShare + " and duckbear gets " + duckBearShare);
    }
}