internal class Pack
{
    private readonly InventoryItem?[] _items;

    public int MaxCount {get;}
    public double MaxWeight {get;}
    public double MaxVolume {get;}

    public int CurrentCount {get; private set;}
    public double CurrentWeight {get; private set;}
    public double CurrentVolume {get; private set;}

    public Pack(int maxCount, double maxWeight, double maxVolume)
    {
        MaxCount = maxCount;
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;

        _items  = new InventoryItem?[maxCount];
    }

    public bool Add(InventoryItem item)
    {
        if(CurrentCount >= MaxCount)
        {
            return false;
        }

        if(CurrentWeight + item.Weight > MaxWeight)
        {
            return false;
        }

        if(CurrentVolume + item.Volume > MaxVolume)
        {
            return false;
        }

        _items[CurrentCount] = item;

        CurrentCount++;
        CurrentWeight += item.Weight;
        CurrentVolume += item.Volume;

        return true;
    }
}