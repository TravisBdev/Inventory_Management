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

                Inventory.AllParts.Add(partToAdd);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show($"Please double check your values {ex.Message}");
            }
        }

        private void btnCancelPart_Click(object sender, EventArgs e) {
            var res = MessageBox.Show("Are you sure you want to cancel?");

            if(res == DialogResult.OK) {
                this.Close();
            }
        }
    }
}
