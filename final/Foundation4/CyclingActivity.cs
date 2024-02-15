using System;

public class CyclingActivity : Activity
{
    private double _speed;


    public CyclingActivity(double length, double speed) : base(length)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        double distance;

        distance = (GetLenght() * GetSpeed());

        return distance;
    }

    public override double GetPace()
    {
        double pace;

        pace = GetLenght() * GetDistance();

        return pace;
    }

    public override void MakeSummary()
    {
        Console.WriteLine($"{GetCurrentDate()} Cycling ({GetLenght()} min) - Distance: {GetDistance()} km - Speed: {GetSpeed()} - Pace: {GetPace()} min per km");
    }
}