using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What future jobs or hobbies you really want do to?",
        "Did you ate something delicious today?"
    };

    public string GetRandonPrompt()
    {
        Random randomPrompt = new Random();
        int prompt = randomPrompt.Next(_prompts.Count);

        string finalPrompt = _prompts[prompt];
        return finalPrompt;
    }
}