public abstract class Activity
{
    // attributes...
    private string _date;
    private int _lengthInMinutes;

    private string _type; // Running, Stationary Bicycles, or Swimming in the lap pool 

    // constructor to set date and length...
    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    // methods...

    // set type
    public void SetType(string type)
    {
        _type = type;
    }

    // get length
    public int GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }

    // abstract methods...

    // distance
    public abstract decimal CalculateDistance();
    // speed
    public abstract decimal CalculateSpeed(); 
    // pace
    public abstract decimal CalculatePace();

    // get summary
    public void GetSummary()
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"{_date} {_type} ({_lengthInMinutes} min)\n--> Distance: { CalculateDistance()} km,\n--> Speed: {CalculateSpeed()} kph,\n--> Pace: {CalculatePace()} min per km.");
        Console.WriteLine("-----------------------------------------");
    }


}