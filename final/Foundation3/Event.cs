public class Event
{
    private string _typeEvent;
    private string _titleEvent;
    private string _descriptionEvent;
    private string _dateEvent;
    private string _timeEvent;

    private Address _addressEvent;

    public Event(string title, string description, string date, string time, string street, string city, string state, string country)
    {
        _titleEvent = title;
        _descriptionEvent = description;
        _dateEvent = date;
        _timeEvent = time;

        _addressEvent = new Address(street, city, state, country);
    }

    public void SetType(string type)
    {
        _typeEvent = type;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"Title: {_titleEvent}.\nDescription: {_descriptionEvent}.\nDate: {_dateEvent}.\nTime: {_timeEvent}.\nAddress:\n{_addressEvent.DisplayAddress()}");
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine($"Type: {_typeEvent}. Title: {_titleEvent}. Date: {_dateEvent}.");
    }
}