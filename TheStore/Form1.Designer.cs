namespace TheStore
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Views = new System.Windows.Forms.TabControl();
            this.StoreView = new System.Windows.Forms.TabPage();
            this.clearBuyBtn = new System.Windows.Forms.Button();
            this.RegBuyBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RegistrateBtn = new System.Windows.Forms.Button();
            this.ShoppingCartDataGridView = new System.Windows.Forms.DataGridView();
            this.StoreDataGridView = new System.Windows.Forms.DataGridView();
            this.WarehouseView = new System.Windows.Forms.TabPage();
            this.WareHouseGridView = new System.Windows.Forms.DataGridView();
            this.hideBtn = new System.Windows.Forms.Button();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoriTextBox = new System.Windows.Forms.TextBox();
            this.priceOfItemTextBox = new System.Windows.Forms.TextBox();
            this.howManyItemsTextBox = new System.Windows.Forms.TextBox();
            this.nameOfItemTextBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.Views.SuspendLayout();
            this.StoreView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingCartDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreDataGridView)).BeginInit();
            this.WarehouseView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WareHouseGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Views
            // 
            this.Views.Controls.Add(this.StoreView);
            this.Views.Controls.Add(this.WarehouseView);
            this.Views.Location = new System.Drawing.Point(2, 2);
            this.Views.Name = "Views";
            this.Views.SelectedIndex = 0;
            this.Views.Size = new System.Drawing.Size(1183, 622);
            this.Views.TabIndex = 3;
            this.Views.SelectedIndexChanged += new System.EventHandler(this.Views_SelectedIndexChanged);
            // 
            // StoreView
            // 
            this.StoreView.Controls.Add(this.clearBuyBtn);
            this.StoreView.Controls.Add(this.RegBuyBtn);
            this.StoreView.Controls.Add(this.label6);
            this.StoreView.Controls.Add(this.label5);
            this.StoreView.Controls.Add(this.RegistrateBtn);
            this.StoreView.Controls.Add(this.ShoppingCartDataGridView);
            this.StoreView.Controls.Add(this.StoreDataGridView);
            this.StoreView.Location = new System.Drawing.Point(4, 22);
            this.StoreView.Name = "StoreView";
            this.StoreView.Padding = new System.Windows.Forms.Padding(3);
            this.StoreView.Size = new System.Drawing.Size(1175, 596);
            this.StoreView.TabIndex = 0;
            this.StoreView.Text = "Store View";
            this.StoreView.UseVisualStyleBackColor = true;
            // 
            // clearBuyBtn
            // 
            this.clearBuyBtn.Location = new System.Drawing.Point(118, 180);
            this.clearBuyBtn.Name = "clearBuyBtn";
            this.clearBuyBtn.Size = new System.Drawing.Size(103, 23);
            this.clearBuyBtn.TabIndex = 6;
            this.clearBuyBtn.Text = "Avbryt köp";
            this.clearBuyBtn.UseVisualStyleBackColor = true;
            this.clearBuyBtn.Click += new System.EventHandler(this.ClearBuyBtn_Click);
            // 
            // RegBuyBtn
            // 
            this.RegBuyBtn.Location = new System.Drawing.Point(118, 150);
            this.RegBuyBtn.Name = "RegBuyBtn";
            this.RegBuyBtn.Size = new System.Drawing.Size(103, 23);
            this.RegBuyBtn.TabIndex = 5;
            this.RegBuyBtn.Text = "Registrera köp";
            this.RegBuyBtn.UseVisualStyleBackColor = true;
            this.RegBuyBtn.Click += new System.EventHandler(this.RegBuyBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(700, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Varukorg";
            // 
            // RegistrateBtn
            // 
            this.RegistrateBtn.Location = new System.Drawing.Point(118, 120);
            this.RegistrateBtn.Name = "RegistrateBtn";
            this.RegistrateBtn.Size = new System.Drawing.Size(103, 23);
            this.RegistrateBtn.TabIndex = 2;
            this.RegistrateBtn.Text = "Lägg till vara";
            this.RegistrateBtn.UseVisualStyleBackColor = true;
            this.RegistrateBtn.Click += new System.EventHandler(this.Registrerabutton_Click_1);
            // 
            // ShoppingCartDataGridView
            // 
            this.ShoppingCartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShoppingCartDataGridView.Location = new System.Drawing.Point(6, 266);
            this.ShoppingCartDataGridView.Name = "ShoppingCartDataGridView";
            this.ShoppingCartDataGridView.Size = new System.Drawing.Size(443, 324);
            this.ShoppingCartDataGridView.TabIndex = 1;
            // 
            // StoreDataGridView
            // 
            this.StoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoreDataGridView.Location = new System.Drawing.Point(625, 266);
            this.StoreDataGridView.Name = "StoreDataGridView";
            this.StoreDataGridView.Size = new System.Drawing.Size(544, 324);
            this.StoreDataGridView.TabIndex = 0;
            // 
            // WarehouseView
            // 
            this.WarehouseView.Controls.Add(this.WareHouseGridView);
            this.WarehouseView.Controls.Add(this.hideBtn);
            this.WarehouseView.Controls.Add(this.ShowBtn);
            this.WarehouseView.Controls.Add(this.orderBtn);
            this.WarehouseView.Controls.Add(this.removeBtn);
            this.WarehouseView.Controls.Add(this.groupBox1);
            this.WarehouseView.Controls.Add(this.AddBtn);
            this.WarehouseView.Location = new System.Drawing.Point(4, 22);
            this.WarehouseView.Name = "WarehouseView";
            this.WarehouseView.Padding = new System.Windows.Forms.Padding(3);
            this.WarehouseView.Size = new System.Drawing.Size(1175, 596);
            this.WarehouseView.TabIndex = 1;
            this.WarehouseView.Text = "Warehouse View";
            this.WarehouseView.UseVisualStyleBackColor = true;
            // 
            // WareHouseGridView
            // 
            this.WareHouseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WareHouseGridView.Location = new System.Drawing.Point(622, 275);
            this.WareHouseGridView.Name = "WareHouseGridView";
            this.WareHouseGridView.Size = new System.Drawing.Size(544, 315);
            this.WareHouseGridView.TabIndex = 5;
            // 
            // hideBtn
            // 
            this.hideBtn.Location = new System.Drawing.Point(109, 567);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Size = new System.Drawing.Size(104, 23);
            this.hideBtn.TabIndex = 4;
            this.hideBtn.Text = "Dölj lager";
            this.hideBtn.UseVisualStyleBackColor = true;
            this.hideBtn.Click += new System.EventHandler(this.HideBtn_Click);
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(6, 567);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(97, 23);
            this.ShowBtn.TabIndex = 3;
            this.ShowBtn.Text = "Visa lager";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(6, 161);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(75, 23);
            this.orderBtn.TabIndex = 2;
            this.orderBtn.Text = "Beställ";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(6, 131);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "Ta bort";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.categoriTextBox);
            this.groupBox1.Controls.Add(this.priceOfItemTextBox);
            this.groupBox1.Controls.Add(this.howManyItemsTextBox);
            this.groupBox1.Controls.Add(this.nameOfItemTextBox);
            this.groupBox1.Location = new System.Drawing.Point(4, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1162, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lägg till/Beställ vara";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(956, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(658, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pris";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Antal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Namn";
            // 
            // categoriTextBox
            // 
            this.categoriTextBox.Location = new System.Drawing.Point(1019, 31);
            this.categoriTextBox.Name = "categoriTextBox";
            this.categoriTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoriTextBox.TabIndex = 4;
            this.categoriTextBox.Click += new System.EventHandler(this.AddBtn_Click);
            this.categoriTextBox.TextChanged += new System.EventHandler(this.CategoriTextBox_TextChanged);
            // 
            // priceOfItemTextBox
            // 
            this.priceOfItemTextBox.Location = new System.Drawing.Point(708, 31);
            this.priceOfItemTextBox.Name = "priceOfItemTextBox";
            this.priceOfItemTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceOfItemTextBox.TabIndex = 3;
            this.priceOfItemTextBox.Click += new System.EventHandler(this.AddBtn_Click);
            this.priceOfItemTextBox.TextChanged += new System.EventHandler(this.PriceOfItemTextBox_TextChanged);
            // 
            // howManyItemsTextBox
            // 
            this.howManyItemsTextBox.Location = new System.Drawing.Point(455, 31);
            this.howManyItemsTextBox.Name = "howManyItemsTextBox";
            this.howManyItemsTextBox.Size = new System.Drawing.Size(100, 20);
            this.howManyItemsTextBox.TabIndex = 2;
            this.howManyItemsTextBox.Click += new System.EventHandler(this.AddBtn_Click);
            this.howManyItemsTextBox.TextChanged += new System.EventHandler(this.HowManyItemsTextBox_TextChanged);
            // 
            // nameOfItemTextBox
            // 
            this.nameOfItemTextBox.Location = new System.Drawing.Point(136, 33);
            this.nameOfItemTextBox.Name = "nameOfItemTextBox";
            this.nameOfItemTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameOfItemTextBox.TabIndex = 1;
            this.nameOfItemTextBox.TextChanged += new System.EventHandler(this.NameOfItemTextBox_TextChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(6, 101);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Lägg till";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 631);
            this.Controls.Add(this.Views);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Views.ResumeLayout(false);
            this.StoreView.ResumeLayout(false);
            this.StoreView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingCartDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreDataGridView)).EndInit();
            this.WarehouseView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WareHouseGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl Views;
        private System.Windows.Forms.TabPage StoreView;
        private System.Windows.Forms.TabPage WarehouseView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox categoriTextBox;
        private System.Windows.Forms.TextBox priceOfItemTextBox;
        private System.Windows.Forms.TextBox howManyItemsTextBox;
        private System.Windows.Forms.TextBox nameOfItemTextBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button hideBtn;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.DataGridView WareHouseGridView;
        private System.Windows.Forms.DataGridView StoreDataGridView;
        private System.Windows.Forms.DataGridView ShoppingCartDataGridView;
        private System.Windows.Forms.Button RegistrateBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clearBuyBtn;
        private System.Windows.Forms.Button RegBuyBtn;
    }
}

