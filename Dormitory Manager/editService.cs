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
    public partial class editService : Form
    {
        string Id;
        ServiceMod dt = new ServiceMod();
        public editService(string id)
        {
            InitializeComponent();
            Id = id;
            load();
        }
        private void load()
        {
            DataTable a = dt.loadServiceinedit(Id);
            txtServiceName.Text = a.Rows[0][1].ToString();
            txtPrice.Text = a.Rows[0][2].ToString();
            txtUnit.Text = a.Rows[0][3].ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtServiceName.Text;
            string price = txtPrice.Text;
            string unit = txtUnit.Text;
            if (txtServiceName.Text == "")
                txtServiceName.Text = "Dv.Mới";
            if (txtUnit.Text == "")
                txtUnit.Text = "VNĐ";
            if (txtPrice.Text == "")
                txtPrice.Text = "0";
            if (dt.editService(Id, name, price, unit) == true)
            {
                Close();
            }
            
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
                txtPrice.Text = "0";
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
