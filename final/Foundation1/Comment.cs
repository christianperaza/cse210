public class Comment
{
    // attributes...
    public string _personName;
    public string _comment;

    // method...
    public void DisplayComment()
    {
        Console.WriteLine($"@{_personName}:");
        Console.WriteLine($"{_comment}");
    }
}