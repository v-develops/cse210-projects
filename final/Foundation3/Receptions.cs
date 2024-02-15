using System; 

public class Receptions : Event
{
    private string _email;


    // Constructor //
    public Receptions(string title, string description, string date, string time, string eventType, string address, string email) : base (title, description, date, time, eventType, address)
    {
        _email = email;
    }

    // Get Full Details for Receptions //
    public void GetFullDetailsReception()
    {
        GetFullDetails();

        Console.WriteLine($"\nRSVP: {_email}");
    }
}