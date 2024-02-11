using System;

public class SimpleGoal : Goal
{
    // Constructor I
    public SimpleGoal()
    {
        _shortName = " ";
        _description = " ";
        _points = 0;
        _isComplete = false;
    }

    // Constructor II
    public SimpleGoal(string name, string description, int points, bool status)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = status;
    }

    // Event Recorder
    public override void RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
        } 
        else
        {
            Console.WriteLine("You have already completed this goal!");
        }
    }

    // Compleated Check
    public override bool IsComplete()
    {
        if (_isComplete == true) {
            return true;
        } else {
            return false;
        }
    }
    
    // Get Details
    public override void GetDetailsString()
    {
        string symbol = "";
        bool status = IsComplete();
        if (status == true)
        {
            symbol = "X";
        }
        else
        {
            symbol = " ";
        }

        Console.Write($"[{symbol}] {_shortName} ({_description})");
    }

    // Get Representation
    public override string GetStringRepresentation()
    {
        string line = $"SimpleGoal|{_shortName}|{_description}|{_points}|{IsComplete()}";
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

            _isComplete = false;
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
        bool status = IsComplete();

        int points = 0;

        if (status == true)
        {
            points = _points;
        }
        else
        {
            points = 0;
        }

        return points;
    }
}