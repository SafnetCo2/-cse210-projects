using System;

public class BreathingActivity : Activity
{
        public BreathingActivity(string activityName, string description) : base(activityName, description)
        {
        }

        public override void DoActivity()
        {
                DisplayStartingMessage();
                ShowCountDown(5);

                // Call the breathing animation method
                DisplayBreathingAnimation(_duration);

                DisplayEndingMessage();
        }

        public void DisplayBreathingAnimation(int duration)
        {
                int totalSteps = duration / 2;  // Half the time for inhaling and half for exhaling
                for (int i = 0; i < totalSteps; i++)
                {
                        // Inhale animation
                        Console.Clear();
                        Console.WriteLine("Breathe in...");
                        for (int j = 0; j < i; j++)
                        {
                                Console.Write(".");
                                System.Threading.Thread.Sleep(100);  // Adjust speed
                        }
                        System.Threading.Thread.Sleep(500);  // Pause between in and out

                        // Exhale animation
                        Console.Clear();
                        Console.WriteLine("Breathe out...");
                        for (int j = 0; j < i; j++)
                        {
                                Console.Write(".");
                                System.Threading.Thread.Sleep(100);  // Adjust speed
                        }
                        System.Threading.Thread.Sleep(500);  // Pause between in and out
                }
        }
}
