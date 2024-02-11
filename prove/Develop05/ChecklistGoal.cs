using System;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _amountCompleted;
    private int _bonus;

    // Constructor I
    public ChecklistGoal()
    {

    }

    // Constructor II
    public ChecklistGoal(string name, string description, int points, int target, int fulfilledCounter, int bonus)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _amountCompleted = fulfilledCounter;
        _bonus = bonus;
    }

    // Event Recorder
    public override void RecordEvent()
    {
        _amountCompleted ++;
    }

    //Compleated Check
    public override bool IsComplete() 
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
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

        Console.Write($"[{symbol}] {_shortName} ({_description}) -- Currently Completed {_amountCompleted}/{_target}");
    }

    // Get Representation
    public override string GetStringRepresentation()
    {
        string line = $"ChecklistGoal|{_shortName}|{_description}|{_points.ToString()}|{_target.ToString()}|{_amountCompleted.ToString()}|{_bonus.ToString()}";
        return line;
    }

    // Make the Checklist Goal
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

            Console.WriteLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string CheckCounter = Console.ReadLine();
            _target = Convert.ToInt32(CheckCounter);

            Console.WriteLine();
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonusPoints = Console.ReadLine();
            _bonus = Convert.ToInt32(bonusPoints);

            _amountCompleted = 0;
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
        int points = 0;

        points = _amountCompleted * _points;

        bool status = IsComplete();

        if (status == true)
        {
            points += _bonus;
        }

        return points;

    }
}