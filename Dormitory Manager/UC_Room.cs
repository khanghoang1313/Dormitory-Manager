using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.ComponentModel.DataAnnotations;
using Dormitory_Manager.Models;
using DevExpress.XtraPrinting.Native;

namespace Dormitory_Manager
{
    public partial class UC_Room : DevExpress.XtraEditors.XtraUserControl
    {
        public bool Flag;
        RoomMod lRoom = new RoomMod();
        Models.TenacyMod Tmod = new TenacyMod();
        public UC_Room()
        {
            InitializeComponent();
        }
        private bool updateRoom()
        {
            bool result = lRoom.updatestatusRoom();
            return result;
        }
        private void LoadRoom()
        {
            bool check = updateRoom();
            DataTable dt = lRoom.loadRoom();
            for (int i = 0; i< dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["TenPhong"].ToString());
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                int status = int.Parse(dt.Rows[i][1].ToString());
                switch (status)
                {
                    case 1:
                        item.ImageIndex = 0;
                        break;
                    case 2:
                        item.ImageIndex = 1;
                        break;
                    case 3:
                        item.ImageIndex = 2;
                        break;
                    case 4:
                        item.ImageIndex = 3;
                        break;
                    default:
                        item.ImageIndex = 0;
                        break;
                }
                bsiRecordsCount.Caption="Tổng Số Phòng: "+dt.Rows.Count.ToString();
                item.SubItems.Add(subItem);
                lsvRoom.Items.Add(item);
            }
            
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            lsvRoom.Clear();
            LoadRoom();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            addRoom a = new addRoom();
            a.ShowDialog();
            if (a.IsDisposed == false)
            {
                lsvRoom.Clear();
                setClear();
                LoadRoom();
            }
        }


        private void UC_Room_Load(object sender, EventArgs e)
        {
            LoadRoom();
            MessageBox.Show("Bạn đang sử dụng phần mềm quản lý phòng trọ");
        }

        private void setClear()
        {
            txtRoomID.Clear();
            txtRoomName.Clear();
            txtStatus.Clear();
            txtDescription.Clear();
            txtCapacity.Clear();
            txtAcreage.Clear();
        }
        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtRoomID.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xoá phòng này ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (lRoom.delRoom(txtRoomID.Text) == true)
                    {
                        lsvRoom.Clear();
                        setClear();
                        LoadRoom();
                    }
                }
            }
        }
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtRoomID.Text != "")
            {
                editRoom a = new editRoom();
                a.Sender(txtRoomID.Text,txtStatusid.Text,txtRoomName.Text,txtDescription.Text,txtAcreage.Text,txtCapacity.Text);
                a.ShowDialog();
                if (a.IsDisposed == false)
                {
                    lsvRoom.Clear();
                    setClear();
                    LoadRoom();
                }
            }
        }

        private void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void lsvRoom_Click(object sender, EventArgs e)
        {
            bbiDelete.Enabled = true;
            DataTable dt = lRoom.loadRoom();
            if (lsvRoom.SelectedItems.Count > 0)
            {
                string st = lsvRoom.SelectedItems[0].SubItems[1].Text;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (st == dt.Rows[i][0].ToString())
                    {
                        txtRoomID.Text = dt.Rows[i][0].ToString();
                        txtStatusid.Text = dt.Rows[i][1].ToString();
                        if (txtStatusid.Text == "2" || txtStatusid.Text == "3")
                        {
                            bbiDelete.Enabled = false;
                        }
                        txtStatus.Text = dt.Rows[i][7].ToString();
                        txtRoomName.Text = dt.Rows[i][2].ToString();
                        txtDescription.Text = dt.Rows[i][3].ToString();
                        txtAcreage.Text = dt.Rows[i][4].ToString();
                        txtCapacity.Text = dt.Rows[i][5].ToString();
                    }

                }
            }
        }
    }
}
