
internal class Program
{
    static void Main(string[] args)
    {
        Pack pack = new Pack(10, 15, 20);

        while (true)
        {
            Console.WriteLine();

            // Display the current pack contents.
            Console.WriteLine(pack.ToString());

            Console.WriteLine(
                $"Items: {pack.CurrentCount}/{pack.MaxCount}");

            Console.WriteLine(
                $"Weight: {pack.CurrentWeight:F2}/{pack.MaxWeight}");

            Console.WriteLine(
                $"Volume: {pack.CurrentVolume:F2}/{pack.MaxVolume}");

            Console.WriteLine();
            Console.WriteLine("1. Arrow");
            Console.WriteLine("2. Bow");
            Console.WriteLine("3. Rope");
            Console.WriteLine("4. Water");
            Console.WriteLine("5. Food Rations");
            Console.WriteLine("6. Sword");
            Console.WriteLine("0. Exit");

            Console.Write("What do you want to add? ");

            string? choice = Console.ReadLine();

            if (choice == "0" || choice == null)
            {
                break;
            }

            InventoryItem? item = choice switch
            {
                "1" => new Arrow(),
                "2" => new Bow(),
                "3" => new Rope(),
                "4" => new Water(),
                "5" => new FoodRations(),
                "6" => new Sword(),
                _ => null
            };

            if (item == null)
            {
                Console.WriteLine("Invalid selection.");
                continue;
            }

            bool added = pack.Add(item);

            if (added)
            {
                Console.WriteLine($"{item} successfully added.");
            }
            else
            {
                Console.WriteLine(
                    $"Cannot add {item}. Pack limit exceeded.");
            }
        }
    }
}
