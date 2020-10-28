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
    public partial class UC_Customerinfo : UserControl
    {
        Models.CustomerMod mod = new Models.CustomerMod();
        public UC_Customerinfo()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            DataTable dt = mod.loadCustomer();
            dgvCustomerinfo.DataSource = dt;
            bsiRecordsCount.Caption = "Số Khách Hàng: " + dt.Rows.Count;
        }
        private void setnull()
        {
            txtCusID.Text = "";
            txtCusName.Text = "";
            txtID.Text = "";
            txtMail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }
        private void dgvCustomerinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvCustomerinfo.CurrentRow.Index;
            for (int i = 0; i < dgvCustomerinfo.Rows.Count; i++)
            {
                txtCusID.Text = dgvCustomerinfo.Rows[index].Cells[0].Value.ToString();
                txtCusName.Text = dgvCustomerinfo.Rows[index].Cells[1].Value.ToString()+" "+ dgvCustomerinfo.Rows[index].Cells[2].Value.ToString();
                dtpBirth.Text = dgvCustomerinfo.Rows[index].Cells[3].Value.ToString();
                string Sex = dgvCustomerinfo.Rows[index].Cells[4].Value.ToString();
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
                txtID.Text = dgvCustomerinfo.Rows[index].Cells[5].Value.ToString();
                txtPhone.Text = dgvCustomerinfo.Rows[index].Cells[6].Value.ToString();
                txtMail.Text = dgvCustomerinfo.Rows[index].Cells[7].Value.ToString();
                txtAddress.Text = dgvCustomerinfo.Rows[index].Cells[8].Value.ToString();
            }
        }

        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addCustomerinfo add = new addCustomerinfo();
            add.ShowDialog();
            if(add.IsDisposed==false)
            {
                setnull();
                dgvCustomerinfo.DataSource = null; 
                load();
            }

        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            editCustomerinfo edit = new editCustomerinfo(txtCusID.Text);

            if(txtCusID.Text!= "")
            {
                edit.ShowDialog();
                if (edit.IsDisposed == false)
                {
                    setnull();
                    dgvCustomerinfo.DataSource = null;
                    load();
                }
            }
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtCusID.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xoá khách hàng này ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (mod.deCustomer(txtCusID.Text) == true)
                    {
                        setnull();
                        dgvCustomerinfo.DataSource = null;
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
