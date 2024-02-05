using System;

public class Activity
{
    private string _name;
    private string _description;
    public int _duration;

    // Activity Constructor
    public Activity(string activityName, string activityDescription)
    {
        _name = activityName;
        _description = activityDescription;
    }

    // Start Message
    public void DisplayStartingMessage()
    {
        Console.WriteLine(_name);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long would you like this activity to be? (In seconds): ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Get ready...");
        Console.WriteLine();
        ShowSpinner(5);
    }

    // Ending Message
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(5);
        Console.WriteLine();

        Console.WriteLine($"You have completed another {_duration} seconds of {_name}");
        ShowSpinner(5);

        Console.Clear();
    }

    // Spinning Animation
    public void ShowSpinner(int seconds)
    {
        List<string> animationsStrings = new List<string>();
        animationsStrings.Add("|");
        animationsStrings.Add("/");
        animationsStrings.Add("-");
        animationsStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationsStrings[i];
            Console.Write(s);
            Thread.Sleep(150);
            Console.Write("\b \b");

            i++;

            if (i >= animationsStrings.Count)
            {
                i = 0;
            }
        }
    }

    // Count down
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }
}