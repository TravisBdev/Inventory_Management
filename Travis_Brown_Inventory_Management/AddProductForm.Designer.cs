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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            btnSearchAddProduct = new Button();
            tbAddProdSearch = new TextBox();
            label2 = new Label();
            dgvAddProdPartsList = new DataGridView();
            Part_ID = new DataGridViewTextBoxColumn();
            Part_Name = new DataGridViewTextBoxColumn();
            Part_Inventory = new DataGridViewTextBoxColumn();
            Part_Price = new DataGridViewTextBoxColumn();
            btnAddPart = new Button();
            dgvAddProdAssociatedList = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            btnDeletePart = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tbAddProdID = new TextBox();
            tbAddProdName = new TextBox();
            tbAddProdInventory = new TextBox();
            tbAddProdPrice = new TextBox();
            tbAddProdMax = new TextBox();
            tbAddProdMin = new TextBox();
            btnAddProdSave = new Button();
            btnAddProdCancel = new Button();
            label9 = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvAddProdPartsList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAddProdAssociatedList).BeginInit();
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
            btnSearchAddProduct.Click += btnSearchAddProduct_Click;
            // 
            // tbAddProdSearch
            // 
            tbAddProdSearch.Location = new Point(535, 12);
            tbAddProdSearch.Name = "tbAddProdSearch";
            tbAddProdSearch.Size = new Size(196, 23);
            tbAddProdSearch.TabIndex = 2;
            tbAddProdSearch.TextChanged += tbAddProdSearch_TextChanged;
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
            Part_ID.DataPropertyName = "PartID";
            Part_ID.HeaderText = "Part ID";
            Part_ID.Name = "Part_ID";
            // 
            // Part_Name
            // 
            Part_Name.DataPropertyName = "Name";
            Part_Name.HeaderText = "Part Name";
            Part_Name.Name = "Part_Name";
            // 
            // Part_Inventory
            // 
            Part_Inventory.DataPropertyName = "InStock";
            Part_Inventory.HeaderText = "Inventory";
            Part_Inventory.Name = "Part_Inventory";
            // 
            // Part_Price
            // 
            Part_Price.DataPropertyName = "Price";
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
            btnAddPart.Click += btnAddPart_Click;
            // 
            // dgvAddProdAssociatedList
            // 
            dgvAddProdAssociatedList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddProdAssociatedList.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvAddProdAssociatedList.Location = new Point(322, 324);
            dgvAddProdAssociatedList.MultiSelect = false;
            dgvAddProdAssociatedList.Name = "dgvAddProdAssociatedList";
            dgvAddProdAssociatedList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAddProdAssociatedList.Size = new Size(443, 150);
            dgvAddProdAssociatedList.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "PartID";
            dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewTextBoxColumn2.HeaderText = "Part Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "InStock";
            dataGridViewTextBoxColumn3.HeaderText = "Inventory";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            dataGridViewTextBoxColumn4.HeaderText = "Price";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnDeletePart
            // 
            btnDeletePart.Location = new Point(709, 480);
            btnDeletePart.Name = "btnDeletePart";
            btnDeletePart.Size = new Size(56, 32);
            btnDeletePart.TabIndex = 7;
            btnDeletePart.Text = "Delete";
            btnDeletePart.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 252);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 8;
            label3.Text = "Inventory";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 210);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 9;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 167);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 10;
            label5.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(169, 334);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 11;
            label6.Text = "Min";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 334);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 12;
            label7.Text = "Max";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 292);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 13;
            label8.Text = "Price";
            // 
            // tbAddProdID
            // 
            tbAddProdID.Enabled = false;
            tbAddProdID.Location = new Point(80, 159);
            tbAddProdID.Name = "tbAddProdID";
            tbAddProdID.Size = new Size(196, 23);
            tbAddProdID.TabIndex = 14;
            // 
            // tbAddProdName
            // 
            tbAddProdName.Location = new Point(80, 207);
            tbAddProdName.Name = "tbAddProdName";
            tbAddProdName.Size = new Size(196, 23);
            tbAddProdName.TabIndex = 15;
            tbAddProdName.TextChanged += tbAddProdName_TextChanged;
            // 
            // tbAddProdInventory
            // 
            tbAddProdInventory.Location = new Point(80, 249);
            tbAddProdInventory.Name = "tbAddProdInventory";
            tbAddProdInventory.Size = new Size(196, 23);
            tbAddProdInventory.TabIndex = 16;
            tbAddProdInventory.TextChanged += tbAddProdInventory_TextChanged;
            // 
            // tbAddProdPrice
            // 
            tbAddProdPrice.Location = new Point(80, 289);
            tbAddProdPrice.Name = "tbAddProdPrice";
            tbAddProdPrice.Size = new Size(196, 23);
            tbAddProdPrice.TabIndex = 17;
            tbAddProdPrice.TextChanged += tbAddProdPrice_TextChanged;
            // 
            // tbAddProdMax
            // 
            tbAddProdMax.Location = new Point(48, 331);
            tbAddProdMax.Name = "tbAddProdMax";
            tbAddProdMax.Size = new Size(63, 23);
            tbAddProdMax.TabIndex = 18;
            tbAddProdMax.TextChanged += tbAddProdMax_TextChanged;
            // 
            // tbAddProdMin
            // 
            tbAddProdMin.Location = new Point(213, 331);
            tbAddProdMin.Name = "tbAddProdMin";
            tbAddProdMin.Size = new Size(63, 23);
            tbAddProdMin.TabIndex = 19;
            tbAddProdMin.TextChanged += tbAddProdMin_TextChanged;
            // 
            // btnAddProdSave
            // 
            btnAddProdSave.Location = new Point(685, 555);
            btnAddProdSave.Name = "btnAddProdSave";
            btnAddProdSave.Size = new Size(56, 32);
            btnAddProdSave.TabIndex = 20;
            btnAddProdSave.Text = "Save";
            btnAddProdSave.UseVisualStyleBackColor = true;
            btnAddProdSave.Click += btnAddProdSave_Click;
            // 
            // btnAddProdCancel
            // 
            btnAddProdCancel.Location = new Point(747, 555);
            btnAddProdCancel.Name = "btnAddProdCancel";
            btnAddProdCancel.Size = new Size(56, 32);
            btnAddProdCancel.TabIndex = 21;
            btnAddProdCancel.Text = "Cancel";
            btnAddProdCancel.UseVisualStyleBackColor = true;
            btnAddProdCancel.Click += btnAddProdCancel_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(322, 297);
            label9.Name = "label9";
            label9.Size = new Size(186, 15);
            label9.TabIndex = 22;
            label9.Text = "Parts Associated with this Product";
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 599);
            Controls.Add(label9);
            Controls.Add(btnAddProdCancel);
            Controls.Add(btnAddProdSave);
            Controls.Add(tbAddProdMin);
            Controls.Add(tbAddProdMax);
            Controls.Add(tbAddProdPrice);
            Controls.Add(tbAddProdInventory);
            Controls.Add(tbAddProdName);
            Controls.Add(tbAddProdID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnDeletePart);
            Controls.Add(dgvAddProdAssociatedList);
            Controls.Add(btnAddPart);
            Controls.Add(dgvAddProdPartsList);
            Controls.Add(label2);
            Controls.Add(tbAddProdSearch);
            Controls.Add(btnSearchAddProduct);
            Controls.Add(label1);
            Name = "AddProductForm";
            Text = "AddProductForm";
            Load += AddProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAddProdPartsList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAddProdAssociatedList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSearchAddProduct;
        private TextBox tbAddProdSearch;
        private Label label2;
        private DataGridView dgvAddProdPartsList;
        private Button btnAddPart;
        private DataGridView dgvAddProdAssociatedList;
        private Button btnDeletePart;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tbAddProdID;
        private TextBox tbAddProdName;
        private TextBox tbAddProdInventory;
        private TextBox tbAddProdPrice;
        private TextBox tbAddProdMax;
        private TextBox tbAddProdMin;
        private Button btnAddProdSave;
        private Button btnAddProdCancel;
        private Label label9;
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn Part_ID;
        private DataGridViewTextBoxColumn Part_Name;
        private DataGridViewTextBoxColumn Part_Inventory;
        private DataGridViewTextBoxColumn Part_Price;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}