public class Running : Activity
{
    // attribute...
    private double _distanceRunning;

    // constructor to set date, length, distance, and the type calling SetType method from base class...
    public Running(string date, int lenght, double distance) : base(date, lenght)
    {
        SetType("Running");

        _distanceRunning = distance;
    }

    // methods...

    // distance overrided
    public override double CalculateDistance()
    {
        return double.Round(_distanceRunning, 1);
    }

    // speed overrided
    public override double CalculateSpeed() {
        return double.Round(_distanceRunning / GetLengthInMinutes() * 60, 1);
    }

    // pace overrided
    public override double CalculatePace()
    {
        return double.Round(GetLengthInMinutes() / _distanceRunning, 1);
    }
}