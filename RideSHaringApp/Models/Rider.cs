namespace RideSharingApp.Models
{
    public class Rider
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Destination { get; set; }

        public Rider(string name, string location, string destination)
        {
            Name = name;
            Location = location;
            Destination = destination;
        }

        public override string ToString()
        {
            return $"{Name} (From: {Location}, To: {Destination})";
        }
    }
}
