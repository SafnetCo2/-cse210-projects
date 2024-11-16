using System;

public class Entry
{
    // Private member variables to store details
    private string _date;
    private string _prompt;
    private string _response;
    private string _priority;
    private string _nextSteps;

    // Constructor to initialize the entry 
        public Entry(string date, string prompt, string response, string priority= "", string nextSteps = "")
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        _priority= priority;
        _nextSteps = nextSteps;
    }

    // Method to display the entry
    public void Display()
    {
        Console.WriteLine("Date: " + _date);
        Console.WriteLine("Prompt: " + _prompt);
        Console.WriteLine("Response: " + _response);

        // Only display priority goal if is not empty
        if (!string.IsNullOrEmpty(_priority))
        {
            Console.WriteLine("priority: " + _priority);
        }

        // Only display nextSteps if it is not empty
        if (!string.IsNullOrEmpty(_nextSteps))
        {
            Console.WriteLine("nextSteps: " + _nextSteps);
        }

        Console.WriteLine("-------------------------");
    }
}
