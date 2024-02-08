using System;

public class Points
{
    private int _totalPoints;

    public Points()
    {
        _totalPoints = 0; 
    }

    public void AddPoints(int morePoints)
    {
        _totalPoints += morePoints;
    }

    public void PointsChecker()
    {
        if (_totalPoints < 1000 )
        {
            Console.WriteLine("Keep going until you get 1000 points!");
        }

        else
        {
            Console.WriteLine("You hit today's point goal! congratulations!");
        }
    }

    public void DisplayPoints()
    {
        Console.WriteLine($"Total Points: {_totalPoints}");
    }
}