using System; 

public class Lectures : Event
{
    private string _speaker;
    private string _capacity;


    // Constructor //
    public Lectures(string title, string description, string date, string time, string eventType, string address, string speaker, string capacity) : base (title, description, date, time, eventType, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Get Full Details for Lectures //
    public void GetFullDetailsLecture()
    {
        GetFullDetails();

        Console.WriteLine($"\nSpeaker: {_speaker} | Capacity: {_capacity}");
    }
}