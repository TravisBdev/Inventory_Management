namespace Travis_Brown_Inventory_Management
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
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            PartID = new DataGridViewTextBoxColumn();
            PartName = new DataGridViewTextBoxColumn();
            PartInventory = new DataGridViewTextBoxColumn();
            PartPrice = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductInventory = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(366, 29);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management System";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(151, 143);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(784, 146);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PartID, PartName, PartInventory, PartPrice });
            dataGridView1.Location = new Point(12, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 150);
            dataGridView1.TabIndex = 3;
            // 
            // PartID
            // 
            PartID.HeaderText = "Part ID";
            PartID.Name = "PartID";
            // 
            // PartName
            // 
            PartName.HeaderText = "Part Name";
            PartName.Name = "PartName";
            // 
            // PartInventory
            // 
            PartInventory.HeaderText = "Inventory";
            PartInventory.Name = "PartInventory";
            // 
            // PartPrice
            // 
            PartPrice.HeaderText = "Price";
            PartPrice.Name = "PartPrice";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, ProductInventory, ProductPrice });
            dataGridView2.Location = new Point(644, 186);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(444, 150);
            dataGridView2.TabIndex = 4;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "Product ID";
            ProductID.Name = "ProductID";
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product Name";
            ProductName.Name = "ProductName";
            // 
            // ProductInventory
            // 
            ProductInventory.HeaderText = "Inventory";
            ProductInventory.Name = "ProductInventory";
            // 
            // ProductPrice
            // 
            ProductPrice.HeaderText = "Price";
            ProductPrice.Name = "ProductPrice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(12, 146);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 5;
            label2.Text = "Parts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(644, 146);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 6;
            label3.Text = "Products";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 550);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn PartName;
        private DataGridViewTextBoxColumn PartInventory;
        private DataGridViewTextBoxColumn PartPrice;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductInventory;
        private DataGridViewTextBoxColumn ProductPrice;
        private Label label2;
        private Label label3;
    }
}
