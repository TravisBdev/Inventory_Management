using System.ComponentModel;
using Travis_Brown_Inventory_Management.Classes;
namespace Travis_Brown_Inventory_Management
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvParts.DataSource = Inventory.AllParts;
            dgvProducts.DataSource = Inventory.Products;
        }

        //Code for parts
        private void btnSearchPart_Click(object sender, EventArgs e) {
            int partId;

            if (int.TryParse(tbSearchParts.Text, out partId)) {
                Part part = Inventory.lookupPart(partId);

                if (part != null) {
                    var res = new BindingList<Part> { part };
                    dgvParts.DataSource = res;
                } else {
                    MessageBox.Show("Sorry, this part could not be found.");
                }
            } else {
                MessageBox.Show("Please enter a valid part ID.");
            }
        }

        private void tbSearchParts_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbSearchParts.Text)) {
                dgvParts.DataSource = Inventory.AllParts;
            }
        }

        private void btnAddPart_Click(object sender, EventArgs e) {
            AddPartForm addPartForm = new();
            addPartForm.ShowDialog();
        }

        private void btnModifyPart_Click(object sender, EventArgs e) {
            if (dgvParts.CurrentRow == null) {
                MessageBox.Show("You must select a part to modify.");
                return;
            }

            Part selected = (Part)dgvParts.CurrentRow.DataBoundItem;

            ModifyPartForm modifyPartForm = new(selected);

            modifyPartForm.ShowDialog();
        }

        private void btnDeletePart_Click(object sender, EventArgs e) {
            if (dgvParts.CurrentRow == null) {
                MessageBox.Show("You must select a part to delete.");
                return;
            }

            Part selected = (Part)dgvParts.CurrentRow.DataBoundItem;

            var check = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Please Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (check == DialogResult.Yes) {
                Inventory.deletePart(selected);
            }
        }

        //Code for products
        private void btnSearchProduct_Click(object sender, EventArgs e) {
            int productId;

            if (int.TryParse(tbSearchParts.Text, out productId)) {
                Product product = Inventory.lookUpProduct(productId);

                if (product != null) {
                    var res = new BindingList<Product> { product };
                    dgvProducts.DataSource = res;
                } else {
                    MessageBox.Show("Sorry, this product could not be found.");
                }
            } else {
                MessageBox.Show("Please enter a valid product ID.");
            }
        }

        private void tbSearchProducts_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbSearchProducts.Text)) {
                dgvProducts.DataSource = Inventory.Products;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e) {
            AddProductForm addProductForm = new();
            addProductForm.ShowDialog();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e) {
            if (dgvProducts.CurrentRow == null) {
                MessageBox.Show("You must select a product to modify.");
                return;
            }

            Product selected = (Product)dgvProducts.CurrentRow.DataBoundItem;

            ModifyProductForm modifyProductForm = new(selected);

            modifyProductForm.ShowDialog();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e) {
            if (dgvProducts.CurrentRow == null) {
                MessageBox.Show("You must select a product to delete.");
                return;
            }

            Product selected = (Product)dgvParts.CurrentRow.DataBoundItem;

            var check = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Please Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (check == DialogResult.Yes) {
                Inventory.Products.Remove(selected);
            }
        }

        private void btnExitMainScreen_Click(object sender, EventArgs e) {
            this.Close();   
        }
    }
}
