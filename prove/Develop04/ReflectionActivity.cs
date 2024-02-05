using System;

public class ReflectionActivity : Activity
{
    // Prompt List
    private string [] _prompts = {
        "---  Think of a time when you stood up for someone else  ---",
        "---  Think of a time when you did something really difficult  ---",
        "---  Think of a time when you helped someone in need  ---",
        "---  Think of a time when you did something truly selfless  ---"
    };

    // Question List
    private string [] _questions = {
        "Why was this experience meaningful to you? ",
        "Have you ever done anything like this before? ",
        "How did you get started? ",
        "How did you feel when it was complete? ",
        "What made this time different than other times when you were not as successful? ",
        "What is your favorite thing about this experience? ",
        "What could you learn from this experience that applies to other situations? ",
        "What did you learn about yourself through this experience? ",
        "How can you keep this experience in mind in the future? "
    };

    // Prompt Getter
    public string GetPrompt()
    {
        Random random = new Random();
        int i = random.Next(0,_prompts.Length);
        return _prompts[i];
    }

    // Question Getter
    public string GetQuestion()
    {
        Random random = new Random();
        int i = random.Next(0,_questions.Length);
        return _questions[i];
    }

    // Prompt Displayer
    public void DisplayPrompt()
    {
        Console.WriteLine(GetPrompt());
    }

    // Question Displayer
    public void DisplayQuestion()
    {
        Console.Write(GetQuestion());
    }

    // Activity Constructor
    public ReflectionActivity() : base("Reflection Activity!", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    // Run Reflection Activity
    public void RunActivity()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("Consider the following Prompt:");
        Console.WriteLine();

        DisplayPrompt();
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Clear();

        Console.WriteLine("Now, think about the following questions as they relate to this experience");
        Console.WriteLine("You may begin in: ");

        Console.WriteLine();

        ShowCountDown(5);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endingTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;

        while (currentTime < endingTime)
        {
            Console.WriteLine();
            Console.WriteLine();
            DisplayQuestion();
            ShowSpinner(10);
            currentTime = DateTime.Now;
        }

        Console.Clear();
        DisplayEndingMessage();
    }
}