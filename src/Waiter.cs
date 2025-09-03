using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        private List<Table> assignedTables = new List<Table>();
        public string Name { get; }
        public Waiter(string name)
        {
            this.Name = name;
        }
        public List<Table> GetTables()
        {
            return assignedTables;
        }
        public void AssignTable(Table table)
        {
            this.assignedTables.Add(table);
        }
        public void TakeOrder(Table table, Dish dish, bool paraLlevar)
        {
            if (assignedTables.Contains(table))
            {
                if (paraLlevar)
                {
                    table.AddToOrder(dish);    
                }
                else
                {
                    table.AddToOrder(dish);
                    table.Occupy();   
                }
            }
            else
            {
                Console.WriteLine($"La mesa {table} no esta asignada al mozo {this.Name}");
            }
        }
    }
}