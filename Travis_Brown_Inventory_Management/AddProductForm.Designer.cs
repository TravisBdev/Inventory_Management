namespace Travis_Brown_Inventory_Management {
    partial class AddProductForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            btnSearchAddProduct = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            dgvAddProdPartsList = new DataGridView();
            Part_ID = new DataGridViewTextBoxColumn();
            Part_Name = new DataGridViewTextBoxColumn();
            Part_Inventory = new DataGridViewTextBoxColumn();
            Part_Price = new DataGridViewTextBoxColumn();
            btnAddPart = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAddProdPartsList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // btnSearchAddProduct
            // 
            btnSearchAddProduct.Location = new Point(433, 12);
            btnSearchAddProduct.Name = "btnSearchAddProduct";
            btnSearchAddProduct.Size = new Size(75, 23);
            btnSearchAddProduct.TabIndex = 1;
            btnSearchAddProduct.Text = "Search";
            btnSearchAddProduct.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(535, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 56);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "All Parts";
            // 
            // dgvAddProdPartsList
            // 
            dgvAddProdPartsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddProdPartsList.Columns.AddRange(new DataGridViewColumn[] { Part_ID, Part_Name, Part_Inventory, Part_Price });
            dgvAddProdPartsList.Location = new Point(322, 87);
            dgvAddProdPartsList.MultiSelect = false;
            dgvAddProdPartsList.Name = "dgvAddProdPartsList";
            dgvAddProdPartsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAddProdPartsList.Size = new Size(443, 150);
            dgvAddProdPartsList.TabIndex = 4;
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
            // btnAddPart
            // 
            btnAddPart.Location = new Point(709, 243);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(56, 32);
            btnAddPart.TabIndex = 5;
            btnAddPart.Text = "Add";
            btnAddPart.UseVisualStyleBackColor = true;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 599);
            Controls.Add(btnAddPart);
            Controls.Add(dgvAddProdPartsList);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(btnSearchAddProduct);
            Controls.Add(label1);
            Name = "AddProductForm";
            Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)dgvAddProdPartsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSearchAddProduct;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dgvAddProdPartsList;
        private DataGridViewTextBoxColumn Part_ID;
        private DataGridViewTextBoxColumn Part_Name;
        private DataGridViewTextBoxColumn Part_Inventory;
        private DataGridViewTextBoxColumn Part_Price;
        private Button btnAddPart;
    }
}