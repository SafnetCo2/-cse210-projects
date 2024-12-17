namespace ExerciseTracking.Core
{
    public class IntensityCalculator
    {
        public static string GetIntensity(double speed)
        {
            if (speed > 20)
                return "Intense";
            else if (speed > 10)
                return "Moderate";
            else
                return "Light";
        }
    }
}
