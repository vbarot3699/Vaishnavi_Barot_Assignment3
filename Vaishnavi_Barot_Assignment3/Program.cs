using System;

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        RentalAgency agency = new RentalAgency(10);

        Car car = new Car("SUV", "Toyota", 2022, 100, 5, "Petrol", "Automatic", false);
        Truck truck = new Truck("F150", "Ford", 2020, 150, 4, "Pickup", true);
        Motorcycle bike = new Motorcycle("Ninja", "Kawasaki", 2021, 80, 1000, "Petrol", true);

        agency.AddVehicle(car, 0);
        agency.AddVehicle(truck, 1);
        agency.AddVehicle(bike, 2);

        // Displaying details of vehicles
        Console.WriteLine("Details of vehicles in the fleet:");
        foreach (Vehicle vehicle in agency.Fleet)
        {
            if (vehicle != null)
            {
                vehicle.DisplayDetails();
                Console.WriteLine();
            }
        }

        // Renting a vehicle
        agency.RentVehicle();

        Console.WriteLine("\nThank you for using our rental service. Have a great day!");
    }
}
