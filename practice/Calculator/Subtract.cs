public class Subtract : Calculator
{
    public Subtract()
    {
    }
    public void Sub()
    {
        int subtract = base.GetNumberOne() - base.GetNumberTwo();
        Console.WriteLine($"Subtract: {subtract}");
    }
}