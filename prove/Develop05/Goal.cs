using System;

public class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    // Constructors I
    public Goal() 
    {
        _shortName = " ";
        _description = " ";
        _points = 0;
        _isComplete = false;
    }

    // Constructors II
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Event Recorder
    public virtual void RecordEvent()
    {

    }

    // Compleated Check
    public virtual bool IsComplete() 
    {
        return false;
    }

    // Get Details
    public virtual void GetDetailsString() 
    {

    }

    // Get Representation
    public virtual string GetStringRepresentation()
    {
        string line = "";
        return line;
    }

    // Make the Goal
    public virtual void MakeGoal()
    {

    }

    // Point Calculator
    public virtual int PointCalculator()
    {
        return 0;
    }
}