namespace The_Card;

internal enum CardColor
{
    Red,
    Green,
    Blue,
    Yellow
}

internal enum CardRank
{
    One = 1,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Dollar,
    Percent,
    Caret,
    Ampersand
}

internal class Card
{
    public CardColor Color { get;}
    public CardRank Rank {get;}

    public Card(CardColor color, CardRank rank)
    {
        Color = color;
        Rank = rank;
    }

    public bool IsNumber()
    {
        return Rank >= CardRank.One && Rank <= CardRank.Ten;
    }

    public bool IsSymbol()
    {
        return !IsNumber();
    }

    public override string ToString()
    {
        return $"The {Color} {Rank}";
    }
}


internal class Program
{
    static void Main(string[] args)
    {
        foreach (CardColor color in Enum.GetValues<CardColor>())
        {
            foreach (CardRank rank in Enum.GetValues<CardRank>())
            {
                Card card = new Card(color, rank);

                string cardType = card.IsNumber()
                    ? "Number"
                    : "Symbol";

                Console.WriteLine($"{card} - {cardType}");
            }
        }
    }
}
