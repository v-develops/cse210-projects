using System;

public class RunningActivity : Activity
{
    private double _distance;


    // Constructor //
    public RunningActivity(double length, double distance) : base(length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed;

        speed = (GetDistance() * GetLenght()) * 60;

        return speed;
    }

    public override double GetPace()
    {
        double pace;

        pace = GetLenght() / GetDistance();

        return pace;
    }

    public override void MakeSummary()
    {
        Console.WriteLine($"{GetCurrentDate()} Running ({GetLenght()} min) - Distance: {GetDistance()} km - Speed: {GetSpeed()} - Pace: {GetPace()} min per km");
    }
}