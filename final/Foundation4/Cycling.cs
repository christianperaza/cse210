public class Cycling : Activity
{
    // attribute...
    private decimal _speedCycling;

    // constructor to set date, length, speed, and the type calling SetType method from base class...
    public Cycling(string date, int lenght, decimal speed) : base(date, lenght)
    {
        SetType("Stationary Bicycles");

        _speedCycling = speed;
    }

    // methods...

    // distance overrided
    public override decimal CalculateDistance()
    {
        return decimal.Round(_speedCycling * GetLengthInMinutes(), 1);
    }

    // speed overrided
    public override decimal CalculateSpeed()
    {
        return decimal.Round(_speedCycling, 1);
    }

    // pace overrided
    public override decimal CalculatePace()
    {
        return decimal.Round(GetLengthInMinutes() / CalculateDistance(), 1);
    }
}