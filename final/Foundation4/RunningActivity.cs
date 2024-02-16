using System;

public class RunningActivity : Activity
{
    private double _distance;


    // Constructor //
    public RunningActivity(double length, double distance) : base(length)
    {
        _distance = distance;
    }

    // Get Distance //
    public override double GetDistance()
    {
        return _distance;
    }

    // Get Speed //
    public override double GetSpeed()
    {
        double speed;

        speed = (GetDistance() / GetLenght()) * 60;

        return speed;
    }

    // Get Pace //
    public override double GetPace()
    {
        double pace;

        pace = GetLenght() / GetDistance();

        return pace;
    }

    // Make Summary //
    public override void MakeSummary()
    {
        Console.WriteLine($"{GetCurrentDate()} Running ({GetLenght()} min) - Distance: {GetDistance()} km - Speed: {GetSpeed()} km per hour - Pace: {GetPace()} min per km");
    }
}