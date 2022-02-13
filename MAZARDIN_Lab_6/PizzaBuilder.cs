using System.Collections.Generic;

namespace MAZARDIN_Lab_6
{
    public class Pizza
    {
        // The pizza has three characteristics : its base, the mozzarella, and its other ingredients
        public string PizzaBase;
        public string Cheese;
        public string Ingredients;
    }

    public class PizzaBuilder : Builder // Class that will do all the steps to create the final pizza
    {
        private Pizza pizza;

        public PizzaBuilder() // Constructor
        {
            this.Reset(); // Basically creates a new blank pizza, see its declaration just below
        }
        
        public void Reset()
        {
            this.pizza = new Pizza();
        }

        public void SetBase(string PizzaBase) // Sets the base
        {
            this.pizza.PizzaBase = PizzaBase;
        }

        public void SetCheese() // Sets the Mozzarella
        {
            this.pizza.Cheese = "Mozzarella";
        }

        public void SetIngredients(string Ingredients) // Sets the ingredients
        {
            this.pizza.Ingredients = Ingredients;
        }

        public override string ToString() // Display method for the code run
        {
            return "Base : " + this.pizza.PizzaBase + "\nCheese : " + this.pizza.Cheese + "\nIngredients : " +
                   this.pizza.Ingredients;
        }
    }
}