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

    public abstract int CalculateDistance();
}