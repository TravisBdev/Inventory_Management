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
            if (!ValidateFields()) {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            try {
                selected.Name = tbModPartName.Text;
                selected.InStock = int.Parse(tbModPartInventory.Text);
                selected.Price = decimal.Parse(tbModPartPrice.Text);
                selected.Min = int.Parse(tbModPartMin.Text);
                selected.Max = int.Parse(tbModPartMax.Text);

                if(selected.Min > selected.Max || selected.InStock < selected.Min || selected.InStock > selected.Max) {
                    MessageBox.Show("Min cannot be greater than max. Inventory cannot be less than min or greater than max.");
                    return;
                }

                if(rbInHouse.Checked && selected is InHouse inPart) {
                    inPart.MachineID = int.Parse(tbModPartInOrOut.Text);
                }else if(rbOutSourced.Checked && selected is Outsourced outPart) {
                    outPart.CompanyName = tbModPartInOrOut.Text;
                }

                Inventory.AllParts.Remove(selected);
                Inventory.AllParts.Add(selected);

                this.Close();

            } catch (Exception ex) {
                MessageBox.Show($"Please double check your values {ex.Message}");
            }
        }
    }
}
