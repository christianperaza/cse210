public class ListingActivity : Activity
{

    private List<string> _questionsListing;

    public ListingActivity(string name = "Listing Activity", string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") : base(name, description)
    {
        _questionsListing = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public int GetTime()
    {
        return base.SetTime();
    }

    public int GetRandomQuestion()
    {
        Random rnd = new Random();
        return rnd.Next(0,_questionsListing.Count);
    }

    public void DisplayListingQuestionAndCounter()
    {
        Console.WriteLine("\nList as many responses you can to the following prompt:");

        Console.WriteLine($"--- {_questionsListing[GetRandomQuestion()]} ---");

        Console.Write("\nYou may begin in: ");
        base.CounterAnimation(9);
        Console.WriteLine("\n");
    }

    public void WritingListing()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetTime());

        DateTime currentTime;
        int numberOfLists = 0;

        do
        {
            Console.Write("> ");
            Console.ReadLine();

            numberOfLists++;

            currentTime = DateTime.Now;

        } while(currentTime < futureTime);

        if (numberOfLists == 1)
        {
            Console.Write($"\nYou listed {numberOfLists} item!");
        }
        else
        {
            Console.Write($"\nYou listed {numberOfLists} items!");
        }
    }

    

   
    

    


}