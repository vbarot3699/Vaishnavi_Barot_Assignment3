using System;

public class Vehicle
{
    // Properties
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public int Year { get; set; }
    public double RentalPrice { get; set; }
    public object Index { get; internal set; }

    // Constructor
    public Vehicle(string model, string manufacturer, int year, double rentalPrice)
    {
        Model = model;
        Manufacturer = manufacturer;
        Year = year;
        RentalPrice = rentalPrice;
    }

    // Method to display vehicle details (marked as virtual to allow overriding)
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Vehicle Details:");
        Console.WriteLine($"  Model: {Model}");
        Console.WriteLine($"  Manufacturer: {Manufacturer}");
        Console.WriteLine($"  Year: {Year}");
        Console.WriteLine($"  Rental Price: {RentalPrice:C}");
    }
}
