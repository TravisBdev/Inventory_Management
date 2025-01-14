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
            btnDeletePart.Location = new Point(712, 244);
            btnDeletePart.Name = "btnDeletePart";
            btnDeletePart.Size = new Size(55, 35);
            btnDeletePart.TabIndex = 5;
            btnDeletePart.Text = "Delete";
            btnDeletePart.UseVisualStyleBackColor = true;
            // 
            // btnAddPart
            // 
            btnAddPart.Location = new Point(648, 244);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(58, 35);
            btnAddPart.TabIndex = 6;
            btnAddPart.Text = "Add";
            btnAddPart.UseVisualStyleBackColor = true;
            // 
            // btnCancelModifyProd
            // 
            btnCancelModifyProd.Location = new Point(760, 403);
            btnCancelModifyProd.Name = "btnCancelModifyProd";
            btnCancelModifyProd.Size = new Size(58, 35);
            btnCancelModifyProd.TabIndex = 7;
            btnCancelModifyProd.Text = "Cancel";
            btnCancelModifyProd.UseVisualStyleBackColor = true;
            // 
            // btnSaveModifyProd
            // 
            btnSaveModifyProd.Location = new Point(696, 403);
            btnSaveModifyProd.Name = "btnSaveModifyProd";
            btnSaveModifyProd.Size = new Size(58, 35);
            btnSaveModifyProd.TabIndex = 8;
            btnSaveModifyProd.Text = "Save";
            btnSaveModifyProd.UseVisualStyleBackColor = true;
            // 
            // ModifyProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 450);
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
    }
}