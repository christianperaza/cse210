public class Comment
{
    public string _personName;
    public string _comment;

    public void DisplayComment()
    {
        Console.WriteLine($"@{_personName}");
        Console.WriteLine($"'{_comment}'");
    }
}