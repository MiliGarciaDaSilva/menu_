namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        private string name;
        private double price;
        private bool isVegetarian;

        public Dish(string name, double price, bool isVegetarian)
        {
            this.name = name;
            this.price = price;
            this.isVegetarian = isVegetarian;
        }
        
    }
}