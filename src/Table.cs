using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        public int Number  { get; }
        public bool IsOccupied { get; set; }
        private List<Dish> order = new List<Dish>();

        public Table(int number, bool isOccupied)
        {
            Number = number;
            IsOccupied = isOccupied;
            order = new List<Dish>();
        }

        public void Occupy()
        {
            IsOccupied = true;
        }

        public void Free()
        {
            IsOccupied = false;
            order.Clear();
        }

        public void AddOrder(Dish dish)
        {
            order.Add(dish);
        }
        
        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
}