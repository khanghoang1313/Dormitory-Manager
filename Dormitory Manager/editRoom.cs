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
    public partial class editRoom : Form
    {
        public delegate void SendMessage(string id,string sta,string nam,string des,string ar,string ma);
        public SendMessage Sender;
        string idRoom;
        string Status;
        string RoomName;
        string Desc;
        string Area;
        string Max;
        public editRoom()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }
        private void GetMessage(string id, string sta, string nam, string des, string ar, string ma)
        {
            idRoom = id;
            Status = sta;
            RoomName = nam;
            Desc = des;
            Area = ar;
            Max = ma;
            
        }
        private void loadcboStatus()
        {
            Models.RoomMod lcbostatus = new Models.RoomMod();
            DataTable dt = lcbostatus.loadStatus();
            cboStatus.DataSource = dt;
            cboStatus.DisplayMember = "TenTrangThai";
            cboStatus.ValueMember = "MaTrangThai";
        }
        //trong sự kiện nút lưu 
        private void btnSave_Click(object sender, EventArgs e)
        {
            Models.RoomMod edit = new Models.RoomMod();
            //tạo các biến để gán giá trị vào hàm update
            string name = txtRoomName.Text;
            string stt = cboStatus.SelectedValue.ToString();//lưu trạng thái mới để cập nhật vào bản
            string dec = txtDescription.Text;
            string area = txtAcreage.Text;
            string max = txtCapacity.Text;
           if(edit.editRoom(idRoom, stt, name, dec, area, max) == true)// chạy hàm update
            {
                Close();
                
            }
           // load lại listview
        }
        private void loadDT()
        {
            txtRoomName.Text = RoomName;
            cboStatus.SelectedIndex = int.Parse(Status)-1;
            txtDescription.Text = Desc;
            txtAcreage.Text = Area;
            txtCapacity.Text = Max;
        }
        private void editRoom_Load(object sender, EventArgs e)
        {
            loadcboStatus();
            loadDT();
        }

        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtAcreage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtCapacity_Leave(object sender, EventArgs e)
        {
            if (txtCapacity.Text == "")
                txtCapacity.Text = "0";
        }

        private void txtAcreage_Leave(object sender, EventArgs e)
        {
            if (txtAcreage.Text == "")
                txtAcreage.Text = "0";
        }
    }
}
