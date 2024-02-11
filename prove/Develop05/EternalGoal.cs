using System;

public class EternalGoal : Goal
{
    private int _fulfilledCounter;

    // Constructor I
    public EternalGoal()
    {
        _shortName = " ";
        _description = " ";
        _points = 0;
        _fulfilledCounter = 0;
    }

    // Constructor II
    public EternalGoal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _fulfilledCounter = 0;
    }

    // Event Recorder
    public override void RecordEvent()
    {
        _fulfilledCounter ++;
    }

    // Compleated Check
    public override bool IsComplete()
    {
        return false;
    }

    // Get Details
    public override void GetDetailsString()
    {
        Console.Write($"[ ] {_shortName} ({_description})");
    }

    // Get Representation
    public override string GetStringRepresentation()
    {
        string line = $"EternalGoal|{_shortName}|{_description}|{_points.ToString()}";
        return line;
    }

    // Make the Goal
    public override void MakeGoal()
    {
        try
        {
            Console.Write("What is the name of your goal? ");
            _shortName = Console.ReadLine();
            Console.WriteLine();
            
            Console.Write("What is a short description of it? ");
            _description = Console.ReadLine();
            Console.WriteLine();
            
            Console.Write("What is the amount of points associated with this goal? ");
            string GoalPoints = Console.ReadLine();
            _points = Convert.ToInt32(GoalPoints);
        }

        catch
        {
            Console.WriteLine();
            Console.Write("ERROR: Use only numbers!");

            //
        }
    }

    // Point Calculator
    public override int PointCalculator()
    {
        int points = _points;
        
        return points;
    }
}