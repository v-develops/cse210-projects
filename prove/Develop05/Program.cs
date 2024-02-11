using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string userImput = "";

        GoalManager goals = new GoalManager();

        string todayTip = goals.GetTip();

        while (userImput != "6")
        {
            int points = goals.GetAllUserPoints();

            Console.Clear();
            Console.WriteLine($"You have a total of {points} points!");
            Console.WriteLine();
            Console.WriteLine("Tip for today's Goal:");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine(todayTip);
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Main Menu Options:");
            Console.WriteLine();
            Console.WriteLine(" 1 - Create New Goal");
            Console.WriteLine(" 2 - List Goals");
            Console.WriteLine(" 3 - Save Goals");
            Console.WriteLine(" 4 - Load Goals");
            Console.WriteLine(" 5 - Record Event");
            Console.WriteLine(" 6 - Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            userImput = Console.ReadLine();

            if (userImput == "1")
            {
                Console.Clear();

                Console.WriteLine("Choose a type of Goal: ");
                Console.WriteLine();
                Console.WriteLine(" 1 - Simple Goal");
                Console.WriteLine(" 2 - Eternal Goal");
                Console.WriteLine(" 3 - Checklist Goal");
                Console.WriteLine();
                Console.Write("Which type of goal would you like to create? ");
                string typeGoal = Console.ReadLine();
                Console.WriteLine();

                if (typeGoal == "1")
                {
                    SimpleGoal simpleGoal = new SimpleGoal();

                    simpleGoal.MakeGoal();
                    goals.addGoal(simpleGoal);

                    Console.WriteLine();
                    Console.Write("Press [enter] to return to the Main Menu ");
                    Console.ReadLine();

                    continue;
                }

                else if (typeGoal == "2")
                {
                    EternalGoal eternalGoal = new EternalGoal();

                    eternalGoal.MakeGoal();
                    goals.addGoal(eternalGoal);

                    Console.WriteLine();
                    Console.Write("Press [enter] to return to the Main Menu ");
                    Console.ReadLine();

                    continue;
                }

                else if (typeGoal == "3")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();

                    checklistGoal.MakeGoal();
                    goals.addGoal(checklistGoal);

                    Console.WriteLine();
                    Console.Write("Press [enter] to return to the Main Menu ");
                    Console.ReadLine();

                    continue;
                }

                else
                {
                    Console.WriteLine("ERROR: Invalid goal type!");
                    Console.Write("Press [enter] to return to the Main Menu ");
                    Console.ReadLine();

                    continue;
                }
            }

            else if (userImput =="2")
            {
                Console.Clear();
                
                Console.WriteLine("Your list of Goals:");
                Console.WriteLine();

                goals.ListGoals();

                Console.Write("Press [enter] to return to the Main Menu ");
                Console.ReadLine();

                continue;
            }

            else if (userImput == "3")
            {
                goals.SaveGoals();

                Console.WriteLine();
                Console.Write("Press [enter] to return to the Main Menu ");
                Console.ReadLine();

                continue;
            }

            else if (userImput == "4")
            {
                goals.LoadGoals();

                Console.WriteLine();
                Console.Write("Press [enter] to return to the Main Menu ");
                Console.ReadLine();

                continue;
            }

            else if (userImput == "5")
            {
                Console.Clear();
                
                goals.ListGoals();
                goals.CheckTheEvent();

                Console.WriteLine();
                Console.Write("Press [enter] to return to the Main Menu ");
                Console.ReadLine();

                continue;
            }

            else if (userImput == "6")
            {

            }

            else
            {
                Console.WriteLine();
                Console.Write("ERROR: Invalid number! (Press [enter] to return to the Main Menu) ");
                Console.ReadLine();

                continue;
            }
        }
    }
}