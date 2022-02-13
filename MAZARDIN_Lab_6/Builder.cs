using System.Collections.Generic;

namespace MAZARDIN_Lab_6
{
    // Interface that declares all the methods that we will use in order to build the Pizza
    public interface Builder
    {
        void Reset(); // To create the new pizza
        void SetBase(string pizzaBase); // To set the pizza base (tomato or cream)
        void SetCheese(); // To add Mozzarella
        void SetIngredients(string ingredients); // To add other ingredients
    }
}