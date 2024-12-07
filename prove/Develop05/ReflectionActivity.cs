using System;
using System.IO;
using System.Threading;

public class ReflectionActivity : Activity
{
    private static Random random = new Random();
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private string logFilePath = "reflection_log.txt"; // Path to store the logs

    public ReflectionActivity()
        : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    // Ensure this is overridden from Activity
    public override void DoActivity()
    {
        // Display the welcome message and the "Get Ready" message at the start of the activity
        Console.WriteLine("\nWelcome to the Reflection Activity!");
        Console.WriteLine("In this activity, you will reflect on meaningful experiences that have helped shape who you are today.");
        Console.WriteLine("Take your time and think deeply about your responses. Let's begin!\n");

        // Load previous logs if available
        LoadLogs();

        // Get ready message with a spinner
        Console.WriteLine("Get ready...");
        ShowSpinner(3);  // Shows spinner for 3 seconds

        // Display a random prompt
        string randomPrompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine($"\nPrompt: {randomPrompt}\n");

        // Log the prompt to the log file
        LogToFile($"Prompt: {randomPrompt}");

        // Ask reflection questions for the specified duration
        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            foreach (string question in questions)
            {
                if (elapsedTime >= _duration)
                    break;

                // Ask the question
                Console.WriteLine($"\nQuestion: {question}\n");
                LogToFile($"Question: {question}");

                // Capture user's reflection
                string userResponse = Console.ReadLine();
                LogToFile($"Answer: {userResponse}");

                // Show spinner for 3 seconds pause between questions
                ShowSpinner(3);
                elapsedTime += 3; // Increment the elapsed time by 3 seconds for each question
            }
        }

        // Ending message after activity completion
        base.DisplayEndingMessage(); // Calls the base class method
        Console.WriteLine("\nGood job reflecting on your experiences.\n");
    }

    // Display a simple spinner animation for "Get Ready" message
    private void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int counter = 0;
        for (int i = 0; i < seconds * 2; i++) // Spinner runs for 'seconds' seconds
        {
            Console.Write("\r" + spinner[counter]);
            counter = (counter + 1) % spinner.Length;
            Thread.Sleep(500); // Wait for half a second before updating the spinner
        }
        Console.WriteLine(); // Move to the next line after the spinner ends
    }

    // Method to save logs to the file
    private void LogToFile(string message)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error logging to file: {ex.Message}");
        }
    }

    // Method to load previous logs and display them
    private void LoadLogs()
    {
        if (File.Exists(logFilePath))
        {
            Console.WriteLine("\nPrevious Reflection Activity Logs:\n");

            try
            {
                string[] logs = File.ReadAllLines(logFilePath);
                foreach (var log in logs)
                {
                    Console.WriteLine(log);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading logs: {ex.Message}");
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No previous logs found.\n");
        }
    }
}
