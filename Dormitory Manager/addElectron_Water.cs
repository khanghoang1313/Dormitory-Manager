using DevExpress.XtraExport;
using DevExpress.XtraLayout.Converter;
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
    public partial class addElectron_Water : Form
    {
        Models.Electron_WaterMod mod = new Models.Electron_WaterMod();

        Boolean _AddNew = false;
        public addElectron_Water(Boolean _Add,string _string)
        {
            InitializeComponent();
            _AddNew = _Add;
            dtpGetDate.CustomFormat = "dd-MM-yyyy";
            if (_Add == true)
            {
                LoadCombo("");
                resetData();
                
            }
            else
            {

                this.Text = "Sửa Phiếu Điện Nước";
                loadinfo(_string);
                setControlStatus();
            }
            
        }

        
        private void LoadCombo(string _m)
        {
            DataTable _dt = new DataTable();
            _dt = mod.loadComboRoomID();
            this.cboRoomID.DataSource = _dt;
            this.cboRoomID.DisplayMember = "Mã Phòng";
            this.cboRoomID.ValueMember = "MaPhong";
            if (_m != "")
            {
                this.cboRoomID.SelectedValue = _m;
            }
            else
            {
                this.cboRoomID.Text = "";
            }

            cbo_type.Text = "Phiếu Điện";
            cboStatus.Text = "Chưa Thanh Toán";


        }
        private void loadinfo(string id)
        {
            DataTable dgridView = mod.loadElectron_WaterwithID(id);
            for (int i = 0; i < dgridView.Rows.Count; i++)
            {
                cboRoomID.Text = dgridView.Rows[0][2].ToString();
                txtEW_Name.Text = dgridView.Rows[0][0].ToString();
                dtpGetDate.Text = dgridView.Rows[0][3].ToString();
                txtOldNumber.Text = dgridView.Rows[0][4].ToString();
                txtNewNumber.Text = dgridView.Rows[0][5].ToString();
                txtUsed.Text = dgridView.Rows[0][6].ToString();
                txtPrice.Text = dgridView.Rows[0][7].ToString();
                txtTotal.Text = dgridView.Rows[0][8].ToString();
                cboStatus.Text = dgridView.Rows[0][9].ToString();
                cbo_type.Text= dgridView.Rows[0][1].ToString();
               
            }
        }
        private void resetData()
        {
            cboRoomID.Text = "";
            txtOldNumber.Text = "0";
            txtNewNumber.Text = "";
            txtTotal.Text = "0";
            txtTotal.Text = "0";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                if (_AddNew == true)
                {
                    mod.addElectron_Water(cbo_type.Text, cboRoomID.Text, dtpGetDate.Value, Int32.Parse(txtOldNumber.Text), Int32.Parse(txtNewNumber.Text), Int32.Parse(txtUsed.Text), float.Parse(txtPrice.Text), float.Parse(txtTotal.Text), cboStatus.Text);
                }
                else
                {
                    mod.editElectron_Water(dtpGetDate.Value, Int32.Parse(txtNewNumber.Text), Int32.Parse(txtUsed.Text), float.Parse(txtPrice.Text), Int32.Parse(txtTotal.Text), cboStatus.Text, txtEW_Name.Text);
                }
                Close();
            }
           

        }


        private void cboRoomID_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(_AddNew == true)
            {
                txtOldNumber.Text = mod.Get_SoCu(cbo_type.Text, cboRoomID.Text).ToString();
            }
            
        }

        private void cbo_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_AddNew == true)
            {
                txtOldNumber.Text = mod.Get_SoCu(cbo_type.Text, cboRoomID.Text).ToString();
                txtPrice.Text = mod.Get_Dongia(cbo_type.Text).ToString();
            }
        }

        private void txtNewNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtNewNumber.Text != "")
            {
                 
                    int a = (int.Parse(txtNewNumber.Text) - int.Parse(txtOldNumber.Text));
                    txtUsed.Text = a.ToString();
                
                    ///MessageBox.Show(this, "Số mới phải lớn hơn số cũ!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 
            }

            if (txtPrice.Text != "")
            {
                float a = (float.Parse(txtUsed.Text) * float.Parse(txtPrice.Text));
                txtTotal.Text = a.ToString();
            }
        }

        private Boolean validateData()
        {
            if (cboRoomID.Text == "" )
            {
                MessageBox.Show(this, " Mã phòng không để trống !", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cboRoomID.Focus();
                return false;
            }
            if (cbo_type.Text == "")
            {
                MessageBox.Show(this, " Loại phiếu không để trống !", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cbo_type.Focus();
                return false;
            }
            if ((int.Parse(txtNewNumber.Text) - int.Parse(txtOldNumber.Text)) < 0 )
            {
                MessageBox.Show(this, "Số mới phải lớn hơn số cũ!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNewNumber.Focus();
                return false;
            }

            if (txtPrice.Text == "" && float.Parse(txtPrice.Text) > 0)
            {
                MessageBox.Show(this, "Giá không để trống và giá phải lớn hơn hơn 0!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPrice.Focus();
                return false;
            }
            if (cboStatus.Text == "")
            {
                MessageBox.Show(this, "Trạng thái  không để trống !", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cboStatus.Focus();
                return false;
            }
            return true;
        }


        private void setControlStatus()
        {
            cboRoomID.Enabled = false;
            cbo_type.Enabled = false;
        }


            private void txtNewNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
                
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text !="" && txtUsed.Text != "") 
            {
                float a = (float.Parse(txtUsed.Text) * float.Parse(txtPrice.Text));
                txtTotal.Text = a.ToString();
            }
        }
    }
}
