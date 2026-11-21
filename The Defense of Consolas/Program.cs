namespace The_Four_Sisters_and_the_Duckbear;

internal class Program
{
    static void Main(string[] args)
    {
        /*
        Defense of Consolas
        The city is arranged in blocks, numbered like a chessboard. 
        The city’s only defense is a movable magical barrier, operated by a 
        squad of four that can protect a single city block by putting 
        themselves in each of the target’s four adjacent blocks, as shown in 
        the picture to the right.
        */
       int xCoordinate;
       int yCoordinate;
       string xCoordinateText;
       string yCoordinateText;

       
       Console.Title = "Defense of Consolas";
       Console.Write("Target Row? ");
       yCoordinateText = Console.ReadLine();
       Console.Write("Target Column? ");
       xCoordinateText = Console.ReadLine();

       xCoordinate = Convert.ToInt32(xCoordinateText);
       yCoordinate = Convert.ToInt32(yCoordinateText);

       int Upx = xCoordinate;
       int Upy = yCoordinate + 1;
       int Downx = xCoordinate ;
       int Downy = yCoordinate -1;
       int Leftx = xCoordinate-1;
       int Lefty = yCoordinate;
       int Rightx =xCoordinate +1;
       int Righty = yCoordinate;



       Console.WriteLine("Deploy to:");
       Console.ForegroundColor = ConsoleColor.DarkYellow;

       Console.WriteLine($"({Upy},{Upx})\n" +
                              $"({Downy},{Downx})\n" +
                              $"({Lefty},{Leftx})\n" +
                              $"({Righty},{Rightx})");
            
            Console.Beep();

    


    }
}