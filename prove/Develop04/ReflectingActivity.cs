public class ReflectingActivity : Activity
{

    private List<string> _promptsReflection;
    private List<string> _questionsReflection;

    public ReflectingActivity(string name = "Reflecting Activity", string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") : base(name, description)
    {
        _promptsReflection = new List<string> {
           "Think of a time when you stood up for someone else.",
           "Think of a time when you did something really difficult.",
           "Think of a time when you helped someone in need.",
           "Think of a time when you did something truly selfless."
        };

        _questionsReflection =  new List<string> {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time diferent than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public int GetTime()
    {
        return base.SetTime();
    }

    public int GetRandomPrompt()
    {
        Random rnd = new Random();
        return rnd.Next(0,_promptsReflection.Count);
    }

    public int GetRandomQuestion()
    {
        Random rnd2 = new Random();
        return rnd2.Next(0,_questionsReflection.Count);
    }

    public void DisplayReflectionPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:");

        Console.WriteLine($"\n--- {_promptsReflection[GetRandomPrompt()]} ---\n");

        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayReflectionQuestion()
    {
        Console.WriteLine("\nNow, ponder on each of the following questions as they related to this experience.");

        Console.Write("You may begin in: ");
        base.CounterAnimation(9);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetTime());

        DateTime currentTime;

        do
        {
            Console.Write($"> {_questionsReflection[GetRandomQuestion()]} ");

            base.SpinnerAnimation(13);

            Console.WriteLine("");
            currentTime = DateTime.Now;

        } while(currentTime < futureTime);

        
    }

   
    

    


}