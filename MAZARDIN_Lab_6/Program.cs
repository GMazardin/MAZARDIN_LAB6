using System;
using System.Collections.Generic;

namespace MAZARDIN_Lab_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Exercise 2 Pizza
            //-------------INITIALIZATION--------------------
            PizzaBuilder builder = new PizzaBuilder();
            builder.SetBase("Tomato");
            builder.SetCheese();
            builder.SetIngredients("Ham, Chorizo, Pepper");
            
            //------------------DISPLAY----------------------
            Console.WriteLine("Exercise 2.2 Pizza !");
            Console.WriteLine(builder);


            Console.WriteLine("\n*************************************");
            //Exercise 4 with Vehicles on Factory Method Design Pattern
            Console.WriteLine("\nExercise 2.4 Vehicles !");
            Car car = new Car();
            Bike bike = new Bike();
            
            // Test of inheritance here, the output should show a car, thus allowing us to create only vehicles and
            // specify them in the classes afterwards
            Console.WriteLine();
            Vehicle car2 = new Car(); 
        }
    }
}