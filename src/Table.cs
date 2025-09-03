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

        public Table(int number)
        {
            this.Number = number;
            this.IsOccupied = false;
            this.order = new List<Dish>();
        }

        public void Occupy()
        {
            this.IsOccupied = true;
        }

        public void Free()
        {
            this.IsOccupied = false;
            this.order.Clear();
        }

        public void AddToOrder(Dish dish)
        {
            this.order.Add(dish);
        }
        
        public bool HasOrders()
        {
            return this.order.Count > 0;
        }

        public double GetTotal()
        {
            double precioTotal = 0;
            foreach (var dish in order)
            {
                precioTotal += dish.Price;
            }
            return precioTotal;
        }
    }
}