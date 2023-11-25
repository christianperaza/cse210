public class Cycling : Activity
{
    private decimal _speedCycling;

    public Cycling(string date, int lenght, decimal speed) : base(date, lenght)
    {
        SetType("Stationary Bicycles");

        _speedCycling = speed;
    }

    public override decimal CalculateDistance()
    {
        return decimal.Round(_speedCycling * GetLengthInMinutes(), 1);
    }

    public override decimal CalculateSpeed()
    {
        return decimal.Round(_speedCycling, 1);
    }

    public override decimal CalculatePace()
    {
        return decimal.Round(GetLengthInMinutes() / CalculateDistance(), 1);
    }
}