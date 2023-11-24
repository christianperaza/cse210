public class Lecture : Event
{
    // public Lecture(string type = "Lecture", string title, string description, string date, string time, Address address) : base(type, title, description, date, time, address)
    public Lecture(string title, string description, string date, string time, string street, string city, string state, string country) : base(title, description, date, time, street, city, state, country)
    {
        SetType("Lecture");

    }

    
}