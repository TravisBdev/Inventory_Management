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
    public partial class AddProductForm : Form {
        public AddProductForm() {
            InitializeComponent();
        }

        private Product newProduct = new();
        private void AddProductForm_Load(object sender, EventArgs e) {
            dgvAddProdPartsList.DataSource = Inventory.AllParts;
            dgvAddProdAssociatedList.DataSource = newProduct.AssociatedParts;
            dgvAddProdPartsList.ClearSelection();
            dgvAddProdPartsList.CurrentCell = null;
            dgvAddProdAssociatedList.ClearSelection();
            dgvAddProdAssociatedList.CurrentCell = null;
        }

        //Live Validation
        private ToolTip tooltip = new();

        private void tbAddProdName_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbAddProdName.Text) || tbAddProdName.Text.Any(char.IsDigit)) {
                tbAddProdName.BackColor = Color.Red;
                tooltip.Show("Value required - must be a string", tbAddProdName, 1500);
            } else {
                tbAddProdName.BackColor = Color.White;
                tooltip.Hide(tbAddProdName);
            }
        }


        private void tbAddProdInventory_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbAddProdInventory.Text) || !int.TryParse(tbAddProdInventory.Text, out _)) {
                tbAddProdInventory.BackColor = Color.Red;
                tooltip.Show("Value required - must be a number", tbAddProdInventory, 1500);
            } else {
                tbAddProdInventory.BackColor = Color.White;
                tooltip.Hide(tbAddProdInventory);
            }
        }

        private void tbAddProdPrice_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbAddProdPrice.Text) || !decimal.TryParse(tbAddProdPrice.Text, out _)) {
                tbAddProdPrice.BackColor = Color.Red;
                tooltip.Show("Value required - must be a decimal", tbAddProdPrice, 1500);
            } else {
                tbAddProdPrice.BackColor = Color.White;
                tooltip.Hide(tbAddProdPrice);
            }
        }

        private void tbAddProdMax_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbAddProdMax.Text) || !int.TryParse(tbAddProdMax.Text, out _)) {
                tbAddProdMax.BackColor = Color.Red;
                tooltip.Show("Value required - must be a number", tbAddProdMax, 1500);
            } else {
                tbAddProdMax.BackColor = Color.White;
                tooltip.Hide(tbAddProdMax);
            }
        }

        private void tbAddProdMin_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbAddProdMin.Text) || !int.TryParse(tbAddProdMin.Text, out _)) {
                tbAddProdMin.BackColor = Color.Red;
                tooltip.Show("Value required - must be a number", tbAddProdMin, 1500);
            } else {
                tbAddProdMin.BackColor = Color.White;
                tooltip.Hide(tbAddProdMin);
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
            isValid &= Validate(tbAddProdName);
            isValid &= Validate(tbAddProdInventory);
            isValid &= Validate(tbAddProdPrice);
            isValid &= Validate(tbAddProdMin);
            isValid &= Validate(tbAddProdMax);
            return isValid;
        }

        private void btnAddProdSave_Click(object sender, EventArgs e) {
            if (!ValidateFields()) {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            if (newProduct.AssociatedParts.Count == 0) {
                MessageBox.Show("You must select at least one associated part.");
                return;
            }

            try {
                newProduct.Name = tbAddProdName.Text;
                newProduct.InStock = int.Parse(tbAddProdInventory.Text);
                newProduct.Price = decimal.Parse(tbAddProdPrice.Text);
                newProduct.Min = int.Parse(tbAddProdMin.Text);
                newProduct.Max = int.Parse(tbAddProdMax.Text);

                if (newProduct.Min > newProduct.Max || newProduct.InStock < newProduct.Min || newProduct.InStock > newProduct.Max) {
                    MessageBox.Show("Min cannot be greater than max. Inventory cannot be less than min or greater than max.");
                    return;
                }

                Inventory.addProduct(newProduct);
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show($"Please double check your values {ex.Message}");
            }
        }

        private void btnAddProdCancel_Click(object sender, EventArgs e) {
            var res = MessageBox.Show("Are you sure you want to cancel?");

            if (res == DialogResult.OK) {
                this.Close();
            }
        }

        private void btnSearchAddProduct_Click(object sender, EventArgs e) {
            int partId;

            if (int.TryParse(tbAddProdSearch.Text, out partId)) {
                Part part = newProduct.lookUpAssociatedPart(partId);

                if (part != null) {
                    var res = new BindingList<Part> { part };
                    dgvAddProdAssociatedList.DataSource = res;
                } else {
                    MessageBox.Show("Sorry, this part could not be found.");
                }
            } else {
                MessageBox.Show("Please enter a valid part ID.");
            }
        }

        private void tbAddProdSearch_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbAddProdSearch.Text)) {
                dgvAddProdAssociatedList.DataSource = newProduct.AssociatedParts;
            }
        }

        private void btnAddPart_Click(object sender, EventArgs e) {
            if (dgvAddProdPartsList.CurrentRow == null) {
                MessageBox.Show("Please select a part.");
            }

            Part selected = (Part)dgvAddProdPartsList.CurrentRow.DataBoundItem;

            if (newProduct.AssociatedParts.Contains(selected)) {
                MessageBox.Show("Please choose a different part that is not already associated.");
                return;
            }

            newProduct.addAssociatedPart(selected);
        }

        private void btnDeletePart_Click(object sender, EventArgs e) {
            if (dgvAddProdAssociatedList.CurrentRow == null) {
                MessageBox.Show("You must select a part to delete.");
                return;
            }

            Part selected = (Part)dgvAddProdAssociatedList.CurrentRow.DataBoundItem;

            var check = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Please Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (check == DialogResult.Yes) {
                newProduct.removeAssociatedPart(selected);
            }
        }
    }
}
