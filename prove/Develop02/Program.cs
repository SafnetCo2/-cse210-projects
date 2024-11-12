using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Initialize classes
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            // Display the menu
            Console.WriteLine("\n Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            // Read the user's choice
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Generate a prompt and get the user's response
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine("Prompt: " + prompt);
                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();

                    // Create and add a new entry
                    Entry newEntry = new Entry(DateTime.Now.ToString(), prompt, response);
                    myJournal.AddEntry(newEntry);
                    break;

                case "2":
                    // Display all entries
                    Console.WriteLine("\nAll Journal Entries:");
                    myJournal.DisplayAll();
                    break;

                case "3":
                    // Save journal to a file
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    myJournal.SaveToFile(saveFilename);
                    Console.WriteLine("Journal saved.");
                    break;

                case "4":
                    // Load journal from a file
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    myJournal.LoadFromFile(loadFilename);
                    Console.WriteLine("Journal loaded.");
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
