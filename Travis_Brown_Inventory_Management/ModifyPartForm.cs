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

            if(part is InHouse isInHouse) {
                rbInHouse.Checked = true;
                tbModPartInOrOut.Text = isInHouse.MachineID.ToString();
            }else if(part is Outsourced isOutsourced) {
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
    }
}
