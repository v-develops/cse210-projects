using System; 

public class Outdoors : Event
{
    private string _forecast;


    // Constructor //
    public Outdoors(string title, string description, string date, string time, string eventType, string address, string forecast) : base (title, description, date, time, eventType, address)
    {
        _forecast = forecast;
    }

    // Get Full Details for Outdoors //
    public void GetFullDetailsOutdoor()
    {
        GetFullDetails();

        Console.WriteLine($"\nWeather Forecast: {_forecast}");
    }
}