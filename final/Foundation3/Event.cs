using System; 

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _eventType;
    private string _address;


    // Constructor //
    public Event(string title, string description, string date, string time, string eventType, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _eventType = eventType;
        _address = address;
    }

    // Get Standard Details //
    public void GetStandardDetails()
    {
        Console.WriteLine($"Name: {_title} | {_date} - {_time}");
        Console.WriteLine($"\nDescription: \n{_description}");
        Console.WriteLine($"\nAddress: \n{_address}");
    }

    // Get Full Details //
    public void GetFullDetails()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"");
        Console.WriteLine($"Name: {_title} | {_date} - {_time}");
        Console.WriteLine($"\nDescription: \n{_description}");
        Console.WriteLine($"\nAddress: \n{_address}");
    }

    // Get Short Details //
    public void GetShortDetails()
    {
        Console.WriteLine($"Type: {_eventType}");
        Console.WriteLine($"");
        Console.WriteLine($"Name: {_title} | {_date} - {_time}");
    }
}