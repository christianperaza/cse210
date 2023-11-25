public class Running : Activity
{
    // attribute...
    private decimal _distanceRunning;

    // constructor to set date, length, distance, and the type calling SetType method from base class...
    public Running(string date, int lenght, decimal distance) : base(date, lenght)
    {
        SetType("Running");

        _distanceRunning = distance;
    }

    // methods...

    // distance overrided
    public override decimal CalculateDistance()
    {
        return decimal.Round(_distanceRunning, 1);
    }

    // speed overrided
    public override decimal CalculateSpeed() {
        return decimal.Round(_distanceRunning / GetLengthInMinutes() * 60, 1);
    }

    // pace overrided
    public override decimal CalculatePace()
    {
        return decimal.Round(GetLengthInMinutes() / _distanceRunning, 1);
    }
}