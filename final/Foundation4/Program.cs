using System;

class Program
{
    static void Main(string[] args)
    {
        // ----------- RUNNING ----------- //
        string dateRunning = "28 Nov 2023";
        int lengthInMinutesRunning = 30;
        double distanceRunning = 3.0;
        Running running = new Running(dateRunning, lengthInMinutesRunning, distanceRunning);

        // ----------- CYCLING ----------- //
        string dateCycling = "03 Dic 2023";
        int lengthInMinutesCycling = 45;
        double speedCycling = 6.8;
        Cycling cycling = new Cycling(dateCycling, lengthInMinutesCycling, speedCycling);

        // ----------- SWIMMING ----------- //
        string dateSwimming = "13 Dic 2023";
        int lengthInMinutesSwimming = 38;
        int swimmingLaps = 45;
        Swimming swimming = new Swimming(dateSwimming, lengthInMinutesSwimming, swimmingLaps);

        // add activities in a list...
        List<Activity> activities = new()
        {
            running,
            cycling,
            swimming
        };
        
        // iterate in each activity in list to call the GetSummary method...
        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }

    }
}