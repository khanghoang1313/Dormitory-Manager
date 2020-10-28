using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory_Manager
{
    public partial class UC_Staffinfo : UserControl
    {
        Models.StaffMod mod = new Models.StaffMod();
        public UC_Staffinfo()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            DataTable dt = mod.loadStaff();
            dgvStaffinfo.DataSource = dt;
            bsiRecordsCount.Caption = "Số Nhân Viên: " + dt.Rows.Count;
        }
        private void setnull()
        {
            txtStaffID.Text = "";
            txtStaffName.Text = "";
            txtID.Text = "";
            txtMail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }

        private void dgvCustomerinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvStaffinfo.CurrentRow.Index;
            for (int i = 0; i < dgvStaffinfo.Rows.Count; i++)
            {
                txtStaffID.Text = dgvStaffinfo.Rows[index].Cells[0].Value.ToString();
                txtStaffName.Text = dgvStaffinfo.Rows[index].Cells[1].Value.ToString() + " " + dgvStaffinfo.Rows[index].Cells[2].Value.ToString();
                dtpBirth.Text = dgvStaffinfo.Rows[index].Cells[3].Value.ToString();
                string Sex = dgvStaffinfo.Rows[index].Cells[4].Value.ToString();
                if (Sex == "Nam")
                {
                    robMale.Checked = true;
                }
                if (Sex == "Nữ")
                {
                    robFemale.Checked = true;
                }
                if (Sex == "Khác")
                {
                    robOther.Checked = true;
                }
                txtID.Text = dgvStaffinfo.Rows[index].Cells[5].Value.ToString();
                txtPhone.Text = dgvStaffinfo.Rows[index].Cells[6].Value.ToString();
                txtMail.Text = dgvStaffinfo.Rows[index].Cells[7].Value.ToString();
                txtAddress.Text = dgvStaffinfo.Rows[index].Cells[8].Value.ToString();
            }
        }

        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addStaff add = new addStaff();
            add.ShowDialog();
            if (add.IsDisposed == false)
            {
                setnull();
                dgvStaffinfo.DataSource = null;
                load();
            }
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            editStaff edit = new editStaff(txtStaffID.Text);
            if (txtStaffID.Text != "")
            {
                edit.ShowDialog();
                if (edit.IsDisposed == false)
                {
                    setnull();
                    dgvStaffinfo.DataSource = null;
                    load();
                }
            }
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtStaffID.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xoá nhân viên này ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (mod.deStaff(txtStaffID.Text) == true)
                    {
                        setnull();
                        dgvStaffinfo.DataSource = null;
                        load();
                    }
                }
            }
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();
            setnull();
        }
    }
}
