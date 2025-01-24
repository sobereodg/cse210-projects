using System;

class Program
{
    static void Main(string[] args)
    {
        {
        // Create the reference (e.g., "Proverbs 3:5-6")
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        // Create the scripture text
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";

        // Create the Scripture object
        Scripture scripture = new Scripture(reference, scriptureText);

        // Display the full scripture
        Console.Clear();
        Console.WriteLine("Memorization Helper");
        Console.WriteLine("====================");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        // Main loop
        while (true)
        {
            Console.WriteLine("Press Enter to hide random words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            // Hide random words
            scripture.HideRandomWords(3); // Hide 3 random words at a time
            Console.Clear();

            // Display the updated scripture
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            // Check if the scripture is completely hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }
        }
    };
    }
}