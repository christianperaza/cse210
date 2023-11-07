public class Calculator
{
    private int _firstNumber;
    private int _secondNumber;

    public Calculator()
    {
    }
    public void SetNumbers()
    {
        Console.Write("Number 1: ");
        string userNumber1 = Console.ReadLine();
        _firstNumber = int.Parse(userNumber1);

        Console.Write("Number 2: ");
        string userNumber2 = Console.ReadLine();
        _secondNumber = int.Parse(userNumber2);
    }

    public int GetNumberOne()
    {
        return _firstNumber;
    }

    public int GetNumberTwo()
    {
        return _secondNumber;
    }
}