using System;

namespace ExerciseTracking.Core
{
    public abstract class Activity
    {
        public DateTime Date { get; set; }
        public int Minutes { get; set; }

        public Activity(DateTime date, int minutes)
        {
            Date = date;
            Minutes = minutes;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public string GetSummary()
        {
            return $"{Date:dd MMM yyyy} {this.GetType().Name} ({Minutes} min) - Distance: {Math.Round(GetDistance(), 2)} km, Speed: {Math.Round(GetSpeed(), 2)} kph, Pace: {Math.Round(GetPace(), 2)} min per km";
        }
    }
}
