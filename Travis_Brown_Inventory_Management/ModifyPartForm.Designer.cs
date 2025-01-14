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
            label1 = new Label();
            rbInHouse = new RadioButton();
            rbOutSourced = new RadioButton();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblModifyInOrOut = new Label();
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
            // textBox1
            // 
            textBox1.Location = new Point(125, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 23);
            textBox2.TabIndex = 5;
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
            // textBox3
            // 
            textBox3.Location = new Point(125, 267);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(76, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(125, 204);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(196, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(125, 152);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(196, 23);
            textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(285, 267);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(76, 23);
            textBox6.TabIndex = 10;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(143, 319);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(196, 23);
            textBox7.TabIndex = 11;
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
            // ModifyPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 556);
            Controls.Add(lblModifyInOrOut);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblModifyInOrOut;
    }
}