using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    public Car()
    {
    }
    public bool HasTrunk { get; set; } = false;
    public override void DriveAbstract()
    {
        Console.WriteLine("This car is in drive.");
        Console.WriteLine($"Has a trunk = {HasTrunk = true}");
        
    }
}