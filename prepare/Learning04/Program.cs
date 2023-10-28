using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "Christian";
        string topic = "Programming with classes";
        
        Assignment assignment = new Assignment(name, topic);

        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

    }
}