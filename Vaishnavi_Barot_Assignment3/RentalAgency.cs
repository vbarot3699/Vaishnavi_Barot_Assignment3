// Vaishnavi Barot
// 8975398

using System;

public class RentalAgency
{
    // Private fields
    private Vehicle[] fleet;
    private double totalRevenue;

    // Constructor
    public RentalAgency(int capacity)
    {
        Fleet = new Vehicle[capacity];
    }

    // Properties with encapsulation
    public Vehicle[] Fleet
    {
        get { return fleet; }
        private set { fleet = value; }
    }

    public double TotalRevenue
    {
        get { return totalRevenue; }
        private set { totalRevenue = value; }
    }

    // Method to add a vehicle to the fleet
    public void AddVehicle(Vehicle vehicle, int index)
    {
        if (index >= 0 && index < Fleet.Length)
        {
            Fleet[index] = vehicle;
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    // Method to remove a vehicle from the fleet
    public void RemoveVehicle(int index)
    {
        if (index >= 0 && index < Fleet.Length)
        {
            Fleet[index] = null;
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    // Method to rent a vehicle
    public void RentVehicle()
    {
        while (true)
        {
            Console.WriteLine("\nSelect a vehicle by entering its number:");
            DisplayAvailableVehicles();
            int vehicleNumber;
            if (!int.TryParse(Console.ReadLine(), out vehicleNumber) || vehicleNumber <= 0 || vehicleNumber > Fleet.Length)
            {
                Console.WriteLine("Invalid vehicle number. Please try again.");
                continue;
            }

            int index = vehicleNumber - 1; // Adjust index for human-readable vehicle number

            if (Fleet[index] != null)
            {
                Vehicle selectedVehicle = Fleet[index];

                Console.WriteLine($"You have selected: {selectedVehicle.Manufacturer} {selectedVehicle.Model}");

                Console.WriteLine("Enter the number of days you want to rent the vehicle:");
                int rentalDays;
                if (!int.TryParse(Console.ReadLine(), out rentalDays) || rentalDays <= 0)
                {
                    Console.WriteLine("Invalid input for rental days.");
                    continue;
                }

                Console.WriteLine("Do you want to add insurance? (yes/no)");
                string insuranceChoice = Console.ReadLine().ToLower();
                bool hasInsurance = insuranceChoice == "yes";

                double rentalCost = selectedVehicle.RentalPrice * rentalDays;
                double insuranceCost = hasInsurance ? 50 : 0;
                double totalCost = rentalCost + insuranceCost;

                Console.WriteLine("\n--- Booking Summary ---");
                Console.WriteLine($"Rental cost for {rentalDays} days: {rentalCost:C}");
                Console.WriteLine($"Insurance cost: {insuranceCost:C}");
                Console.WriteLine($"Total cost: {totalCost:C}");
                Console.WriteLine($"({rentalCost:C} for Rental vehicle and {insuranceCost:C} for Insurance)");

                // Confirmation and greeting message
                Console.WriteLine("\nYour booking is confirmed. Enjoy your ride!");
                Console.WriteLine("Thank you for choosing our rental agency.");

                // Update total revenue
                TotalRevenue += totalCost;

                // Mark the vehicle as rented
                Fleet[index] = null;

                // Ask if the customer wants to rent another car
                Console.WriteLine("\nDo you want to rent another car? (yes/no)");
                string rentAnother = Console.ReadLine().ToLower();
                if (rentAnother != "yes")
                {
                    Console.WriteLine("\nThank you for using our rental service. Have a great day!");
                    Environment.Exit(0); // Close the program
                }
            }
            else
            {
                Console.WriteLine("Vehicle not available. Please select another one.");
            }
        }
    }

    // Method to display available vehicles
    private void DisplayAvailableVehicles()
    {
        Console.WriteLine("Available Vehicles:");
        for (int i = 0; i < Fleet.Length; i++)
        {
            if (Fleet[i] != null)
            {
                Console.WriteLine($"{i + 1}. {Fleet[i].Manufacturer} {Fleet[i].Model}");
            }
        }
    }
}
