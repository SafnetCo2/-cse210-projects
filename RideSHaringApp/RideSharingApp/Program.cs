using System;

namespace RideSharingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of Nairobi areas 
            string[] nairobiLocations = new string[]
            {
                "Nairobi Central Business District (CBD)",
                "Westlands",
                "Karen",
                "Ngong Road",
                "Eastleigh",
                "Parklands",
                "Gikambura",
                "Kilimani",
                "Lang'ata",
                "Kenyatta University"
            };

            // Generate a random location
            Random rand = new Random();
            string randomLocation = nairobiLocations[rand.Next(nairobiLocations.Length)];

            // Create an instance of the driver class 
            string driverName = "Josephine";

            // Output driver status
            Console.WriteLine($"Driver {driverName} is on the way to {randomLocation}.");

            // Calculate fare (for example, $25.00)
            decimal fare = 25.00m;
            Console.WriteLine($"Estimated fare: ${fare:F2}");

            // Process the payment
            ProcessPayment(fare);

            // Confirm payment completion
            Console.WriteLine("Payment completed.");
        }

        // Method to simulate payment processing
        static void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Attempting to process payment of ${amount:F2}...");
            // Simulate payment processing
            Console.WriteLine($"Payment of ${amount:F2} processed successfully!");
        }
    }
}
// to run the program dotnet run