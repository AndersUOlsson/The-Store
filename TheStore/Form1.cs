using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TheStore
{
    public partial class Form1 : Form
    {
        Stock stock = new Stock();
        List<Product> products;
        List<Order> orders;
        string[] productInformation = new string[4];

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


        }

        private void Registrerabutton_Click_1(object sender, EventArgs e)
        {

            foreach(DataGridViewRow row in StoreDataGridView.Rows)
            {
                if(row.Selected)
                {
                    StoreDataGridView.SelectedCells[row.Index].RowIndex.ToString();

                    //TODO: Detta är var jag skall fortsätta i morgon. 
                }

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int.TryParse(ActiveControl.Text, out int x);
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

        private void AddBtn_Click(object sender, EventArgs e) => stock.AddProduct(new Product(
                Name: productInformation[0],
                Price: productInformation[2],
                Category: productInformation[3],
                Quantity: productInformation[1]));

        private void removeBtn_Click(object sender, EventArgs e)
        {
            stock.RemoveProduct(productInformation[0]);
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product(productInformation[0], productInformation[2], productInformation[3], productInformation[1]);
            stock.AddAlreadyExistingProduct(product, false);
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

        private void hideBtn_Click(object sender, EventArgs e)
        {
            WareHouseGridView.Visible = false;
        }

       
    }
}
