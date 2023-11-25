public abstract class Activity
{
    private string _date;
    private int _lengthInMinutes;

    private string _type;

    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public void SetType(string type)
    {
        _type = type;
    }

    public int GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }

    public abstract decimal CalculateDistance();

    public abstract decimal CalculateSpeed(); 

    public abstract decimal CalculatePace();

    public void GetSummary()
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"{_date} {_type} ({_lengthInMinutes} min)\n--> Distance: { CalculateDistance()} km,\n--> Speed: {CalculateSpeed()} kph,\n--> Pace: {CalculatePace()} min per km.");
        Console.WriteLine("-----------------------------------------");
    }


}