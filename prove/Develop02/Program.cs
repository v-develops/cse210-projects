using System;

class Program
{
    static void Main(string[] args)
    {
// WHILE LOOP //
        string userInput = "0";

        PromptGenerator prompt = new PromptGenerator();
        Journal journal = new Journal();

        while (userInput != "5")
        {     
// MENU //
            Console.WriteLine("");

            DateTime currentDateTime = DateTime.Now;

            Entry entry = new Entry();

            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.WriteLine("");
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();

            while (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4" && userInput != "5")
            {
                Console.Write("Error! Type a valid action: ");
                userInput = Console.ReadLine();
            }
// OPTION 1 //
            if (userInput == "1")
            {
                Console.WriteLine("");

                entry._date = currentDateTime.ToShortDateString();
                entry._promptText = prompt.GetRandonPrompt();
                Console.WriteLine($"{entry._promptText}");
                Console.WriteLine("");
                Console.Write("> ");
                entry._entryText = Console.ReadLine();
                
                journal.AddEntry(entry);
            }
// OPTION 2 //
            else if (userInput == "2")
            {
                Console.WriteLine("");
                journal.DisplayAll();
                Console.WriteLine("-------------------------------------------------------------------------------------");
            }
// OPTION 3 //
            else if (userInput == "3")
            {
                Console.WriteLine("");

                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();

                journal.LoadFromFile($"{fileName}.txt");

                Console.WriteLine("");
            }
// OPTION 4 //
            else if (userInput == "4")
            {
                Console.WriteLine("");
                
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();

                journal.SaveToFile($"{fileName}.txt");

                Console.WriteLine("");
            }
// OPTION 5 //
            else
            {
                Console.WriteLine("");

                Console.WriteLine("Good Bye!");

                Console.WriteLine("");
            }
        }
    }
}