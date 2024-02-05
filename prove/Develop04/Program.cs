using System;
using System.Net;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string input = "0";

        Points todayPoints = new Points();
        int breathingPoints = 250;
        int listingPoints = 400;
        int reflectionPoints = 350;

        while (input != "4")
        {
            // Menu
            Console.Clear();
            
            Console.WriteLine("Menu options:");
            Console.WriteLine();
            Console.WriteLine("1 - Breathing activity");
            Console.WriteLine("2 - Listing activity");
            Console.WriteLine("3 - Reflecting activity");
            Console.WriteLine("4 - Quit");
            Console.WriteLine();

            todayPoints.DisplayPoints();
            todayPoints.PointsChecker();
            Console.WriteLine();

            Console.Write("What would you like to do? ");
            input = Console.ReadLine();

            Console.Clear();

            // Activity 1
            if (input == "1")
            {
                BreathingActivity activityOne = new BreathingActivity();

                activityOne.RunActivity();

                todayPoints.AddPoints(breathingPoints);
            }

            // Activity 2
            else if (input == "2")
            {
                ListingActivity activityTwo = new ListingActivity();

                activityTwo.RunActivity();

                todayPoints.AddPoints(listingPoints);
            }

            // Activity 3
            else if (input == "3")
            {
                ReflectionActivity activityThree = new ReflectionActivity();

                activityThree.RunActivity();

                todayPoints.AddPoints(reflectionPoints);
            }

            // End Here
            else if(input == "4")
            {

            }
        }
    }
}