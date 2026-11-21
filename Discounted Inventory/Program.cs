namespace Buying_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string menu = "1 - Rope\n" +
                          "2 - Torches\n" +
                          "3 - Climbing Equipment\n" +
                          "4 - Clean Water\n" +
                          "5 - Machete\n" +
                          "6 - Canoe\n" +
                          "7 - Food Supplies";
            int userChoice = -1, itemPrice = -1;
            string itemName = "";
            string name="";
            
            
            Console.WriteLine(menu);
            Console.Write("What number do you want to see the price of? ");
            userChoice = Convert.ToInt32(Console.ReadLine());


            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("Enter your name");
                    name = Console.ReadLine();
                    if(name=="Batsi")
                    {
                    itemPrice = 10/2;
                    itemName = "Rope";
                    }     
                    else
                    itemPrice = 10;
                    itemName = "Rope";
                    break;
                case 2:
                     Console.WriteLine("Enter your name");
                    name = Console.ReadLine();
                    if(name=="Batsi")
                    {
                    itemPrice = 15/2;
                    itemName = "Torches";
                    } 
                    else
                    itemPrice = 15;
                    itemName = "Torches";
                    break;
                case 3:
                     Console.WriteLine("Enter your name");
                    name = Console.ReadLine();
                    if(name=="Batsi")
                    {
                    itemPrice = 25/2;
                    itemName = "Climbing Equipment";
                    } 
                    itemPrice = 25;
                    itemName = "Climbing Equipment";
                    break;
                case 4:
                     Console.WriteLine("Enter your name");
                    name = Console.ReadLine();
                    if(name=="Batsi")
                    {
                    itemPrice = 1/2;
                    itemName = "Clean Water";
                    } 
                    itemPrice = 1;
                    itemName = "Clean Water";
                    break;
                case 5:
                    Console.WriteLine("Enter your name");
                    name = Console.ReadLine();
                    if(name=="Batsi")
                    {
                    itemPrice = 20/2;
                    itemName = "Machete";
                    } 
                    itemPrice = 20;
                    itemName = "Machete";
                    break;
                case 6:
                    Console.WriteLine("Enter your name");
                    name = Console.ReadLine();
                    if(name=="Batsi")
                    {
                    itemPrice = 20/2;
                    itemName = "Canoe";
                    } 
                    itemPrice = 20;
                    itemName = "Canoe";
                    break;
                case 7:
                    Console.WriteLine("Enter your name");
                    name = Console.ReadLine();
                    if(name=="Batsi")
                    {
                    itemPrice = 1/2;
                    itemName = "Food Supplies";
                    } 
                    itemPrice = 1;
                    itemName = "Food Supplies";
                    break;
            }


            Console.WriteLine($"{itemName} costs {itemPrice} gold");





        }
    }
}