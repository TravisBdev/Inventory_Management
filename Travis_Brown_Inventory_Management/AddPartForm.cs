using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travis_Brown_Inventory_Management.Classes;

namespace Travis_Brown_Inventory_Management {
    public partial class AddPartForm : Form {
        public AddPartForm() {
            InitializeComponent();
        }

        private void rbInHouse_CheckedChanged(object sender, EventArgs e) {
            if (rbInHouse.Checked) {
                lblPartInOrOut.Text = "Machine ID";
            }
        }

        private void rbOutSourced_CheckedChanged(object sender, EventArgs e) {
            if (rbOutSourced.Checked) {
                lblPartInOrOut.Text = "Company Name";
            }
        }

        //Live Validation
        private ToolTip tooltip = new();
        private void tbPartID_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbPartID.Text) || !int.TryParse(tbPartID.Text, out _)) {
                tbPartID.BackColor = Color.Red;
                tooltip.Show("Value required - must be a number.", tbPartID, 1500);
            } else {
                tbPartID.BackColor = Color.White;
                tooltip.Hide(tbPartID);
            }
        }

        private void tbPartName_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbPartName.Text) || tbPartName.Text.Any(char.IsDigit)) {
                tbPartName.BackColor = Color.Red;
                tooltip.Show("Value required - must be a string", tbPartName, 1500);
            } else {
                tbPartName.BackColor = Color.White;
                tooltip.Hide(tbPartName);
            }
        }

        private void tbPartInventory_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbPartInventory.Text) || !int.TryParse(tbPartInventory.Text, out _)) {
                tbPartInventory.BackColor = Color.Red;
            } else {
                tbPartInventory.BackColor = Color.White;
            }
        }

        private void tbPartPrice_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbPartPrice.Text) || !decimal.TryParse(tbPartPrice.Text, out _)) {
                tbPartPrice.BackColor = Color.Red;
            } else {
                tbPartPrice.BackColor = Color.White;
            }
        }

        private void tbPartMax_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbPartMax.Text) || !int.TryParse(tbPartMax.Text, out _)) {
                tbPartMax.BackColor = Color.Red;
            } else {
                tbPartMax.BackColor = Color.White;
            }
        }

        private void tbPartMin_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbPartMin.Text) || !int.TryParse(tbPartMin.Text, out _)) {
                tbPartMin.BackColor = Color.Red;
            } else {
                tbPartMin.BackColor = Color.White;
            }
        }

        private void tbPartInOrOut_TextChanged(object sender, EventArgs e) {
            if (rbInHouse.Checked) {
                if (string.IsNullOrWhiteSpace(tbPartInOrOut.Text) || !int.TryParse(tbPartInOrOut.Text, out _)) {
                    tbPartInOrOut.BackColor = Color.Red;
                } else {
                    tbPartInOrOut.BackColor = Color.White;
                }
            } else if (rbOutSourced.Checked) {
                if (string.IsNullOrWhiteSpace(tbPartInOrOut.Text)) {
                    tbPartInOrOut.BackColor = Color.Red;
                } else {
                    tbPartInOrOut.BackColor = Color.White;
                }
            }
        }

        //Save Validation
        private bool Validate(TextBox tb) {
            if (string.IsNullOrWhiteSpace(tb.Text)) {
                tb.BackColor = Color.Red;
                return false;
            } else {
                tb.BackColor = Color.White;
                return true;
            }
        }

        private bool ValidateFields() {
            bool isValid = true;
            isValid &= Validate(tbPartID);
            isValid &= Validate(tbPartName);
            isValid &= Validate(tbPartInventory);
            isValid &= Validate(tbPartPrice);
            isValid &= Validate(tbPartMax);
            isValid &= Validate(tbPartMin);

            if (rbInHouse.Checked) {
                if (!Validate(tbPartInOrOut)) {
                    isValid = false;
                }
            } else if (rbOutSourced.Checked) {
                if (!Validate(tbPartInOrOut)) {
                    isValid = false;
                }
            }


            return isValid;
        }



        private void btnSavePart_Click(object sender, EventArgs e) {
            if (!ValidateFields()) {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            try {
                int partID = int.Parse(tbPartID.Text);
                string name = tbPartName.Text;
                int inventory = int.Parse(tbPartInventory.Text);
                decimal price = decimal.Parse(tbPartPrice.Text);
                int min = int.Parse(tbPartMin.Text);
                int max = int.Parse(tbPartMax.Text);

                Part partToAdd;

                if (min > max || inventory < min || inventory > max) {
                    MessageBox.Show("Min cannot be greater than max. Inventory cannot be less than min or greater than max.");
                    return;
                }

                if (rbInHouse.Checked) {
                    int machineID = int.Parse(tbPartInOrOut.Text);

                    partToAdd = new InHouse {
                        PartID = partID,
                        Name = name,
                        InStock = inventory,
                        Price = price,
                        Min = min,
                        Max = max,
                        MachineID = machineID

                    };

                } else {
                    string companyName = tbPartInOrOut.Text;

                    partToAdd = new Outsourced {
                        PartID = partID,
                        Name = name,
                        InStock = inventory,
                        Price = price,
                        Min = min,
                        Max = max,
                        CompanyName = companyName
                    };
                }

                Inventory.addPart(partToAdd);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show($"Please double check your values {ex.Message}");
            }
        }

        private void btnCancelPart_Click(object sender, EventArgs e) {
            var res = MessageBox.Show("Are you sure you want to cancel?");

            if (res == DialogResult.OK) {
                this.Close();
            }
        }
    }
}
