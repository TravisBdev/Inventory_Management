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
    public partial class ModifyProductForm : Form {

        private Product selected;
        public ModifyProductForm(Product product) {
            InitializeComponent();
            selected = product;
            tbModProdID.Text = product.ProductID.ToString();
            tbModProdName.Text = product.Name;
            tbModProdPrice.Text = product.Price.ToString();
            tbModProdInventory.Text = product.InStock.ToString();
            tbModProdMin.Text = product.Min.ToString();
            tbModProdMax.Text = product.Max.ToString();
        }

        private void ModifyProductForm_Load(object sender, EventArgs e) {
            dgvModProdAssociatedList.DataSource = selected.AssociatedParts;
            dgvModProdParts.DataSource = Inventory.AllParts;
            dgvModProdAssociatedList.ClearSelection();
            dgvModProdAssociatedList.CurrentCell = null;
            dgvModProdParts.ClearSelection();
            dgvModProdParts.CurrentCell = null;
        }

        //Live Validation
        private ToolTip tooltip = new();

        private void tbModProdName_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbModProdName.Text) || tbModProdName.Text.Any(char.IsDigit)) {
                tbModProdName.BackColor = Color.Red;
                tooltip.Show("Value required - must be a string", tbModProdName, 1500);
            } else {
                tbModProdName.BackColor = Color.White;
                tooltip.Hide(tbModProdName);
            }
        }

        private void tbModProdInventory_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbModProdInventory.Text) || !int.TryParse(tbModProdInventory.Text, out _)) {
                tbModProdInventory.BackColor = Color.Red;
                tooltip.Show("Value required - must be a number", tbModProdInventory, 1500);
            } else {
                tbModProdInventory.BackColor = Color.White;
                tooltip.Hide(tbModProdInventory);
            }
        }

        private void tbModProdPrice_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbModProdPrice.Text) || !decimal.TryParse(tbModProdPrice.Text, out _)) {
                tbModProdPrice.BackColor = Color.Red;
                tooltip.Show("Value required - must be a decimal", tbModProdPrice, 1500);
            } else {
                tbModProdPrice.BackColor = Color.White;
                tooltip.Hide(tbModProdPrice);
            }
        }

        private void tbModProdMax_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbModProdMax.Text) || !int.TryParse(tbModProdMax.Text, out _)) {
                tbModProdMax.BackColor = Color.Red;
                tooltip.Show("Value required - must be a number", tbModProdMax, 1500);
            } else {
                tbModProdMax.BackColor = Color.White;
                tooltip.Hide(tbModProdMax);
            }
        }

        private void tbModProdMin_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbModProdMin.Text) || !int.TryParse(tbModProdMin.Text, out _)) {
                tbModProdMin.BackColor = Color.Red;
                tooltip.Show("Value required - must be a number", tbModProdMin, 1500);
            } else {
                tbModProdMin.BackColor = Color.White;
                tooltip.Hide(tbModProdMin);
            }
        }

        private void btnSearchModProd_Click(object sender, EventArgs e) {
            int partId;
            if (int.TryParse(tbSearchModProd.Text, out partId)) {
                Part part = selected.lookUpAssociatedPart(partId);

                if (part != null) {
                    var res = new BindingList<Part> { part };
                    dgvModProdAssociatedList.DataSource = res;
                } else {
                    MessageBox.Show("Sorry, this part could not be found.");
                }
            } else {
                MessageBox.Show("Please enter a valid part ID.");
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
            isValid &= Validate(tbModProdName);
            isValid &= Validate(tbModProdInventory);
            isValid &= Validate(tbModProdPrice);
            isValid &= Validate(tbModProdMin);
            isValid &= Validate(tbModProdMax);
            return isValid;
        }

        private void btnSaveModifyProd_Click(object sender, EventArgs e) {
            if (!ValidateFields()) {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            try {
                selected.Name = tbModProdName.Text;
                selected.InStock = int.Parse(tbModProdInventory.Text);
                selected.Price = decimal.Parse(tbModProdPrice.Text);
                selected.Min = int.Parse(tbModProdMin.Text);
                selected.Max = int.Parse(tbModProdMax.Text);

                if (selected.Min > selected.Max || selected.InStock < selected.Min || selected.InStock > selected.Max) {
                    MessageBox.Show("Min cannot be greater than max. Inventory must be between min and max.");
                    return;
                }

                Inventory.updateProduct(selected.ProductID, selected);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show($"Please double check your values {ex.Message}");
            }
        }

        private void btnCancelModifyProd_Click(object sender, EventArgs e) {
            var res = MessageBox.Show("Are you sure you want to cancel?");

            if (res == DialogResult.OK) {
                this.Close();
            }
        }

        private void btnAddPart_Click(object sender, EventArgs e) {
            if (dgvModProdParts.CurrentRow == null) {
                MessageBox.Show("You must select a part to add.");
                return;
            }

            Part selectedPart = (Part)dgvModProdParts.CurrentRow.DataBoundItem;

            if (selected.AssociatedParts.Contains(selectedPart)) {
                MessageBox.Show("Please select a part that is not already associated");
                return;
            }

            if (selected != null) {
                selected.AssociatedParts.Add(selectedPart);
            }

            dgvModProdAssociatedList.DataSource = null;
            dgvModProdAssociatedList.DataSource = selected.AssociatedParts;


        }

        private void btnDeletePart_Click(object sender, EventArgs e) {
            if(dgvModProdAssociatedList.CurrentRow == null) {
                MessageBox.Show("Please select an associated part to delete");
            }

            Part selectedPart = (Part)dgvModProdAssociatedList.CurrentRow.DataBoundItem;

            var res = MessageBox.Show("Are you sure you want to delete this item?","Confirm Please", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(res == DialogResult.Yes) {
                selected.removeAssociatedPart(selectedPart);

                dgvModProdAssociatedList.ClearSelection();
                dgvModProdAssociatedList.CurrentCell = null;
            }
        }
    }
}
