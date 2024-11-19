namespace RideSharingApp.Models
{
    public class Driver
    {
        public string Name { get; set; }
        public string Vehicle { get; set; }
        public int Rating { get; set; }

        public Driver(string name, string vehicle, int rating)
        {
            Name = name;
            Vehicle = vehicle;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"{Name} (Vehicle: {Vehicle}, Rating: {Rating}/5)";
        }
    }
}
