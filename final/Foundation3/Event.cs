public class Event
{
    // attributes...
    private string _titleEvent;
    private string _descriptionEvent;
    private string _dateEvent;
    private string _timeEvent;
    private Address _addressEvent;

    private string _typeEvent;
    private string _specificDetail;

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

    public void SetSpecificDetails(string specificDetail)
    {
        _specificDetail = specificDetail;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"TITLE: {_titleEvent}.\nDESCRIPTION: {_descriptionEvent}.\nDATE: {_dateEvent}.\nTIME: {_timeEvent}\nADDRESS:\n{_addressEvent.DisplayAddress()}");
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine($"TYPE: {_typeEvent}.\nTITLE: {_titleEvent}.\nDATE: {_dateEvent}.");
    }

    public void DisplayMarketingMessages()
    {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine($"{_typeEvent.ToUpper()}\n");
        Console.WriteLine("*** STANDARD DETAILS ***");
        DisplayStandardDetails();
        Console.WriteLine("");

        Console.WriteLine("*** FULL DETAILS ***");
        DisplayStandardDetails();
        Console.WriteLine($"{_specificDetail}");
        Console.WriteLine("");

        Console.WriteLine("*** SHORT DESCRIPTION ***");
        DisplayShortDescription();
        Console.WriteLine("---------------------------------------");
    }
}