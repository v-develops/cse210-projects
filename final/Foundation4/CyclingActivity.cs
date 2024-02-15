using System;

public class CyclingActivity : Activity
{
    private double _speed;


    // Constructor //
    public CyclingActivity(double length, double speed) : base(length)
    {
        _speed = speed;
    }

    // Get Speed //
    public override double GetSpeed()
    {
        return _speed;
    }

    // Get Distance //
    public override double GetDistance()
    {
        double distance;

        distance = (GetLenght() * GetSpeed());

        return distance;
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
        Console.WriteLine($"{GetCurrentDate()} Cycling ({GetLenght()} min) - Distance: {GetDistance()} km - Speed: {GetSpeed()} - Pace: {GetPace()} min per km");
    }
}