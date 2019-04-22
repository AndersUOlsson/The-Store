using System;

namespace TheStore
{
    class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string Category { get; set; }

        public int Quantity { get; set; }

        public Guid Id { get; set;}

        internal Stock Stock
        {
            get => default(Stock);
            set
            {
            }
        }

        internal FileHandler FileHandler
        {
            get => default(FileHandler);
            set
            {
            }
        }

        public Form1 Form1
        {
            get => default(Form1);
            set
            {
            }
        }


        /// <summary>  
        ///  Constructor for a product.
        /// </summary> 
        public Product(string Name, string Price, string Category, string Quantity)
        {
            this.Name = Name;
            this.Id = Guid.NewGuid();
            this.Price = double.Parse(Price);
            this.Category = Category;
            this.Quantity = int.Parse(Quantity);
        }
    }
}
