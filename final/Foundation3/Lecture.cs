public class Lecture : Event
{
    // public Lecture(string type = "Lecture", string title, string description, string date, string time, Address address) : base(type, title, description, date, time, address)
    public Lecture(string type, string title, string date) : base(type, title, date)
    {
        
    }
}