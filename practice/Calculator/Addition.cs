public class Addition : Calculator
{
    public Addition()
    {
    }
    public void Add()
    {
        int addition = base.GetNumberOne() + base.GetNumberTwo();
        Console.WriteLine($"Addition: {addition}");
    }
}