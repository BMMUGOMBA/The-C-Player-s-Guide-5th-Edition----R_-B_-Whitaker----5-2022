namespace Vin_Fletcher_s_Arrows;

public enum arrowhead
{
    steel,
    wood,
    obsidian
}

public enum fletchings
{
    plastic,
    turkey,
    goose
}

public class Arrow
{
    float length;
    float lengthunitcost;
    float arrowunitcost;
    float fletchinunitcost;
    arrowhead _arrowhead;
    fletchings _fletchings;
    
    public Arrow()
    {
        this.length =0;
        this.lengthunitcost =0.05f;
        this.arrowunitcost = 0;
        this.fletchinunitcost = 0;
        this._arrowhead= arrowhead.obsidian;
        this._fletchings = fletchings.plastic;

    }

    public float GetCost()
    {   
        float cost;
        length = GetLength();
        lengthunitcost = 0.05f;
        _arrowhead = GetArrowhead();
        _fletchings = Getfletchings();
        //arrowhead arrow = GetArrowhead();

        if(_arrowhead == arrowhead.steel)
        {
            arrowunitcost = 10;
        }
        if(_arrowhead == arrowhead.wood)
        {
            arrowunitcost = 3;
        }
        if(_arrowhead == arrowhead.obsidian)
        {
            arrowunitcost = 5;
        }
        
        if(_fletchings == fletchings.plastic)
        {
            fletchinunitcost = 10;
        }
        if(_fletchings == fletchings.turkey)
        {
            fletchinunitcost = 5;
        }
        if(_fletchings == fletchings.goose)
        {
            fletchinunitcost = 3;
        }

        cost = lengthunitcost * length + arrowunitcost + fletchinunitcost;

        return cost;
    }

    private float GetLength()
            {
                float user = 0.0f;
                bool pass = false;

                do
                {
                    Console.WriteLine("enter length of shaft");
                    user = Convert.ToSingle(Console.ReadLine()); //skipping over try catch
                    if (user >= 60.0 || user <= 100.0 )
                    {
                        pass = true;
                    }
                    else
                    {
                        Console.WriteLine("please enter a range of 60.0 - 100.0");
                    }
                    
                } while (!pass);


                return user;

            }
            
            
            

            private fletchings Getfletchings()
            {
                fletchings userPick = fletchings.goose;
                bool pass = false;

                do
                {
                    Console.WriteLine("pick fletching type:");
                    Console.WriteLine($"\t{fletchings.goose}\n\t{fletchings.plastic}\n\t{fletchings.turkey}");

                    string user = Console.ReadLine();

                    if (user == fletchings.goose.ToString() )
                    {
                        pass = true;
                        userPick = fletchings.goose;
                    }
                    else if (user == fletchings.plastic.ToString())
                    {
                        pass = true;
                        userPick = fletchings.plastic;
                    }
                    else if (user == fletchings.turkey.ToString())
                    {
                        pass = true;
                        userPick = fletchings.turkey;
                    }
                    else
                    {
                        Console.WriteLine("Not a option, pick again");
                    }
                    
                } while (!pass);

                return userPick;
            }
            
            
            
            
            private arrowhead GetArrowhead()
            {
                arrowhead userPick = arrowhead.steel;
                bool pass = false;

                do
                {
                    Console.WriteLine("pick arrow head type:");
                    Console.WriteLine($"\t{arrowhead.wood}\n\t{arrowhead.steel}\n\t{arrowhead.obsidian}");

                    string user = Console.ReadLine();

                    if (user == arrowhead.wood.ToString() )
                    {
                        pass = true;
                        userPick = arrowhead.wood;
                    }
                    else if (user == arrowhead.steel.ToString())
                    {
                        pass = true;
                        userPick = arrowhead.steel;
                    }
                    else if (user == arrowhead.obsidian.ToString())
                    {
                        pass = true;
                        userPick = arrowhead.obsidian;
                    }
                    else
                    {
                        Console.WriteLine("Not a option, pick again");
                    }
                    
                } while (!pass);

                return userPick;
            } 
}

internal class Program
{
    public static void Main(string[] args)
    {
            Console.WriteLine("Hello World!");
            Arrow Arrow = new Arrow();
            Console.WriteLine($"total cost of the arrow is {Arrow.GetCost()}");
    }
}