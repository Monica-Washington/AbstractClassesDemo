using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    public int Year { get; set; } = 1;
    public string Make { get; set; } = "The Make";
    public string Model { get; set; } = "The Model";
    

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine($"This {Year} {Make} {Model} is virtually in drive.");
    }
    
}