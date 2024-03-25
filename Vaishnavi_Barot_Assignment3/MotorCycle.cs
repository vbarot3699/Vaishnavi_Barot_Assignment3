using System;

public class Motorcycle : Vehicle
{
    // Additional properties specific to motorcycles
    private int engineCapacity;
    private string fuelType;
    private bool hasFairing;

    // Constructor
    public Motorcycle(string model, string manufacturer, int year, double rentalPrice,
                      int engineCapacity, string fuelType, bool hasFairing)
        : base(model, manufacturer, year, rentalPrice)
    {
        EngineCapacity = engineCapacity;
        FuelType = fuelType;
        HasFairing = hasFairing;
    }

    // Properties with encapsulation
    public int EngineCapacity
    {
        get { return engineCapacity; }
        set { engineCapacity = value; }
    }

    public string FuelType
    {
        get { return fuelType; }
        set { fuelType = value; }
    }

    public bool HasFairing
    {
        get { return hasFairing; }
        set { hasFairing = value; }
    }

    // Override DisplayDetails method to display motorcycle's details
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Motorcycle Specific Details:");
        Console.WriteLine($"  Engine Capacity: {EngineCapacity} cc");
        Console.WriteLine($"  Fuel Type: {FuelType}");
        Console.WriteLine($"  Has Fairing: {(HasFairing ? "Yes" : "No")}");
    }
}
