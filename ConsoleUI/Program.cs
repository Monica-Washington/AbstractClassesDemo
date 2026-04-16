using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle (done)
             * The vehicle class shall have three string properties: Year, Make, and Model (done) 
             * Set the defaults of the properties to something generic in the Vehicle class (done)
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation. (done)
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation. (done)
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle (done)
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle (done)
             * Provide the implementations for the abstract methods (done)
             * Only in the Motorcycle class will you override the virtual drive method (done)
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constructors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */
            var cts = new Car() { HasTrunk = true, Make = "Cadillac", Model = "CTS", Year = 2019 };
            var motorcycle = new Motorcycle()
                { HasSideCart = false, Make = "Honda", Model = "Gold Wing", Year = 2022 };
            Vehicle sedan = new Car() { HasTrunk = true, Make = "Toyota", Model = "Camry", Year = 1998 };
            Vehicle sportsCar = new Car() { HasTrunk = true, Make = "Dodge", Model = "Challenger", Year = 2009 };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
            vehicles.Add(cts);
            vehicles.Add(motorcycle);
            vehicles.Add(sedan);
            vehicles.Add(sportsCar);
            
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}, Make: {vehicle.Make}, Model: {vehicle.Model}");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                
                Console.WriteLine("___________________________________");
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
