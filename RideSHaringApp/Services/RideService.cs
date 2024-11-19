using System;
using System.Collections.Generic;
using RideSharingApp.Models;

namespace RideSharingApp.Services
{
    public class RideService
    {
        private List<Driver> Drivers;

        public RideService()
        {
            // Initialize with some sample drivers
            Drivers = new List<Driver>
            {
                new Driver("Alice", "Toyota Prius", 5),
                new Driver("Bob", "Honda Civic", 4),
                new Driver("Charlie", "Ford Focus", 4)
            };
        }

        public Ride BookRide(Rider rider)
        {
            if (Drivers.Count == 0)
            {
                throw new Exception("No drivers available.");
            }

            // Select the first available driver for simplicity
            Driver selectedDriver = Drivers[0];
            double fare = CalculateFare(rider.Location, rider.Destination);

            return new Ride(rider, selectedDriver, fare);
        }

        private double CalculateFare(string location, string destination)
        {
            // Simple fare calculation for demonstration purposes
            return new Random().Next(10, 50); // Random fare between $10 and $50
        }
    }
}
