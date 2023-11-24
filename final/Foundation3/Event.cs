public class Event
{
    private string _typeEvent;
    private string _titleEvent;
    // private string _descriptionEvent;
    private string _dateEvent;
    // private string _timeEvent;
    // private Address _addressEvent;

    // public Event(string type, string title, string description, string date, string time, Address address)
    public Event(string type, string title, string date)
    {
        _typeEvent = type;
        _titleEvent = title;
        // _descriptionEvent = description;
        _dateEvent = date;
        // _timeEvent = time;
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine($"Type: {_typeEvent}. Title: {_titleEvent}. Date: {_dateEvent}.");
    }
}