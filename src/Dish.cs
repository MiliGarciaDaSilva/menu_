namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        private string Name { get; set; }
        private double Price { get; set; }
        private bool IsVegetarian { get; set; }

        public Dish(string Name, double Price, bool IsVegetarian)
        {
            this.Name = Name;
            this.Price = Price;
            this.IsVegetarian = IsVegetarian;
        }
        
    }
}