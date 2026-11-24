public class Fountain
{
    public bool IsEnabled { get; private set; }

    public void Enable()
    {
        IsEnabled = true;
    }
}