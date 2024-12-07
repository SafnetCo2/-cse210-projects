public class BreathingActivity : Activity
{
        public BreathingActivity(string activityName, string description, int duration)
            : base(activityName, description)
        {
                SetDuration(duration); // Set the duration
        }

        public override void DoActivity()
        {
                // Display the starting message
                DisplayStartingMessage();

                // Show countdown before starting the activity
                ShowCountDown(5);

                // Perform the breathing activity
                Console.WriteLine("Breathe in...  Hold... Breathe out...");
                System.Threading.Thread.Sleep(2000); // Simulating 2 seconds for each breath

                // After the activity ends, display the ending message
                DisplayEndingMessage();
        }
}
