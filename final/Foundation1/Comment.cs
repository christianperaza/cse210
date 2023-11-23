public class Comment
{
    // attributes...
    public string _personName;
    public string _comment;

    // method...

    // display comment
    public void DisplayComment()
    {
        Console.WriteLine($"@{_personName}:");
        Console.WriteLine($"{_comment}");
    }
}