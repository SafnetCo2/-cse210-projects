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

    private string[] bibleQuotes = {
        "But the fruit of the Spirit is love, joy, peace, forbearance, kindness, goodness, faithfulness, gentleness and self-control. – Galatians 5:22-23",
        "And let us not grow weary of doing good, for in due season we will reap, if we do not give up. – Galatians 6:9",
        "The generous will themselves be blessed, for they share their food with the poor. – Proverbs 22:9",
        "Do nothing out of selfish ambition or vain conceit. Rather, in humility value others above yourselves. – Philippians 2:3",
        "Each of you should use whatever gift you have received to serve others, as faithful stewards of God’s grace in its various forms. – 1 Peter 4:10"
    };

    private string logFilePath = "reflection_log.txt"; // Path to store the logs

    public ReflectionActivity() : base("", "")
    {
        // Display the welcome message with color
        Console.ForegroundColor = ConsoleColor.Cyan; // Set color to Cyan for the welcome message
        Console.WriteLine("\nWelcome to the Reflection Activity!");
        Console.ResetColor(); // Reset the color to default
    }

    // Ensure this is overridden from Activity
    public override void DoActivity()
    {
        Console.WriteLine("In this activity, you will reflect on meaningful experiences that have helped shape who you are today.");
        Console.WriteLine("Take your time and think deeply about your responses. Let's begin!\n");

        
        LoadAndDisplayLastLogs(3);

        Console.WriteLine("Get ready...");
        ShowSpinner(5);  
        string randomPrompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine($"\nPrompt: {randomPrompt}\n");

        // Log the prompt to the log file
        LogToFile($"Prompt: {randomPrompt}");


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

                                DisplayBibleQuote();

                
                ShowSpinner(3);
                elapsedTime += 3; 
                
            }
        }

        
        base.DisplayEndingMessage(); 
        Console.WriteLine("\nGood job reflecting on your experiences.\n");
    }

    private void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int counter = 0;
        for (int i = 0; i < seconds * 2; i++)
    
        {
            Console.Write("\r" + spinner[counter]);
            counter = (counter + 1) % spinner.Length;
            Thread.Sleep(500); 
            
        }
        Console.WriteLine(); 
        
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

    // Method to load and display only the last 'count' logs
    private void LoadAndDisplayLastLogs(int count)
    {
        if (File.Exists(logFilePath))
        {
            try
            {
                string[] logs = File.ReadAllLines(logFilePath);

                // Display only the last 'count' logs
                int startIndex = Math.Max(0, logs.Length - count);
                Console.WriteLine("\nPrevious Reflection Activity Logs:\n");
                for (int i = startIndex; i < logs.Length; i++)
                {
                    Console.WriteLine(logs[i]);
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

    // Method to display a random Bible quote after user response
    private void DisplayBibleQuote()
    {
        // Pick a random Bible quote
        string randomBibleQuote = bibleQuotes[random.Next(bibleQuotes.Length)];

        //  color to Green for the Bible quote
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nBible Quote: " + randomBibleQuote);
        Console.ResetColor(); 
    }
}
