using System;
using RideSharingApp.Models;
using RideSharingApp.Services;

namespace RideSharingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RideService rideService = new RideService();

            Console.WriteLine("Welcome to the Ride Sharing App!");
            Console.Write("Enter your name: ");
            string riderName = Console.ReadLine();
            Console.Write("Enter your location: ");
            string location = Console.ReadLine();
            Console.Write("Enter your destination: ");
            string destination = Console.ReadLine();

            Rider rider = new Rider(riderName, location, destination);

            try
            {
                Ride ride = rideService.BookRide(rider);
                Console.WriteLine("Ride booked successfully!");
                Console.WriteLine(ride);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
