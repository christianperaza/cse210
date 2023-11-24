public class Outdoor : Event
{
    // attribute...
    private string _weatheStatement;

    // constructor to set each value to corresponding attributes...
    public Outdoor(string title, string description, string date, string time, string street, string city, string state, string country, string weather) : base(title, description, date, time, street, city, state, country)
    {
        SetType("Outdoor gatherings"); // set type

        _weatheStatement = weather;

        SetSpecificDetails($"WEATHER: {_weatheStatement}"); // set specific outdoors detail
    }
    
}