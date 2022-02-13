using System;

namespace MAZARDIN_Lab_6
{
    // Using this pattern, the goal is to create inheritance with overriding methods provided by an interface
    // Thus, I can create all the vehicles that I want and if I want to be more specific for some of them, I can
    // just add a new child class
    public class Vehicle : Assemble // Base class for all vehicles, implements all actions provided by the assembler
    {
        // Basic method for vehicle creation that will be overridden by children classes
        public virtual Vehicle CreateVehicle() 
        {
            return new Vehicle();
        }
        
        // Implementation of the two actions provided by the interface
        public void Assemble()
        {
            Console.WriteLine("Assembling Vehicle...");
        }
        
        public void Start()
        {
            Console.WriteLine("Starting Vehicle...");
        }
    }

    public class Car : Vehicle // One of the children classes, overrides all methods provided by vehicle class
    {
        public override Vehicle CreateVehicle()
        {
            return new Car();
        }

        public new void Assemble()
        {
            Console.WriteLine("Assembling car...");
        }

        public new void Start()
        {
            Console.WriteLine("Starting car...");
        }
        
        public Car() // Also has a constructor that executes all the actions
        {
            this.Assemble();
            this.Start();
        }
    }

    public class Bike : Vehicle // Basically the same class as the "Car" class but for Bikes
    {
        public override Vehicle CreateVehicle()
        {
            return new Bike();
        }
        
        public new void Assemble()
        {
            Console.WriteLine("Assembling bike...");
        }

        public new void Start()
        {
            Console.WriteLine("Starting bike...");
        }

        public Bike()
        {
            this.Assemble();
            this.Start();
        }
    }
}