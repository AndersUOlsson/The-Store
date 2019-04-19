using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStore
{
    class Order
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string Category { get; set; }

        public int Quantity { get; set; }

       

        public Order(string Name, string Price, string Category, string Quantity)
        {
            this.Name = Name;
            this.Price = double.Parse(Price);
            this.Category = Category;
            this.Quantity = int.Parse(Quantity);
        }
        
    }
}
