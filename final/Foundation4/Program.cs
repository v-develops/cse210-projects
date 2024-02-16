using System;

class Program
{
    static void Main(string[] args)
    {
        // Activity List //
        List<Activity> activities = new List<Activity>();


        // Running Activity //
        RunningActivity runningActivity = new RunningActivity(60, 2);
        
        // Cycling Activity //
        CyclingActivity cyclingActivity = new CyclingActivity(24, 5);

        // Swimming Activity //
        SwimmingActivity swimmingActivity = new SwimmingActivity(30, 100);


        // Add to The List //
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        Console.Clear();

        // Display Summary //
        foreach (Activity activity in activities)
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            
            activity.MakeSummary();

            Console.WriteLine("-----------------------------------------------------------------------------------------------");
        }

        Console.WriteLine();
    }
}