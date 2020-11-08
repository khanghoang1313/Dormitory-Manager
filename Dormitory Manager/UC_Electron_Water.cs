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
    public partial class UC_Electron_Water : UserControl
    {
        Models.Electron_WaterMod mod = new Models.Electron_WaterMod();
        public UC_Electron_Water()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            DataTable dt = mod.loadElectron_Water();
            dgridView.DataSource = dt;
            this.dgridView.Columns["Số Cũ"].Visible = false;
            this.dgridView.Columns["Số Mới"].Visible = false;
            this.dgridView.Columns["Số Tiêu Thụ"].Visible = false;
            this.dgridView.Columns["Đơn Giá"].Visible = false;
            bsiRecordsCount.Caption = "Số Hóa Đơn: " + dt.Rows.Count;
        }
        private void setnull()
        {
            //txtRoomID.Text = "";
            //txtEW_Name.Text = "";
            //txtOldNumber.Text = "";
            //txtUsed.Text = "";
            //txtNewNumber.Text = "";
            //txtAddress.Text = "";
        }
        private void dgvCustomerinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgridView.CurrentRow.Index;
            for (int i = 0; i < dgridView.Rows.Count; i++)
            {
                txtRoomID.Text = dgridView.Rows[index].Cells[2].Value.ToString();
                txtEW_Name.Text = dgridView.Rows[index].Cells[0].Value.ToString();

                DateTime  a = DateTime.Parse(dgridView.Rows[index].Cells[3].Value.ToString());
                txtGetDate.Text = a.ToString("dd/MM/yyyy");
                txtOldNumber.Text = dgridView.Rows[index].Cells[4].Value.ToString();
                txtNewNumber.Text = dgridView.Rows[index].Cells[5].Value.ToString();
                txtUsed.Text = dgridView.Rows[index].Cells[6].Value.ToString();
                textPrice.Text = dgridView.Rows[index].Cells[7].Value.ToString();
                textTotal.Text = dgridView.Rows[index].Cells[8].Value.ToString();
                textStatus.Text = dgridView.Rows[index].Cells[9].Value.ToString();
                gtg.Text = "Thông Tin " + dgridView.Rows[index].Cells[1].Value.ToString(); 
                
            }
        }

        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addElectron_Water add = new addElectron_Water(true,"");
            add.ShowDialog();
            if(add.IsDisposed==false)
            {
                setnull();
                dgridView.DataSource = null; 
                load();
            }

        }
        
        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addElectron_Water edit = new addElectron_Water(false, txtEW_Name.Text);

            if (txtRoomID.Text!= "")
            {
                edit.ShowDialog();
                if (edit.IsDisposed == false)
                {
                    setnull();
                    dgridView.DataSource = null;
                    load();
                }
            }
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtRoomID.Text != "")
            {
                if (MessageBox.Show("Bạn có muốn xoá phiếu này ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (mod.deElectron_Water(txtEW_Name.Text) == true)
                    {
                        setnull();
                        dgridView.DataSource = null;
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
