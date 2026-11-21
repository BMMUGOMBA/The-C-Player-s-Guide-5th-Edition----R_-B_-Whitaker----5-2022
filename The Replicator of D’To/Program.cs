namespace The_Replicator_of_D_To;

internal class Program
{
    static void Main (string [] args)
    {
        int[] StoreA = new int[5]; 
        int[] StoreB = new int[5]; 
        int temp;

        for(int index= 0; index < StoreA.Length;)
        {
            Console.WriteLine("Enter Number for index " + index);
            temp = Convert.ToInt32(Console.ReadLine());
            StoreA[index] = temp;
            index ++;
            
        }
        
        for(int index= 0; index < StoreA.Length;)
        {
            Console.WriteLine("Copying from A to B " + index);
            
            StoreB[index] = StoreA[index];
            index ++;
            
        }

        Console.WriteLine("Printing Array A ");

        for(int index= 0; index < StoreA.Length;)
        {
            
            
            Console.WriteLine(StoreA[index]);
            index ++;
            
        }

        Console.WriteLine("Printing Array B ");
        
        for(int index= 0; index < StoreB.Length;)
        {
            
            
            Console.WriteLine(StoreB[index]);
            index ++;
            
        }

        

    }
}