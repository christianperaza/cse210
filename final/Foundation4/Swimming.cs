public class Swimming : Activity
{
    private int _swimmingLaps;

    public Swimming(string date, int lenght, int laps) : base(date, lenght)
    {
        SetType("Swimming in the lap pool");

        _swimmingLaps = laps;
    }

    public override decimal CalculateDistance()
    {
        return decimal.Round(_swimmingLaps * 50 / 1000, 1);
    }

    public override decimal CalculateSpeed() {
        return decimal.Round(CalculateDistance() / GetLengthInMinutes() * 60, 1);
    }

    public override decimal CalculatePace()
    {
        return decimal.Round(60 / CalculateSpeed(), 1);
    }
}