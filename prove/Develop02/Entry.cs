using System;

public class Entry
{
    // Private member variables to store details
    private string _date;
    private string _prompt;
    private string _response;
    private string _mood;
    private string _location;

    // Constructor to initialize the entry 
        public Entry(string date, string prompt, string response, string mood = "", string location = "")
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        _mood = mood;
        _location = location;
    }

    // Method to display the entry
    public void Display()
    {
        Console.WriteLine("Date: " + _date);
        Console.WriteLine("Prompt: " + _prompt);
        Console.WriteLine("Response: " + _response);

        // Only display Mood if it is not empty
        if (!string.IsNullOrEmpty(_mood))
        {
            Console.WriteLine("Mood: " + _mood);
        }

        // Only display Location if it is not empty
        if (!string.IsNullOrEmpty(_location))
        {
            Console.WriteLine("Location: " + _location);
        }

        Console.WriteLine("-------------------------");
    }
}
