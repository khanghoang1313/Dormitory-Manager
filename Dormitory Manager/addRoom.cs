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
    public partial class addRoom : Form
    {
        public addRoom()
        {
            InitializeComponent();
            
        }
        public string Value()
        {
            string result = "dbo.idRoom(),"+ cboStatus.SelectedValue.ToString() + ",N'" + txtRoomName.Text + "',N'" + txtDescription.Text + "'," + txtAcreage.Text + "," + txtCapacity.Text;
            return result;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Models.RoomMod add = new Models.RoomMod();
            if (txtAcreage.Text == "")
                txtAcreage.Text = "0";
            if (txtCapacity.Text == "")
                txtCapacity.Text = "0";
            if (txtRoomName.Text == "")
                txtRoomName.Text = "P.Mới";
            if (add.addRoom(Value()) == true)
            {
                Close();
            }
        }
        private void loadcboStatus()
        {
            Models.RoomMod lcbostatus = new Models.RoomMod();
            DataTable dt = lcbostatus.loadStatus();
            cboStatus.DataSource = dt;
            cboStatus.DisplayMember = "TenTrangThai";
            cboStatus.ValueMember = "MaTrangThai";
        }

        private void addRoom_Load(object sender, EventArgs e)
        {
            loadcboStatus();
        }

        private void txtAcreage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
