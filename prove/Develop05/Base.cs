public abstract class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    // Constructor to initialize activity name and description
    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    // Set the duration for the activity
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // Abstract method to be implemented by derived classes
    public abstract void DoActivity();

    // Standard method to display the starting message for all activities
    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_activityName}: {_description}");
    }

    // Standard method to display the ending message for all activities
    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {_activityName}");
    }

    // Method to show a countdown before the activity starts
    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000); 
        }
    }
}
