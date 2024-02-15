using System;

public class Activity
{
    private string _date;
    private double _lenght;


    // Constructor //
    public Activity(double lenght)
    {
        _lenght = lenght;
    }

    // Get Current Date //
    public string GetCurrentDate()
    {
        DateTime date = DateTime.Now;
        
        _date = date.ToString("dd MMM yyyy");
        
        return _date;
    }

    // Lenght Getter //
    public double GetLenght()
    {
        return _lenght;
    }

    // Get Distance //
    public virtual double GetDistance()
    {
        return 0.00;
    }

    // Get Speed //
    public virtual double GetSpeed()
    {
        return 0.00;
    }

    // Get Pace //
    public virtual double GetPace()
    {
        return 0.00;
    }

    // Make Summary //
    public virtual void MakeSummary()
    {
        
    }
}