using System;

public class Car : Vehicle
{
    // Additional properties specific to cars
    private int seats;
    private string engineType;
    private string transmission;
    private bool convertible;

    // Constructor
    public Car(string model, string manufacturer, int year, double rentalPrice,
               int seats, string engineType, string transmission, bool convertible)
        : base(model, manufacturer, year, rentalPrice)
    {
        Seats = seats;
        EngineType = engineType;
        Transmission = transmission;
        Convertible = convertible;
    }

    // Properties with encapsulation
    public int Seats
    {
        get { return seats; }
        set { seats = value; }
    }

    public string EngineType
    {
        get { return engineType; }
        set { engineType = value; }
    }

    public string Transmission
    {
        get { return transmission; }
        set { transmission = value; }
    }

    public bool Convertible
    {
        get { return convertible; }
        set { convertible = value; }
    }

    // Override DisplayDetails method to display car's details
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Car Specific Details:");
        Console.WriteLine($"  Seats: {Seats}");
        Console.WriteLine($"  Engine Type: {EngineType}");
        Console.WriteLine($"  Transmission: {Transmission}");
        Console.WriteLine($"  Convertible: {(Convertible ? "Yes" : "No")}");
    }
}
