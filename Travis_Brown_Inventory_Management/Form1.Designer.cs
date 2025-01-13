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
            dataGridView2 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            Product_ID = new DataGridViewTextBoxColumn();
            Product_Name = new DataGridViewTextBoxColumn();
            Product_Inventory = new DataGridViewTextBoxColumn();
            Product_Price = new DataGridViewTextBoxColumn();
            Part_ID = new DataGridViewTextBoxColumn();
            Part_Name = new DataGridViewTextBoxColumn();
            Part_Inventory = new DataGridViewTextBoxColumn();
            Part_Price = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            button2.Location = new Point(785, 143);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Part_ID, Part_Name, Part_Inventory, Part_Price });
            dataGridView1.Location = new Point(12, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 150);
            dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Product_ID, Product_Name, Product_Inventory, Product_Price });
            dataGridView2.Location = new Point(644, 186);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(444, 150);
            dataGridView2.TabIndex = 4;
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
            // button3
            // 
            button3.Location = new Point(218, 357);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(380, 357);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(299, 357);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "Modify";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(851, 357);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 13;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(932, 357);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 14;
            button7.Text = "Modify";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(1013, 357);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 15;
            button8.Text = "Delete";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(1013, 515);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 16;
            button9.Text = "Exit";
            button9.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 550);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
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
        private DataGridView dataGridView2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
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
