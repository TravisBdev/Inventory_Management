using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travis_Brown_Inventory_Management.Classes;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Travis_Brown_Inventory_Management {
    public partial class ModifyPartForm : Form {
        private Part selected;
        public ModifyPartForm(Part part) {
            InitializeComponent();
            selected = part;
            tbModPartID.Text = part.PartID.ToString();
            tbModPartName.Text = part.Name;
            tbModPartInventory.Text = part.InStock.ToString();
            tbModPartPrice.Text = part.Price.ToString();
            tbModPartMax.Text = part.Max.ToString();
            tbModPartMin.Text = part.Min.ToString();

            if (part is InHouse isInHouse) {
                rbInHouse.Checked = true;
                tbModPartInOrOut.Text = isInHouse.MachineID.ToString();
            } else if (part is Outsourced isOutsourced) {
                rbOutSourced.Checked = true;
                tbModPartInOrOut.Text = isOutsourced.CompanyName;
            }
        }

        private void rbInHouse_CheckedChanged(object sender, EventArgs e) {
            if (rbInHouse.Checked) {
                lblModifyInOrOut.Text = "Machine ID";
            }
        }

        private void rbOutSourced_CheckedChanged(object sender, EventArgs e) {
            if (rbOutSourced.Checked) {
                lblModifyInOrOut.Text = "Company Name";
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
            isValid &= Validate(tbModPartName);
            isValid &= Validate(tbModPartInventory);
            isValid &= Validate(tbModPartPrice);
            isValid &= Validate(tbModPartMax);
            isValid &= Validate(tbModPartMin);

            if (rbInHouse.Checked) {
                if (!Validate(tbModPartInOrOut)) {
                    isValid = false;
                }
            } else if (rbOutSourced.Checked) {
                if (!Validate(tbModPartInOrOut)) {
                    isValid = false;
                }
            }


            return isValid;
        }

        private void btnModPartSave_Click(object sender, EventArgs e) {
            if(!ValidateFields()) {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            try {
                string name = tbModPartName.Text;
                int inventory = int.Parse(tbModPartInventory.Text);
                decimal price = decimal.Parse(tbModPartPrice.Text);
                int min = int.Parse(tbModPartMin.Text);
                int max = int.Parse(tbModPartMax.Text);

                if(min > max || inventory < min || inventory > max) {
                    MessageBox.Show("Min cannot be greater than max. Inventory must be between min and max.");
                    return;
                }

                Part toUpdate;
                if(rbInHouse.Checked) {
                    toUpdate = new InHouse {
                        PartID = selected.PartID,
                        Name = name,
                        InStock = inventory,
                        Price = price,
                        Min = min,
                        Max = max,
                        MachineID = int.Parse(tbModPartInOrOut.Text)
                    };
                }else {
                    toUpdate = new Outsourced {
                        PartID = selected.PartID,
                        Name = name,
                        InStock = inventory,
                        Price = price,
                        Min = min,
                        Max = max,
                        CompanyName = tbModPartInOrOut.Text
                    };
                }
                Inventory.updatePart(selected.PartID, toUpdate);

                this.Close();

            } catch (Exception ex) {
                MessageBox.Show($"Please double check your values {ex.Message}");
            }
        }
    }
}