public class ReflectionActivity : Activity
{
    private List<string> _prompts;

    public ReflectionActivity()
        : base("Reflection Activity", "This activity will help you reflect on your life and experiences.")
    {
        _prompts = new List<string>
        {
            "Reflect on a meaningful experience in your life.",
            "What is something you're grateful for today?",
            "Think about a time when you faced a challenge. What did you learn from it?",
            "Reflect on a personal achievement that you're proud of.",
            "Consider a moment that made you feel truly happy."
        };
    }

    public override void DoActivity()
    {
        DisplayStartingMessage();
        ShowCountDown(5);
        Console.WriteLine("\nChoose one of the following reflection prompts:");
        for (int i = 0; i < _prompts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_prompts[i]}");
        }

        int promptChoice = 0;
        while (promptChoice < 1 || promptChoice > _prompts.Count)
        {
            Console.Write("Enter the number of the prompt you'd like to reflect on: ");
            if (!int.TryParse(Console.ReadLine(), out promptChoice) || promptChoice < 1 || promptChoice > _prompts.Count)
            {
                Console.WriteLine("Invalid input. Please select a valid prompt number.");
            }
        }

        string selectedPrompt = _prompts[promptChoice - 1];
        Console.WriteLine($"\nPrompt: {selectedPrompt}");
        Console.WriteLine("Please take a moment to reflect...");

        Console.Write("Please enter your reflection: ");
        string reflection = Console.ReadLine();
        SaveReflection(reflection, selectedPrompt);

        DisplayEndingMessage();
    }

    private void SaveReflection(string reflection, string prompt)
    {
        string filePath = "reflection_log.txt";
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine("Date: " + DateTime.Now);
            writer.WriteLine("Prompt: " + prompt);
            writer.WriteLine("Reflection: " + reflection);
            writer.WriteLine(new string('-', 50));
        }

        Console.WriteLine("\nYour reflection has been saved!");
    }
}
