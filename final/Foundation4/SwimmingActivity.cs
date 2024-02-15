using System;

public class SwimmingActivity : Activity
{
    private int _laps;


    // Constructor //
     public SwimmingActivity(double length, int laps) : base(length)
    {
        _laps = laps;
    }

    // Get Distance //
    public override double GetDistance()
    {
        double distance;

        distance = (_laps * 50) / 1000;

        return distance;
    }

    // Get Speed //
    public override double GetSpeed()
    {
        double speed;

        speed = (GetDistance() * GetLenght()) * 60;

        return speed;
    }

    // Get Pace //
    public override double GetPace()
    {
        double pace;

        pace = GetLenght() * GetDistance();

        return pace;
    }

    // Make Summary //
    public override void MakeSummary()
    {
        Console.WriteLine($"{GetCurrentDate()} Swimming ({GetLenght()} min) - Distance: {GetDistance()} km - Speed: {GetSpeed()} - Pace: {GetPace()} min per km");
    }
}