using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public bool HasSideCart {get; set;} = false; 

    public override void DriveAbstract()
    {
        Console.WriteLine($"This motorcycle is in drive.");
    }
    public override void DriveVirtual()
    {
        Console.WriteLine($"This {Year}, {Make}, {Model} motorcycle is virtually in drive.");
        Console.WriteLine($"Has a side cart =  {HasSideCart = false}");
    }
}