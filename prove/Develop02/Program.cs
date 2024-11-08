using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Initialize classes
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        // Generate a random prompt and display it
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine("Prompt: " + prompt);

        // Create a new entry based on the prompt
        Entry newEntry = new Entry(DateTime.Now.ToString(), prompt, 
        "Just feel overwhelmed today with class assignments");
        

    
        myJournal.AddEntry(newEntry);

        // Display all entries 
        Console.WriteLine("\nAll Journal Entries:");
        myJournal.DisplayAll();

        myJournal.SaveToFile("journal.txt");

    }
}
