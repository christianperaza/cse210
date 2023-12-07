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
    public override double CalculateDistance()
    {
        return double.Round(_swimmingLaps * 50 / 1000, 1);
    }

    // speed overrided
    public override double CalculateSpeed() {
        return double.Round(CalculateDistance() / GetLengthInMinutes() * 60, 1);
    }

    // pace overrided
    public override double CalculatePace()
    {
        return double.Round(60 / CalculateSpeed(), 1);
    }
}