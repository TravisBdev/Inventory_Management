using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travis_Brown_Inventory_Management {
    public partial class ModifyPartForm : Form {
        public ModifyPartForm() {
            InitializeComponent();
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
