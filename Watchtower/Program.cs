namespace Watchtower;

internal class Program
{
    static void Main(string[] args)
    {
        int x;
        int y;
        
        Console.Title = "Watch Tower";
        Console.WriteLine("Input enemy coordinates");
        Console.WriteLine("Input x Coordinate");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input x Coordinate");
        y = Convert.ToInt32(Console.ReadLine());

        if(x ==0 )
        {
            if(y==0)
            {
                Console.WriteLine("The enemy is here");
            }
             if(y>0)
            {
                Console.WriteLine("The enemy is to the North");
            }
             if(y<0)
            {
                Console.WriteLine("The enemy is to the South");
            }
        } 

          if(x > 0 )
        {
            if(y==0)
            {
                Console.WriteLine("The enemy is to the East");
            }
             if(y>0)
            {
                Console.WriteLine("The enemy is to the North East");
            }
             if(y<0)
            {
                Console.WriteLine("The enemy is to the South East");
            }
        } 
          if(x <0 )
        {
            if(y==0)
            {
                Console.WriteLine("The enemy is to the West");
            }
             if(y>0)
            {
                Console.WriteLine("The enemy is to the North West");
            }
             if(y<0)
            {
                Console.WriteLine("The enemy is to the South West");
            }
        } 

    }
}