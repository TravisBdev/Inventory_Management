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
            isValid &= Validate(tbAddProdID);
            isValid &= Validate(tbAddProdName);
            isValid &= Validate(tbAddProdInventory);
            isValid &= Validate(tbAddProdPrice);
            isValid &= Validate(tbAddProdMin);
            isValid &= Validate(tbAddProdMax);
            return isValid;
        }

        //private void btnSearchAddProduct_Click(object sender, EventArgs e) {
        //    int productId;

        //    if (int.TryParse(tbAddProdSearch.Text, out productId)) {
        //        Product product = Inventory.lookUpProduct(productId);

        //        if (product != null) {
        //            var res = new BindingList<Product> { product };
        //            dgvProducts.DataSource = res;
        //        } else {
        //            MessageBox.Show("Sorry, this product could not be found.");
        //        }
        //    } else {
        //        MessageBox.Show("Please enter a valid product ID.");
        //    }
        //}
    }
}
