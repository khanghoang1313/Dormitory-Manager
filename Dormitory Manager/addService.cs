using Dormitory_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory_Manager
{
    public partial class addService : Form
    {
        ServiceMod mod = new ServiceMod();
        public addService()
        {
            InitializeComponent();
        }

        private void addService_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtServiceName.Text == "")
                txtServiceName.Text = "Dv.Mới";
            if (txtUnit.Text == "")
                txtUnit.Text = "VNĐ/Tháng";
            if (txtPrice.Text == "")
                txtPrice.Text = "0";
            string name = txtServiceName.Text;
            string price = txtPrice.Text;
            string unit = txtUnit.Text;
            
            if (mod.addService(name, price, unit) == true)
            {
                Close();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (txtPrice.Text =="")
                txtPrice.Text = "0";
        }
    }
}
