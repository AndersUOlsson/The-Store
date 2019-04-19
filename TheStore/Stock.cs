using System.Collections.Generic;
using System.IO;

namespace TheStore
{
    class Stock
    {
        public List<Product> products = new List<Product>();
        FileHandler FileHandler;
        Form1 Form1;

        public Stock()
        {
            FileHandler = new FileHandler();
            products = FileHandler.ReadCSV();
        }

        public List<Product> GetStock()
        {
            return products;
        }

        public void RemoveProduct(List<Product> products)
        {
            try
            {
                FileHandler.WriteCSV(products);
            }
            catch (IOException e)
            {
                throw e;
            }
        }

        /// <summary>  
        ///  
        /// </summary> 
        public void AddProduct(Product product)
        {
            bool flag = false;
            if (products.Count == 0)
            {
                products.Add(product);
            }
            else
            {
                flag = AddAlreadyExistingProduct(product, flag);

                if (!flag)
                {
                    products.Add(product);
                }
            }

            try
            {
                FileHandler.WriteCSV(products);
            }
            catch(IOException e )
            {
                throw e;
            }
        }

        public bool AddAlreadyExistingProduct(Product product, bool flag)
        {
            foreach (var p in products)
            {
                if (p.Id.Equals(product.Id)
                    && p.Name.Equals(product.Name)
                    && p.Category.Equals(product.Category)
                    && p.Price == product.Price)
                {
                    p.Quantity += product.Quantity;
                    flag = true;
                }
            }

            return flag;
        }
    }
}
