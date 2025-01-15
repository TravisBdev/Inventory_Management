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
    }
}
