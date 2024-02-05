using System;

public class BreathingActivity : Activity
{
    // Activity Constructor
    public BreathingActivity() : base("Breathing Activity!", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    // Run Breathing Activity
    public void RunActivity()
    {
        DisplayStartingMessage();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endingTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;

        while (currentTime < endingTime)
        {
            Console.Write("Breath In...");
            ShowCountDown(4);

            Console.Write("Breath Out...");
            ShowCountDown(6);

            Console.WriteLine();
            currentTime = DateTime.Now;
        }

        Console.Clear();
        DisplayEndingMessage();
    }
}