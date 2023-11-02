public class BreathingActivity : Activity
{

    public BreathingActivity(string name = "Breathing Activity", string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") : base(name, description)
    {
        
    }

    public int GetTime()
    {
        return base.SetTime();
    }

    public void RunBreathingActivity()
    {

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetTime());

        DateTime currentTime;

        do
        {
            Console.WriteLine("");
            Console.Write("\nBreathe in... ");

            base.CounterAnimation(4);

            Console.Write("\nNow breath out... ");

            base.CounterAnimation(6);
            currentTime = DateTime.Now;

        } while(currentTime < futureTime);
        
    }

}