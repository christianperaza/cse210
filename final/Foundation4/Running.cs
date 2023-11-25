public class Running : Activity
{
    private decimal _distanceRunning;

    public Running(string date, int lenght, decimal distance) : base(date, lenght)
    {
        SetType("Running");

        _distanceRunning = distance;
    }

    public override decimal CalculateDistance()
    {
        return decimal.Round(_distanceRunning, 1);
    }

    public override decimal CalculateSpeed() {
        return decimal.Round(_distanceRunning / GetLengthInMinutes() * 60, 1);
    }

    public override decimal CalculatePace()
    {
        return decimal.Round(GetLengthInMinutes() / _distanceRunning, 1);
    }
}