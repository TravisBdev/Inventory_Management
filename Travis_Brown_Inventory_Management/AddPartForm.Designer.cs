namespace Travis_Brown_Inventory_Management {
    partial class AddPartForm {
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
            rbInHouse = new RadioButton();
            rbOutSourced = new RadioButton();
            lblPartInOrOut = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnSavePart = new Button();
            btnCancelPart = new Button();
            tbPartInOrOut = new TextBox();
            tbPartMax = new TextBox();
            tbPartID = new TextBox();
            tbPartInventory = new TextBox();
            tbPartName = new TextBox();
            tbPartPrice = new TextBox();
            tbPartMin = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Add Part";
            // 
            // rbInHouse
            // 
            rbInHouse.AutoSize = true;
            rbInHouse.Location = new Point(116, 9);
            rbInHouse.Name = "rbInHouse";
            rbInHouse.Size = new Size(74, 19);
            rbInHouse.TabIndex = 1;
            rbInHouse.TabStop = true;
            rbInHouse.Text = "In-House";
            rbInHouse.UseVisualStyleBackColor = true;
            rbInHouse.CheckedChanged += rbInHouse_CheckedChanged;
            // 
            // rbOutSourced
            // 
            rbOutSourced.AutoSize = true;
            rbOutSourced.Location = new Point(213, 9);
            rbOutSourced.Name = "rbOutSourced";
            rbOutSourced.Size = new Size(87, 19);
            rbOutSourced.TabIndex = 2;
            rbOutSourced.TabStop = true;
            rbOutSourced.Text = "Outsourced";
            rbOutSourced.UseVisualStyleBackColor = true;
            rbOutSourced.CheckedChanged += rbOutSourced_CheckedChanged;
            // 
            // lblPartInOrOut
            // 
            lblPartInOrOut.AutoSize = true;
            lblPartInOrOut.Location = new Point(116, 268);
            lblPartInOrOut.Name = "lblPartInOrOut";
            lblPartInOrOut.Size = new Size(67, 15);
            lblPartInOrOut.TabIndex = 3;
            lblPartInOrOut.Text = "Machine ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 218);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 4;
            label3.Text = "Min";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 218);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 5;
            label4.Text = "Max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 176);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 6;
            label5.Text = "Price / Cost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(116, 139);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 7;
            label6.Text = "Inventory";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(116, 106);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 8;
            label7.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(116, 68);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 9;
            label8.Text = "ID";
            // 
            // btnSavePart
            // 
            btnSavePart.Location = new Point(371, 372);
            btnSavePart.Name = "btnSavePart";
            btnSavePart.Size = new Size(75, 23);
            btnSavePart.TabIndex = 10;
            btnSavePart.Text = "Save";
            btnSavePart.UseVisualStyleBackColor = true;
            btnSavePart.Click += btnSavePart_Click;
            // 
            // btnCancelPart
            // 
            btnCancelPart.Location = new Point(452, 372);
            btnCancelPart.Name = "btnCancelPart";
            btnCancelPart.Size = new Size(75, 23);
            btnCancelPart.TabIndex = 11;
            btnCancelPart.Text = "Cancel";
            btnCancelPart.UseVisualStyleBackColor = true;
            btnCancelPart.Click += btnCancelPart_Click;
            // 
            // tbPartInOrOut
            // 
            tbPartInOrOut.Location = new Point(227, 260);
            tbPartInOrOut.Multiline = true;
            tbPartInOrOut.Name = "tbPartInOrOut";
            tbPartInOrOut.Size = new Size(139, 23);
            tbPartInOrOut.TabIndex = 12;
            tbPartInOrOut.TextChanged += tbPartInOrOut_TextChanged;
            // 
            // tbPartMax
            // 
            tbPartMax.Location = new Point(200, 214);
            tbPartMax.Multiline = true;
            tbPartMax.Name = "tbPartMax";
            tbPartMax.Size = new Size(83, 23);
            tbPartMax.TabIndex = 13;
            tbPartMax.TextChanged += tbPartMax_TextChanged;
            // 
            // tbPartID
            // 
            tbPartID.Location = new Point(200, 65);
            tbPartID.Multiline = true;
            tbPartID.Name = "tbPartID";
            tbPartID.Size = new Size(139, 23);
            tbPartID.TabIndex = 14;
            tbPartID.TextChanged += tbPartID_TextChanged;
            // 
            // tbPartInventory
            // 
            tbPartInventory.Location = new Point(200, 131);
            tbPartInventory.Multiline = true;
            tbPartInventory.Name = "tbPartInventory";
            tbPartInventory.Size = new Size(139, 23);
            tbPartInventory.TabIndex = 15;
            tbPartInventory.TextChanged += tbPartInventory_TextChanged;
            // 
            // tbPartName
            // 
            tbPartName.Location = new Point(200, 98);
            tbPartName.Multiline = true;
            tbPartName.Name = "tbPartName";
            tbPartName.Size = new Size(139, 23);
            tbPartName.TabIndex = 16;
            tbPartName.TextChanged += tbPartName_TextChanged;
            // 
            // tbPartPrice
            // 
            tbPartPrice.Location = new Point(200, 168);
            tbPartPrice.Multiline = true;
            tbPartPrice.Name = "tbPartPrice";
            tbPartPrice.Size = new Size(139, 23);
            tbPartPrice.TabIndex = 17;
            tbPartPrice.TextChanged += tbPartPrice_TextChanged;
            // 
            // tbPartMin
            // 
            tbPartMin.Location = new Point(363, 214);
            tbPartMin.Multiline = true;
            tbPartMin.Name = "tbPartMin";
            tbPartMin.Size = new Size(83, 23);
            tbPartMin.TabIndex = 18;
            tbPartMin.TextChanged += tbPartMin_TextChanged;
            // 
            // AddPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 450);
            Controls.Add(tbPartMin);
            Controls.Add(tbPartPrice);
            Controls.Add(tbPartName);
            Controls.Add(tbPartInventory);
            Controls.Add(tbPartID);
            Controls.Add(tbPartMax);
            Controls.Add(tbPartInOrOut);
            Controls.Add(btnCancelPart);
            Controls.Add(btnSavePart);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblPartInOrOut);
            Controls.Add(rbOutSourced);
            Controls.Add(rbInHouse);
            Controls.Add(label1);
            Name = "AddPartForm";
            Text = "AddPartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rbInHouse;
        private RadioButton rbOutSourced;
        private Label lblPartInOrOut;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnSavePart;
        private Button btnCancelPart;
        private TextBox tbPartInOrOut;
        private TextBox tbPartMax;
        private TextBox tbPartID;
        private TextBox tbPartInventory;
        private TextBox tbPartName;
        private TextBox tbPartPrice;
        private TextBox tbPartMin;
        private ToolTip toolTip1;
    }
}