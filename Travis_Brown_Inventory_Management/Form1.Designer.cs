﻿namespace Travis_Brown_Inventory_Management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            btnSearchPart = new Button();
            btnSearchProduct = new Button();
            dgvParts = new DataGridView();
            Part_ID = new DataGridViewTextBoxColumn();
            Part_Name = new DataGridViewTextBoxColumn();
            Part_Inventory = new DataGridViewTextBoxColumn();
            Part_Price = new DataGridViewTextBoxColumn();
            dgvProducts = new DataGridView();
            Product_ID = new DataGridViewTextBoxColumn();
            Product_Name = new DataGridViewTextBoxColumn();
            Product_Inventory = new DataGridViewTextBoxColumn();
            Product_Price = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnAddPart = new Button();
            btnDeletePart = new Button();
            btnModifyPart = new Button();
            btnAddProduct = new Button();
            btnModifyProduct = new Button();
            btnDeleteProduct = new Button();
            btnExitMainScreen = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(366, 29);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management System";
            // 
            // btnSearchPart
            // 
            btnSearchPart.Location = new Point(151, 143);
            btnSearchPart.Name = "btnSearchPart";
            btnSearchPart.Size = new Size(75, 23);
            btnSearchPart.TabIndex = 1;
            btnSearchPart.Text = "Search";
            btnSearchPart.UseVisualStyleBackColor = true;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.Location = new Point(785, 143);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(75, 23);
            btnSearchProduct.TabIndex = 2;
            btnSearchProduct.Text = "Search";
            btnSearchProduct.UseVisualStyleBackColor = true;
            // 
            // dgvParts
            // 
            dgvParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParts.Columns.AddRange(new DataGridViewColumn[] { Part_ID, Part_Name, Part_Inventory, Part_Price });
            dgvParts.Location = new Point(12, 186);
            dgvParts.MultiSelect = false;
            dgvParts.Name = "dgvParts";
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParts.Size = new Size(443, 150);
            dgvParts.TabIndex = 3;
            // 
            // Part_ID
            // 
            Part_ID.HeaderText = "Part ID";
            Part_ID.Name = "Part_ID";
            // 
            // Part_Name
            // 
            Part_Name.HeaderText = "Part Name";
            Part_Name.Name = "Part_Name";
            // 
            // Part_Inventory
            // 
            Part_Inventory.HeaderText = "Inventory";
            Part_Inventory.Name = "Part_Inventory";
            // 
            // Part_Price
            // 
            Part_Price.HeaderText = "Price";
            Part_Price.Name = "Part_Price";
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { Product_ID, Product_Name, Product_Inventory, Product_Price });
            dgvProducts.Location = new Point(644, 186);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(444, 150);
            dgvProducts.TabIndex = 4;
            // 
            // Product_ID
            // 
            Product_ID.HeaderText = "Product ID";
            Product_ID.Name = "Product_ID";
            // 
            // Product_Name
            // 
            Product_Name.HeaderText = "Product Name";
            Product_Name.Name = "Product_Name";
            // 
            // Product_Inventory
            // 
            Product_Inventory.HeaderText = "Inventory";
            Product_Inventory.Name = "Product_Inventory";
            // 
            // Product_Price
            // 
            Product_Price.HeaderText = "Price";
            Product_Price.Name = "Product_Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(12, 146);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 5;
            label2.Text = "Parts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(644, 146);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 6;
            label3.Text = "Products";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 150);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(251, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(884, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 23);
            textBox2.TabIndex = 9;
            // 
            // btnAddPart
            // 
            btnAddPart.Location = new Point(218, 357);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(75, 23);
            btnAddPart.TabIndex = 10;
            btnAddPart.Text = "Add";
            btnAddPart.UseVisualStyleBackColor = true;
            // 
            // btnDeletePart
            // 
            btnDeletePart.Location = new Point(380, 357);
            btnDeletePart.Name = "btnDeletePart";
            btnDeletePart.Size = new Size(75, 23);
            btnDeletePart.TabIndex = 11;
            btnDeletePart.Text = "Delete";
            btnDeletePart.UseVisualStyleBackColor = true;
            // 
            // btnModifyPart
            // 
            btnModifyPart.Location = new Point(299, 357);
            btnModifyPart.Name = "btnModifyPart";
            btnModifyPart.Size = new Size(75, 23);
            btnModifyPart.TabIndex = 12;
            btnModifyPart.Text = "Modify";
            btnModifyPart.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(851, 357);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(75, 23);
            btnAddProduct.TabIndex = 13;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnModifyProduct
            // 
            btnModifyProduct.Location = new Point(932, 357);
            btnModifyProduct.Name = "btnModifyProduct";
            btnModifyProduct.Size = new Size(75, 23);
            btnModifyProduct.TabIndex = 14;
            btnModifyProduct.Text = "Modify";
            btnModifyProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(1013, 357);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(75, 23);
            btnDeleteProduct.TabIndex = 15;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnExitMainScreen
            // 
            btnExitMainScreen.Location = new Point(1013, 515);
            btnExitMainScreen.Name = "btnExitMainScreen";
            btnExitMainScreen.Size = new Size(75, 23);
            btnExitMainScreen.TabIndex = 16;
            btnExitMainScreen.Text = "Exit";
            btnExitMainScreen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 550);
            Controls.Add(btnExitMainScreen);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnModifyProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(btnModifyPart);
            Controls.Add(btnDeletePart);
            Controls.Add(btnAddPart);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvProducts);
            Controls.Add(dgvParts);
            Controls.Add(btnSearchProduct);
            Controls.Add(btnSearchPart);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)dgvParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSearchPart;
        private Button btnSearchProduct;
        private DataGridView dgvParts;
        private DataGridView dgvProducts;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnAddPart;
        private Button btnDeletePart;
        private Button btnModifyPart;
        private Button btnAddProduct;
        private Button btnModifyProduct;
        private Button btnDeleteProduct;
        private Button btnExitMainScreen;
        private DataGridViewTextBoxColumn Product_ID;
        private DataGridViewTextBoxColumn Product_Name;
        private DataGridViewTextBoxColumn Product_Inventory;
        private DataGridViewTextBoxColumn Product_Price;
        private DataGridViewTextBoxColumn Part_ID;
        private DataGridViewTextBoxColumn Part_Name;
        private DataGridViewTextBoxColumn Part_Inventory;
        private DataGridViewTextBoxColumn Part_Price;
    }
}
