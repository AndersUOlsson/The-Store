using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TheStore
{
    class Stock
    {
        public List<Product> products = new List<Product>();
        FileHandler FileHandler;

        /// <summary>  
        ///  Constructor for stock. Creates a instance of filehandler and 
        ///  reads products form file and adds to products.
        /// </summary> 
        public Stock()
        {
            FileHandler = new FileHandler();
            products = FileHandler.ReadCSV();
        }

        /// <summary>  
        ///  Returns the stock of the store.
        /// </summary> 
        public List<Product> GetStock()
        {
            return products;
        }

        /// <summary>  
        ///  Remove a product from stock and rewrite the stock to file. 
        /// </summary> 
        public void RemoveProduct(List<Product> products)
        {
            //Write to file.
            WriteToFile();

        }

        /// <summary>  
        ///  Add a product from stock and rewrite the stock to file. 
        /// </summary> 
        public void AddProduct(Product product)
        {
            
            bool flag = false;
            //Checks if the product is already in the stock. 
            if (products.Count == 0)
            {
                products.Add(product);
            }
            else
            {
                //If the product is int the store, add the quantity to the product only.
                //Returns a bool for check.
                flag = AddAlreadyExistingProduct(product, flag);

                if (!flag)
                {
                    products.Add(product);
                }
            }
            //Write to file
            WriteToFile();
        }

        /// <summary>  
        ///  Add quantity to a product (not a new product but add more of that product to the stock).
        /// </summary> 
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

        /// <summary>  
        ///  When adding a order for a specific product already in stock, quantity increase.
        /// </summary> 
        public void AddToExistedProduct(string id, string quant)
        {
            foreach(Product p in products)
            {
                if(p.Id.ToString().Contains(id))
                {
                    p.Quantity += int.Parse(quant.ToString());
                    break;
                }
            }

            //Write to file.
            WriteToFile();
        }

        /// <summary>  
        ///  Remove product from stock. 
        /// </summary> 
        public void RemoveProduct(string id)
        {
            foreach (Product p in products)
            {
                if (p.Id.ToString().Contains(id))
                {
                    //If product quantity is over 0, give a dialogbox asking if they want to remove product. 
                    if (p.Quantity > 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Vill du ta bort", "Varning", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            products.Remove(p);
                            break;
                        }
                    }
                    else
                    {
                        products.Remove(p);
                        break;
                    }
                }
            }
            WriteToFile();
        }

        /// <summary>  
        ///  Write to file.
        /// </summary> 
        private void WriteToFile()
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
    }
}
