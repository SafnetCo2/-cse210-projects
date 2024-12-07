public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity(string activityName, string description)
        : base(activityName, description)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public override void DoActivity()
    {
        // Display the welcome message
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Welcome to the Listing Activity!");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.ResetColor();
        Console.WriteLine();

        // Display the standard starting message
        DisplayStartingMessage();

        // Prompt the user for the activity duration
        Console.Write("Enter activity duration in seconds: ");
        _duration = int.Parse(Console.ReadLine()); // Set the duration

        // Load previous logs if available
        LoadLogs();

        // Show "Get ready!" message with spinner
        Console.Clear();
        Console.WriteLine("Get ready!");
        DisplaySpinner(3); 
        // Show a random prompt
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Consider this prompt: \n\"{prompt}\"");
        Console.WriteLine();

        // Countdown to allow the user to begin thinking
        Countdown(5);

        // Allow user to start listing items
        List<string> userList = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        // prompting the user to list items until the time is up or they type 'done'
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Start listing items (type 'done' to finish):");
            string item;
            do
            {
                Console.Write("> ");
                item = Console.ReadLine();

                if (item.ToLower() == "done")
                    break;

                userList.Add(item); 
                // Log the user entry
                LogToFile($"Item: {item}");
            }
            while (true);

            // After the user finishes, check if they want to continue
            if (item.ToLower() == "done")
                break;
        }

        // Show the results and log the total number of items
        Console.WriteLine($"You listed {userList.Count} items.");
        LogToFile($"Total items listed: {userList.Count}");


    }

    // Get a random prompt from the list
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    // Countdown before the user starts listing
    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            System.Threading.Thread.Sleep(1000); // 1-second delay
        }
        Console.WriteLine("\nStart listing items now!");
    }

    // Method to save logs to the file
    private void LogToFile(string message)
    {
        string logFilePath = "listing_activity_log.txt";
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
        string logFilePath = "listing_activity_log.txt";
        if (File.Exists(logFilePath))
        {
            Console.WriteLine("\nPrevious Listing Activity Logs:\n");

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

    // Override the starting message to ensure correct functionality
    public override void DisplayStartingMessage()
    {
        Console.WriteLine("Let's begin listing items based on the prompt you see!");
        Console.WriteLine();
    }

    // Override the ending message
    public override void DisplayEndingMessage()
    {
        Console.WriteLine("\nEnding Listing Activity.");
        Console.WriteLine("Thank you for participating!");
    }

    // Display a simple spinner animation for "Get ready!" message
    private void DisplaySpinner(int durationInSeconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        int spinnerIndex = 0;
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[spinnerIndex]);
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            System.Threading.Thread.Sleep(200); 
            Console.Write("\b"); 
        }
    }
}
