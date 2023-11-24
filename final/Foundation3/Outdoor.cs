public class Outdoor : Event
{
    private string _weatheStatement;

    public Outdoor(string title, string description, string date, string time, string street, string city, string state, string country, string weather) : base(title, description, date, time, street, city, state, country)
    {
        SetType("Outdoor gatherings");

        _weatheStatement = weather;

        SetSpecificDetails($"WEATHER: {_weatheStatement}");
    }
    
}