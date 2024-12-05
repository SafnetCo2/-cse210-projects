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
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        ShowCountDown(5);

        List<string> userList = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Please enter an item (or type 'done' to finish): ");
            string item = Console.ReadLine();
            if (item.ToLower() == "done") break;
            userList.Add(item);
        }

        Console.WriteLine($"You listed {userList.Count} items.");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}
