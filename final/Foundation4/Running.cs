public class Running : Activity
{
    private int _distanceRunning;

    public Running(string date, int lenght, int distance) : base(date, lenght)
    {
        SetType("Running");

        _distanceRunning = distance;
    }

    public override int CalculateDistance()
    {
        return _distanceRunning;
    }
}