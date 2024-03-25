using System;

public class Truck : Vehicle
{
    // Additional properties specific to trucks
    private int capacity;
    private string truckType;
    private bool fourWheelDrive;

    // Constructor
    public Truck(string model, string manufacturer, int year, double rentalPrice,
                 int capacity, string truckType, bool fourWheelDrive)
        : base(model, manufacturer, year, rentalPrice)
    {
        Capacity = capacity;
        TruckType = truckType;
        FourWheelDrive = fourWheelDrive;
    }

    // Properties with encapsulation
    public int Capacity
    {
        get { return capacity; }
        set { capacity = value; }
    }

    public string TruckType
    {
        get { return truckType; }
        set { truckType = value; }
    }

    public bool FourWheelDrive
    {
        get { return fourWheelDrive; }
        set { fourWheelDrive = value; }
    }

    // Override DisplayDetails method to display truck's details
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Truck Specific Details:");
        Console.WriteLine($"  Capacity: {Capacity}");
        Console.WriteLine($"  Truck Type: {TruckType}");
        Console.WriteLine($"  Four Wheel Drive: {(FourWheelDrive ? "Yes" : "No")}");
    }
}
