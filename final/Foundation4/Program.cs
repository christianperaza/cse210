using System;

class Program
{
    static void Main(string[] args)
    {
        string dateRunning = "28 Nov 2023";
        int lengthInMinutesRunning = 30;
        decimal distanceRunning = 3.0m;
        Running running = new Running(dateRunning, lengthInMinutesRunning, distanceRunning);

        string dateCycling = "03 Dic 2023";
        int lengthInMinutesCycling = 45;
        decimal speedCycling = 6.8m;
        Cycling cycling = new Cycling(dateCycling, lengthInMinutesCycling, speedCycling);

        string dateSwimming = "13 Dic 2023";
        int lengthInMinutesSwimming = 38;
        int swimmingLaps = 45;
        Swimming swimming = new Swimming(dateSwimming, lengthInMinutesSwimming, swimmingLaps);

        List<Activity> activities = new()
        {
            running,
            cycling,
            swimming
        };
        
        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }

    }
}