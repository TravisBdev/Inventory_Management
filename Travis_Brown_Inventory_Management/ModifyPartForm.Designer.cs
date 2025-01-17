namespace Travis_Brown_Inventory_Management {
    partial class ModifyPartForm {
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
            label2 = new Label();
            tbModPartID = new TextBox();
            tbModPartName = new TextBox();
            label3 = new Label();
            tbModPartMax = new TextBox();
            tbModPartPrice = new TextBox();
            tbModPartInventory = new TextBox();
            tbModPartMin = new TextBox();
            tbModPartInOrOut = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblModifyInOrOut = new Label();
            btnModPartCancel = new Button();
            btnModPartSave = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Modify Part";
            // 
            // rbInHouse
            // 
            rbInHouse.AutoSize = true;
            rbInHouse.Location = new Point(125, 5);
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
            rbOutSourced.Location = new Point(234, 5);
            rbOutSourced.Name = "rbOutSourced";
            rbOutSourced.Size = new Size(87, 19);
            rbOutSourced.TabIndex = 2;
            rbOutSourced.TabStop = true;
            rbOutSourced.Text = "Outsourced";
            rbOutSourced.UseVisualStyleBackColor = true;
            rbOutSourced.CheckedChanged += rbOutSourced_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 57);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // tbModPartID
            // 
            tbModPartID.Location = new Point(125, 54);
            tbModPartID.Name = "tbModPartID";
            tbModPartID.Size = new Size(196, 23);
            tbModPartID.TabIndex = 4;
            // 
            // tbModPartName
            // 
            tbModPartName.Location = new Point(125, 102);
            tbModPartName.Name = "tbModPartName";
            tbModPartName.Size = new Size(196, 23);
            tbModPartName.TabIndex = 5;
            tbModPartName.TextChanged += tbModPartName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 110);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // tbModPartMax
            // 
            tbModPartMax.Location = new Point(125, 267);
            tbModPartMax.Name = "tbModPartMax";
            tbModPartMax.Size = new Size(76, 23);
            tbModPartMax.TabIndex = 7;
            tbModPartMax.TextChanged += tbModPartMax_TextChanged;
            // 
            // tbModPartPrice
            // 
            tbModPartPrice.Location = new Point(125, 204);
            tbModPartPrice.Name = "tbModPartPrice";
            tbModPartPrice.Size = new Size(196, 23);
            tbModPartPrice.TabIndex = 8;
            tbModPartPrice.TextChanged += tbModPartPrice_TextChanged;
            // 
            // tbModPartInventory
            // 
            tbModPartInventory.Location = new Point(125, 152);
            tbModPartInventory.Name = "tbModPartInventory";
            tbModPartInventory.Size = new Size(196, 23);
            tbModPartInventory.TabIndex = 9;
            tbModPartInventory.TextChanged += tbModPartInventory_TextChanged;
            // 
            // tbModPartMin
            // 
            tbModPartMin.Location = new Point(285, 267);
            tbModPartMin.Name = "tbModPartMin";
            tbModPartMin.Size = new Size(76, 23);
            tbModPartMin.TabIndex = 10;
            tbModPartMin.TextChanged += tbModPartMin_TextChanged;
            // 
            // tbModPartInOrOut
            // 
            tbModPartInOrOut.Location = new Point(143, 319);
            tbModPartInOrOut.Name = "tbModPartInOrOut";
            tbModPartInOrOut.Size = new Size(196, 23);
            tbModPartInOrOut.TabIndex = 11;
            tbModPartInOrOut.TextChanged += tbModPartInOrOut_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 271);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 12;
            label4.Text = "Min";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 271);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 13;
            label5.Text = "Max";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 207);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 14;
            label6.Text = "Price / Cost";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 155);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 15;
            label7.Text = "Inventory";
            // 
            // lblModifyInOrOut
            // 
            lblModifyInOrOut.AutoSize = true;
            lblModifyInOrOut.Location = new Point(40, 322);
            lblModifyInOrOut.Name = "lblModifyInOrOut";
            lblModifyInOrOut.Size = new Size(67, 15);
            lblModifyInOrOut.TabIndex = 16;
            lblModifyInOrOut.Text = "Machine ID";
            // 
            // btnModPartCancel
            // 
            btnModPartCancel.Location = new Point(438, 521);
            btnModPartCancel.Name = "btnModPartCancel";
            btnModPartCancel.Size = new Size(75, 23);
            btnModPartCancel.TabIndex = 17;
            btnModPartCancel.Text = "Cancel";
            btnModPartCancel.UseVisualStyleBackColor = true;
            btnModPartCancel.Click += btnModPartCancel_Click;
            // 
            // btnModPartSave
            // 
            btnModPartSave.Location = new Point(357, 521);
            btnModPartSave.Name = "btnModPartSave";
            btnModPartSave.Size = new Size(75, 23);
            btnModPartSave.TabIndex = 18;
            btnModPartSave.Text = "Save";
            btnModPartSave.UseVisualStyleBackColor = true;
            btnModPartSave.Click += btnModPartSave_Click;
            // 
            // ModifyPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 556);
            Controls.Add(btnModPartSave);
            Controls.Add(btnModPartCancel);
            Controls.Add(lblModifyInOrOut);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbModPartInOrOut);
            Controls.Add(tbModPartMin);
            Controls.Add(tbModPartInventory);
            Controls.Add(tbModPartPrice);
            Controls.Add(tbModPartMax);
            Controls.Add(label3);
            Controls.Add(tbModPartName);
            Controls.Add(tbModPartID);
            Controls.Add(label2);
            Controls.Add(rbOutSourced);
            Controls.Add(rbInHouse);
            Controls.Add(label1);
            Name = "ModifyPartForm";
            Text = "ModifyPartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rbInHouse;
        private RadioButton rbOutSourced;
        private Label label2;
        private TextBox tbModPartID;
        private TextBox tbModPartName;
        private Label label3;
        private TextBox tbModPartMax;
        private TextBox tbModPartPrice;
        private TextBox tbModPartInventory;
        private TextBox tbModPartMin;
        private TextBox tbModPartInOrOut;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblModifyInOrOut;
        private Button btnModPartCancel;
        private Button btnModPartSave;
        private ToolTip toolTip1;
    }
}