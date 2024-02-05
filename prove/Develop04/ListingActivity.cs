using System;

public class ListingActivity : Activity
{
    // Prompt List
    private string [] _prompts = {
        "---  Who are people that you appreciate?  ---",
        "---  What are personal strengths of yours?  ---",
        "---  Who are people that you have helped this week?  ---",
        "---  When have you felt the Holy Ghost this month?  ---",
        "---  Who are some of your personal heroes?  ---"
    };

    // Get Prompt
    public string GetPrompt()
    {
        Random random = new Random();
        int i = random.Next(0,_prompts.Length);
        return _prompts[i];
    }

    // Activity Constructor
    public ListingActivity() : base("Listing Activity!", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    // Run Listing Activity
    public void RunActivity()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many as you can to the folowing prompt:");
        Console.WriteLine();
        Console.WriteLine(GetPrompt());
        Console.WriteLine();
        Console.Write("You may begin in:");

        ShowCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endingTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;

        int promptCount = 0;

        while (currentTime < endingTime)
        {
            promptCount += 1;
            Console.ReadLine();
            currentTime = DateTime.Now;
        }

        Console.Clear();
        Console.WriteLine($"You wrote {promptCount} times!");
        DisplayEndingMessage();
    }
}