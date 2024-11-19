namespace RideSharingApp.Models
{
    public class Ride
    {
        public Rider Rider { get; set; }
        public Driver Driver { get; set; }
        public double Fare { get; set; }

        public Ride(Rider rider, Driver driver, double fare)
        {
            Rider = rider;
            Driver = driver;
            Fare = fare;
        }

        public override string ToString()
        {
            return $"Rider: {Rider.Name}, Driver: {Driver.Name}, Fare: ${Fare:F2}";
        }
    }
}

