using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 4);

        string scriptureText = "";
        Reference reference = new Reference("", 0, 0, 0);

        if (number == 1)
        {
            scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
            reference = new Reference("Proverbs", 3, 5, 6);
        }

        else if (number == 2)
        {
            scriptureText = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
            reference = new Reference("Nephi", 3, 7);
        }

        else
        {
            scriptureText = "Now my son, I would that ye should repent and forsake your sins, and go no more after the alusts of your eyes, but bcross yourself in all these things; for except ye do this ye can in nowise inherit the kingdom of God. Oh, remember, and take it upon you, and ccross yourself in these things.";
            reference = new Reference("Alma", 39, 9);
        }

        string[] wordsArray = scriptureText.Split(' ');
        List<Word> wordsList = new List<Word>();
        foreach (string wordText in wordsArray)
        {
            wordsList.Add(new Word(wordText));
        }

        Scripture scripture = new Scripture(reference, wordsList);

        do
        {
            Console.Clear();
            scripture.GetDisplayText();

            Console.WriteLine("\nPress Enter to continue, type 'quit' to finish and type 'rerol' to rerol the hidden words:");
            Console.WriteLine(" ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            else if (input.ToLower() == "rerol")
            {
                scripture.RerolForWords(16);
            }


            scripture.HideRandomWords(6);

        } while (!scripture.IsCompletelyHidden());


    }
}