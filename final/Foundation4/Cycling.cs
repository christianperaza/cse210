public class Cycling : Activity
{
    // attribute...
    private double _speedCycling;

    // constructor to set date, length, speed, and the type calling SetType method from base class...
    public Cycling(string date, int lenght, double speed) : base(date, lenght)
    {
        SetType("Stationary Bicycles");

        _speedCycling = speed;
    }

    // methods...

    // distance overrided
    public override double CalculateDistance()
    {
        return double.Round(_speedCycling * GetLengthInMinutes(), 1);
    }

    // speed overrided
    public override double CalculateSpeed()
    {
        return double.Round(_speedCycling, 1);
    }

    // pace overrided
    public override double CalculatePace()
    {
        return double.Round(GetLengthInMinutes() / CalculateDistance(), 1);
    }
}