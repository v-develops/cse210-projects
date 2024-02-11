using System;
using System.ComponentModel;
using System.IO;

public class GoalManager : Goal
{
    // Goal List & Score
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    // List all Goals
    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].GetDetailsString();
            Console.Write("\n");
        }

        Console.WriteLine();
    }

    // Add a new Goal
    public void addGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    // Check if Goal is Compleated
    public void CheckTheEvent()
    {
        try
        {
            Console.Write("Which goal did you Completed? ");
            string goalIndex = Console.ReadLine();

            int goalIndexInteger = Convert.ToInt32(goalIndex) - 1;

            if (_goals[goalIndexInteger].IsComplete() == false)
            {
                _goals[goalIndexInteger].RecordEvent();
                int pointsEarned = _goals[goalIndexInteger].PointCalculator();

                _score += pointsEarned;

                Console.WriteLine();
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {_score} points!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You have already completed this goal!");
            }
        }

        catch
        {
            Console.WriteLine();
            Console.Write("ERROR: Choose a valid Goal! (Ex: 1, 2, 5, 8, etc)");
        }
    }

    // Save Goals
    public void SaveGoals()
    {
        try
        {
            Console.Clear();

            string txtMaker = ".txt";

            Console.Write("What name do you want for the file? ");
            string fileName = Console.ReadLine() + txtMaker;

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                int totalPoints = GetAllUserPoints();
                outputFile.WriteLine(totalPoints.ToString());
                
                foreach(Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
        }

        catch
        {
            Console.WriteLine();
            Console.Write("ERROR: You can't create this kind of file!");
        }
        
    }

    // Load Goals
    public void LoadGoals()
    {
        try
        {
            string txtMaker = ".txt";

            Console.Clear();

            _goals.Clear(); 

            Console.Write("What is the filename? ");
            string fileName = Console.ReadLine()  + txtMaker;
            string[] lines = System.IO.File.ReadAllLines(fileName);

            _score = Convert.ToInt32(lines[0]);

            for (int i = 1; i < lines.Count(); i++ )
            {
                string[] parts = lines[i].Split("|");

                if (parts[0] == "SimpleGoal") {

                    SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));
                    _goals.Add(simpleGoal);             

                } else if (parts[0] == "EternalGoal") {

                    EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));
                    _goals.Add(eternalGoal);

                } else if (parts[0] == "ChecklistGoal") {
                    
                    ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]));
                    _goals.Add(checklistGoal);
                }
            }
        }

        catch
        {
            Console.WriteLine();
            Console.Write("ERROR: This file doesn't exist!");
        }
    }

    // Calcule the Total Amount of Points
    public int CalculateTotalPoints()
    {
        int totalPoints = _score;
        foreach(Goal goal in _goals)
        {
            totalPoints += goal.PointCalculator();
        }

        _score = totalPoints;

        return totalPoints;
    }

    // Get All the User Current Points
    public int GetAllUserPoints()
    {
        int points = _score;

        return points;
    }

    // Tips List
    private string [] _tips = {
        "What could you do to improve your faith?",
        "Is there an activity or hobby that you want to do forever?",
        "How about trying to make a goal to improve your health?",
        "Lets try to make something difficult, but with a great reward in the end!",
        "You could make a simple goal to break today's routine!",
        "Chalenge: Make a long term goal to help you overcome a bad habit!",
        "What is something that could help you prepare to the future? "
    };

    // Tip Getter
    public string GetTip()
    {
        Random random = new Random();
        int i = random.Next(0,_tips.Length);
        return _tips[i];
    }
}