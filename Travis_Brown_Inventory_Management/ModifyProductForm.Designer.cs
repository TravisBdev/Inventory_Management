namespace Travis_Brown_Inventory_Management {
    partial class ModifyProductForm {
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
            btnSearchModProd = new Button();
            tbSearchModProd = new TextBox();
            dgvModProdAssociatedList = new DataGridView();
            label2 = new Label();
            Part_ID = new DataGridViewTextBoxColumn();
            Part_Name = new DataGridViewTextBoxColumn();
            Part_Inventory = new DataGridViewTextBoxColumn();
            Part_Price = new DataGridViewTextBoxColumn();
            btnDeletePart = new Button();
            btnAddPart = new Button();
            btnCancelModifyProd = new Button();
            btnSaveModifyProd = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvModProdAssociatedList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Modify Product";
            // 
            // btnSearchModProd
            // 
            btnSearchModProd.Location = new Point(436, 12);
            btnSearchModProd.Name = "btnSearchModProd";
            btnSearchModProd.Size = new Size(75, 23);
            btnSearchModProd.TabIndex = 1;
            btnSearchModProd.Text = "Search";
            btnSearchModProd.UseVisualStyleBackColor = true;
            // 
            // tbSearchModProd
            // 
            tbSearchModProd.Location = new Point(533, 12);
            tbSearchModProd.Name = "tbSearchModProd";
            tbSearchModProd.Size = new Size(214, 23);
            tbSearchModProd.TabIndex = 2;
            // 
            // dgvModProdAssociatedList
            // 
            dgvModProdAssociatedList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModProdAssociatedList.Columns.AddRange(new DataGridViewColumn[] { Part_ID, Part_Name, Part_Inventory, Part_Price });
            dgvModProdAssociatedList.Location = new Point(323, 88);
            dgvModProdAssociatedList.Name = "dgvModProdAssociatedList";
            dgvModProdAssociatedList.Size = new Size(444, 150);
            dgvModProdAssociatedList.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 60);
            label2.Name = "label2";
            label2.Size = new Size(186, 15);
            label2.TabIndex = 4;
            label2.Text = "Parts Associated with this Product";
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
            // btnDeletePart
            // 
            btnDeletePart.Location = new Point(713, 244);
            btnDeletePart.Name = "btnDeletePart";
            btnDeletePart.Size = new Size(55, 35);
            btnDeletePart.TabIndex = 5;
            btnDeletePart.Text = "Delete";
            btnDeletePart.UseVisualStyleBackColor = true;
            // 
            // btnAddPart
            // 
            btnAddPart.Location = new Point(649, 244);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(58, 35);
            btnAddPart.TabIndex = 6;
            btnAddPart.Text = "Add";
            btnAddPart.UseVisualStyleBackColor = true;
            // 
            // btnCancelModifyProd
            // 
            btnCancelModifyProd.Location = new Point(761, 403);
            btnCancelModifyProd.Name = "btnCancelModifyProd";
            btnCancelModifyProd.Size = new Size(58, 35);
            btnCancelModifyProd.TabIndex = 7;
            btnCancelModifyProd.Text = "Cancel";
            btnCancelModifyProd.UseVisualStyleBackColor = true;
            // 
            // btnSaveModifyProd
            // 
            btnSaveModifyProd.Location = new Point(697, 403);
            btnSaveModifyProd.Name = "btnSaveModifyProd";
            btnSaveModifyProd.Size = new Size(58, 35);
            btnSaveModifyProd.TabIndex = 8;
            btnSaveModifyProd.Text = "Save";
            btnSaveModifyProd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 142);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 9;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 183);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 10;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 223);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 11;
            label5.Text = "Inventory";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 264);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 12;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(206, 300);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 13;
            label7.Text = "Min";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 300);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 14;
            label8.Text = "Max";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(108, 220);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 23);
            textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(108, 261);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(154, 23);
            textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(48, 297);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(78, 23);
            textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(240, 297);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(78, 23);
            textBox6.TabIndex = 20;
            // 
            // ModifyProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 450);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSaveModifyProd);
            Controls.Add(btnCancelModifyProd);
            Controls.Add(btnAddPart);
            Controls.Add(btnDeletePart);
            Controls.Add(label2);
            Controls.Add(dgvModProdAssociatedList);
            Controls.Add(tbSearchModProd);
            Controls.Add(btnSearchModProd);
            Controls.Add(label1);
            Name = "ModifyProductForm";
            Text = "ModifyProductForm";
            ((System.ComponentModel.ISupportInitialize)dgvModProdAssociatedList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSearchModProd;
        private TextBox tbSearchModProd;
        private DataGridView dgvModProdAssociatedList;
        private Label label2;
        private DataGridViewTextBoxColumn Part_ID;
        private DataGridViewTextBoxColumn Part_Name;
        private DataGridViewTextBoxColumn Part_Inventory;
        private DataGridViewTextBoxColumn Part_Price;
        private Button btnDeletePart;
        private Button btnAddPart;
        private Button btnCancelModifyProd;
        private Button btnSaveModifyProd;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}