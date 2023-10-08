public class Journal
{

    public Journal()
    {
    }

    public void DisplayJournal()
    {
        Console.WriteLine("");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.WriteLine("");
        Console.Write("What would you like to do?: ");
        _userAnswer = Console.ReadLine();
        _userNumber = int.Parse(_userAnswer);
    }
    
    public string _userAnswer = "";
    public int _userNumber;

    

}