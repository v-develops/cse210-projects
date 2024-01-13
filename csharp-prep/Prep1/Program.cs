using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        // Line space //
        Console.WriteLine($"");

        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        // Line space //
        Console.WriteLine($"");

        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");

        // Line space //
        Console.WriteLine($"");
    }
}