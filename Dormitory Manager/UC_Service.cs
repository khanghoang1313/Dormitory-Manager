using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dormitory_Manager.Models;

namespace Dormitory_Manager
{
    public partial class UC_Service : UserControl
    {
        ServiceMod mod = new ServiceMod();
        public UC_Service()
        {
            InitializeComponent();
        }

        private void settxt()
        {
            txtServiceID.Text = "";
            txtServiceName.Text = "";
            txtprice.Text = "";
            txtUnit.Text = "";
        }
        private void load()
        {
            DataTable dt = mod.loadService();
            dgvService.DataSource = dt;
            bsiRecordsCount.Caption = "Số Dịch Vụ: " + dt.Rows.Count;
        }
        private void UC_Service_Load(object sender, EventArgs e)
        {
            load();
            txtServiceID.Focus();
        }

        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index =dgvService.CurrentRow.Index;
            for(int i = 0; i<dgvService.Rows.Count; i++)
            {
                txtServiceID.Text = dgvService.Rows[index].Cells[0].Value.ToString();
                txtServiceName.Text = dgvService.Rows[index].Cells[1].Value.ToString();
                txtprice.Text = dgvService.Rows[index].Cells[2].Value.ToString();
                txtUnit.Text = dgvService.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addService add = new addService();
            add.ShowDialog();
            if (add.IsDisposed == false)
            {
                settxt();
                dgvService.DataSource = null;
                load();
            }
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string id = txtServiceID.Text;
            
            if(txtServiceID.Text != "")
            {
                editService edit = new editService(id.ToString());
                edit.ShowDialog();
                if (edit.IsDisposed == false)
                {
                    settxt();
                    dgvService.DataSource = null;
                    load();
                }
            }
            
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string id = txtServiceID.Text;
            if (txtServiceID.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xoá dịch vụ này ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (mod.delService(id.ToString()) == true)
                    {
                        settxt();
                        dgvService.DataSource = null;
                        load();
                    }
                }
            }
            
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            settxt();
            dgvService.DataSource = null;
            load();
        }
    }
}
