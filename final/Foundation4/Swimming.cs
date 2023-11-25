public class Swimming : Activity
{
    // attribute...
    private int _swimmingLaps;

    // constructor to set date, length, laps, and the type calling SetType method from base class...
    public Swimming(string date, int lenght, int laps) : base(date, lenght)
    {
        SetType("Swimming in the lap pool");

        _swimmingLaps = laps;
    }

    // methods...

    // distance overrided
    public override decimal CalculateDistance()
    {
        return decimal.Round(_swimmingLaps * 50 / 1000, 1);
    }

    // speed overrided
    public override decimal CalculateSpeed() {
        return decimal.Round(CalculateDistance() / GetLengthInMinutes() * 60, 1);
    }

    // pace overrided
    public override decimal CalculatePace()
    {
        return decimal.Round(60 / CalculateSpeed(), 1);
    }
}