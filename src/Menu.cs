using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();

        public Menu()
        {
        }
        public List<Dish> GetDishes()
        {
            return dishes;
        }

        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }
        public void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }

        public Dish GetDishByName(string name)
        {
            foreach (var dish in dishes)
            {
                if (dish.Name.Equals(name))
                {
                    return dish;
                }
            }

            return null;
        }
    }
}