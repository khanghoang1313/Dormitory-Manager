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
    public partial class addTenacy : Form
    {
        Models.ServiceMod Smod = new ServiceMod();
        Models.RoomMod Rmod = new RoomMod();
        Models.StaffMod Stmod = new StaffMod();
        Models.CustomerMod Cmod = new CustomerMod();
        Models.TenacyMod Tmod = new TenacyMod();
        DataTable Sdt;
        public addTenacy()
        {
            InitializeComponent();
            loadRoom();
            loadService();
            loadStaff();
            loadCustomer();
        }

        private void addTenacy_Load(object sender, EventArgs e)
        {
            dtpEnd.Value = dtpStart.Value.AddDays(60);
        }
        private void loadRoom()
        {
            cboRoomName.DataSource = Rmod.loadRoominAddTenacy();
            cboRoomName.DisplayMember = "TenPhong";
            cboRoomName.ValueMember = "MaPhong";
        }
        private void loadService()
        {
            cboService.DataSource = Smod.loadService();
            cboService.ValueMember = "MaDichVu";
            cboService.DisplayMember = "TenDichVu";
            Sdt = Smod.loadService();
        }
        private void loadCustomer()
        {
            dgvCustomer.DataSource = Cmod.loadCustomer();
        }
        private void loadStaff()
        {
           dgvStaff.DataSource= Stmod.loadStaff();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {         
            for(int i=0; i < Sdt.Rows.Count; i++)
            {
                if (cboService.SelectedValue.ToString() == Sdt.Rows[i][0].ToString())
                {
                    ListViewItem item = lsvService.Items.Add(Sdt.Rows[i][0].ToString());
                    item.SubItems.Add(Sdt.Rows[i][1].ToString());
                    item.SubItems.Add(Sdt.Rows[i][2].ToString());
                    item.SubItems.Add(Sdt.Rows[i][3].ToString());
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (lsvService.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Vui Lòng Chọn Dịch Vụ Cần Xoá");
            }
            else
            {
                lsvService.Items.RemoveAt(lsvService.SelectedIndices[0]);
            }
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            addStaff add = new addStaff();
            if (add.IsDisposed == false)
            {
                add.ShowDialog();
                dgvStaff.DataSource = null;
                loadStaff();
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            addCustomerinfo add = new addCustomerinfo();
            if (add.IsDisposed == false)
            {
                add.ShowDialog();
                dgvCustomer.DataSource = null;
                loadCustomer();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            txtIDofStaff.Text = null;
            txtStaffName.Text = null;
            txtIDStaff.Text = null;
            txtAddrStaff.Text = null;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            txtIDofCus.Text = null;
            txtCustomerName.Text = null;
            txtIDCus.Text = null;
            txtAddrCus.Text = null;
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvStaff.CurrentRow.Index;
            txtIDofStaff.Text = dgvStaff.Rows[index].Cells[0].Value.ToString();
            txtStaffName.Text = dgvStaff.Rows[index].Cells[1].Value.ToString()+" "+ dgvStaff.Rows[index].Cells[2].Value.ToString();
            txtStaFName.Text = dgvStaff.Rows[index].Cells[1].Value.ToString();
            txtStaLName.Text = dgvStaff.Rows[index].Cells[2].Value.ToString();
            txtIDStaff.Text = dgvStaff.Rows[index].Cells[5].Value.ToString();
            txtAddrStaff.Text = dgvStaff.Rows[index].Cells[8].Value.ToString();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvCustomer.CurrentRow.Index;
            txtIDofCus.Text = dgvCustomer.Rows[index].Cells[0].Value.ToString();
            txtCustomerName.Text = dgvCustomer.Rows[index].Cells[1].Value.ToString()+" "+ dgvCustomer.Rows[index].Cells[2].Value.ToString();
            txtCusFName.Text = dgvCustomer.Rows[index].Cells[1].Value.ToString();
            txtCusLName.Text = dgvCustomer.Rows[index].Cells[2].Value.ToString();
            txtIDCus.Text = dgvCustomer.Rows[index].Cells[5].Value.ToString();
            txtAddrCus.Text = dgvCustomer.Rows[index].Cells[8].Value.ToString();
        }

        private string getRoomname()
        {
            string Result="";
            DataTable dt = Rmod.loadRoom();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if(cboRoomName.SelectedValue.ToString()==dt.Rows[i][0].ToString())
                {
                    Result= dt.Rows[i][2].ToString();
                }
            }
            return Result.ToString();
        }
        private string getIDservice()
        {
            string result="";
            for(int i=0; i < lsvService.Items.Count; i++)
            {
                result +=lsvService.Items[i].Text.ToString() +",";
            }
            return result;
        }
        private string getDate(DateTimePicker o)
        {
            return o.Value.ToString("yyyy/MM/dd");
        }
        private string getSer(ListView a,int b)
        {
            string result = "";
            for (int j = 0; j < a.Items.Count; j++) 
            {
                    result += a.Items[j].SubItems[b].Text.ToString() + ",";
            }
            return result;
        }
        private bool check()
        {
            bool result=true;
            if (txtDeposits.Text == "")
            {
                txtDeposits.Text = "0";
            }
            if (txtIDofStaff.Text == "")
            {
                MessageBox.Show("Vui Lòng chọn nhân viên!");
                result = false;
            }
            if (txtIDofCus.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                result = false;
            }

            return result;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string listIDservice = getIDservice();
            
            if (check() == true)
            {
                if (MessageBox.Show("Bạn Muốn Lưu Hợp Đồng Này ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtIDofStaff.Text != null && txtIDofCus != null && lsvService.Items.Count > 0)
                    {
                        if (Tmod.addTenacy(cboRoomName.SelectedValue.ToString(), txtIDofStaff.Text, listIDservice, txtIDofCus.Text) == true)
                        {
                            if (Tmod.addTenacyinfo(getDate(dtpDate), txtCusFName.Text, txtCusLName.Text, txtIDCus.Text, txtAddrCus.Text, txtStaFName.Text, txtStaLName.Text, txtIDStaff.Text, txtAddrStaff.Text, getRoomname(), getSer(lsvService, 1), getSer(lsvService, 2), getSer(lsvService, 3), txtDeposits.Text, getDate(dtpStart), getDate(dtpEnd)) == true)
                            {
                                if (Rmod.setStatus(cboRoomName.SelectedValue.ToString()) == true)
                                {
                                    Close();
                                } 
                            }
                        }
                    }
                }
            }
        }
    }
}
