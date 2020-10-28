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
using System.Security.AccessControl;

namespace Dormitory_Manager
{
    public partial class UC_TenacyList : UserControl
    {
        TenacyMod mod = new TenacyMod();
        DataTable dtinfo;
        string IDTenacyinfo;
        public UC_TenacyList()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            DataTable dt = mod.loadTenacy3();
            dgvTenacylist.DataSource = dt;
            bsiRecordsCount.Caption = "Số Hợp Đồng:" + (dgvTenacylist.Rows.Count -1 ).ToString();
        }
        private void LoadTenacyinfo()
        {
                dtinfo = mod.loadTenacyinfo(IDTenacyinfo);
            if (dtinfo.Rows.Count > 0)
            {
                txtTenacyID.Text = dtinfo.Rows[0][0].ToString();
                txtDate.Text = dtinfo.Rows[0][1].ToString();
                txtCustomerName.Text = dtinfo.Rows[0][2].ToString() + " " + dtinfo.Rows[0][3].ToString();
                txtIDCus.Text = dtinfo.Rows[0][4].ToString();
                txtAddrCus.Text = dtinfo.Rows[0][5].ToString();
                txtStaffName.Text = dtinfo.Rows[0][6].ToString() + " " + dtinfo.Rows[0][7].ToString();
                txtIDStaff.Text = dtinfo.Rows[0][8].ToString();
                txtAddrStaff.Text = dtinfo.Rows[0][9].ToString();
                txtRoomname.Text = dtinfo.Rows[0][10].ToString();
                string[] n = dtinfo.Rows[0][11].ToString().Split(',');
                string[] p = dtinfo.Rows[0][12].ToString().Split(',');
                string[] u = dtinfo.Rows[0][13].ToString().Split(',');
                for (int i = 0; i < n.Length - 1; i++)
                {
                    ListViewItem item = lsvService.Items.Add(n[i]);
                    item.SubItems.Add(p[i].Trim());
                    item.SubItems.Add(u[i]);
                }
                txtDeposits.Text = dtinfo.Rows[0][14].ToString() + " VNĐ";
                txtStart.Text = dtinfo.Rows[0][15].ToString();
                txtEnd.Text = dtinfo.Rows[0][16].ToString();
            }  
        }
        private void dgvTenacylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int index = dgvTenacylist.CurrentRow.Index;
            IDTenacyinfo = dgvTenacylist.Rows[index].Cells[0].Value.ToString();
            lsvService.Items.Clear();
            LoadTenacyinfo();
        }

        private void setnull()
        {
            txtIDStaff.Text = null;
            txtIDCus.Text = null;
            txtCustomerName.Text = null;
            txtStaffName.Text = null;
            txtTenacyID.Text = null;
            txtDeposits.Text = null;
            txtDate.Text = null;
            txtStart.Text = null;
            txtEnd.Text = null;
            txtAddrStaff.Text = null;
            txtAddrCus.Text = null;
            lsvService.Items.Clear();
            txtRoomname.Text = null;
        }
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            addTenacy add = new addTenacy();
            add.ShowDialog(); 
            if (add.IsDisposed == false)
            {
                setnull();
                dgvTenacylist.DataSource = null;
                Load();
            }
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            editTenacy edit = new editTenacy(txtTenacyID.Text);
            if (txtTenacyID.Text != "")
            {
                edit.ShowDialog();
                if (edit.IsDisposed == false)
                {
                    setnull();
                    dgvTenacylist.DataSource = null;
                    Load();
                }
            }
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTenacyID.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xoá hợp đồng này ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (mod.delTenacy(txtTenacyID.Text) == true)
                    {
                        setnull();
                        dgvTenacylist.DataSource = null;
                        Load();
                    }
                }
            }
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            setnull();
            Load();
            bsiRecordsCount.Caption = "Số Hợp Đồng:" + (dgvTenacylist.Rows.Count).ToString();
        }
    }
}
