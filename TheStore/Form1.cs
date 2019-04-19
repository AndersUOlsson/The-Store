using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TheStore
{
    public partial class Form1 : Form
    {
        Stock stock = new Stock();
        List<Product> products;
        private List<Order> orders = new List<Order>();
        string[] productInformation = new string[5];

        public Form1()
        {
            InitializeComponent();
            DisplayStock();
            WareHouseGridView.Visible = false;
        }


        public void Display()
        {
            //use binding source to hold dummy data
            BindingSource binding = new BindingSource();
            binding.DataSource = products;

            //bind datagridview to binding source
            WareHouseGridView.DataSource = binding;
        }


        public void DisplayStock()
        {
            products = stock.GetStock();
            //use binding source to hold dummy data
            BindingSource binding = new BindingSource();
            binding.DataSource = products;

            //bind datagridview to binding source
            StoreDataGridView.DataSource = binding;

            BindingSource bindingShoppingCart = new BindingSource();
            bindingShoppingCart.DataSource = orders;

            //bind datagridview to binding source
            ShoppingCartDataGridView.DataSource = bindingShoppingCart;
        }

        private void Registrerabutton_Click_1(object sender, EventArgs e)
        {
           
            foreach(DataGridViewRow row in StoreDataGridView.Rows)
            {
                int check = int.Parse(row.Cells[3].Value.ToString());
                if(row.Selected && check > 0)
                {
                    bool flag = false;
                    if(ShoppingCartDataGridView.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow r in ShoppingCartDataGridView.Rows)
                        {
                            if (r.Cells[0].Value.ToString().Contains(row.Cells[0].Value.ToString()))
                            {
                                int q = int.Parse(r.Cells[3].Value.ToString());
                                q++;
                                r.Cells[3].Value = q.ToString();
                                r.Cells[3].Value.ToString();
                                flag = true;
                                break;
                                
                            }
                        }
                    }


                    if(!flag)
                    {
                        orders.Add(new Order(
                                    row.Cells[0].Value.ToString(),
                                    row.Cells[1].Value.ToString(),
                                    row.Cells[2].Value.ToString(),
                                    "1"));
                        int qua = int.Parse(row.Cells[3].Value.ToString()) - 1;
                        row.Cells[3].Value = qua.ToString();
                        break;
                    }
                    

                    int quantity = int.Parse(row.Cells[3].Value.ToString()) - 1;
                    row.Cells[3].Value = quantity.ToString();
                    
                    break;
                }
            }

            DisplayStock();
        }

        
        private void NameOfItemTextBox_TextChanged(object sender, EventArgs e)
        {
             productInformation[0] = ((TextBox)sender).Text.ToString();
        }

        private void HowManyItemsTextBox_TextChanged(object sender, EventArgs e)
        {
            productInformation[1] = ((TextBox)sender).Text.ToString();
        }

        private void PriceOfItemTextBox_TextChanged(object sender, EventArgs e)
        {
            productInformation[2] = ((TextBox)sender).Text.ToString();
        }

        private void CategoriTextBox_TextChanged(object sender, EventArgs e)
        {
            productInformation[3] = ((TextBox)sender).Text.ToString();
        }

        private void IdTbx_TextChanged(object sender, EventArgs e)
        {
            productInformation[4] = ((TextBox)sender).Text.ToString();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            stock.AddProduct(new Product(
            Name: productInformation[0],
            Price: productInformation[2],
            Category: productInformation[3],
            Quantity: productInformation[1]));
            Display();
            nameOfItemTextBox.Text = string.Empty;
            howManyItemsTextBox.Text = string.Empty;
            priceOfItemTextBox.Text = string.Empty;
            categoriTextBox.Text = string.Empty;


        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            stock.RemoveProduct(productInformation[4]);
            textBox2.Text = string.Empty;
            Display();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {

            stock.AddToExistedProduct(productInformation[4], productInformation[1]);
            Display();
            IdTbx.Text = string.Empty;
            antalTxb.Text = string.Empty;
        }

        private void Views_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayStock();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            WareHouseGridView.Visible = true;
            Display();
        }

        private void HideBtn_Click(object sender, EventArgs e)
        {
            WareHouseGridView.Visible = false;
        }

        private void RegBuyBtn_Click(object sender, EventArgs e)
        {
            stock.RemoveProduct(products);
            ShoppingCartDataGridView.Rows.Clear();
            DisplayStock();
        }

        private void ClearBuyBtn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in ShoppingCartDataGridView.Rows)
            {
                foreach(DataGridViewRow r in StoreDataGridView.Rows)
                {
                   if(r.Cells[0].Value.ToString().Contains(row.Cells[0].Value.ToString()))
                   {
                        int quant = int.Parse(row.Cells[3].Value.ToString());
                        int quant2 = int.Parse(r.Cells[3].Value.ToString());
                        int temp = quant + quant2;
                        r.Cells[3].Value = temp.ToString();
                   }
                }
            }

            ShoppingCartDataGridView.Rows.Clear();
        }

        
    }
}
