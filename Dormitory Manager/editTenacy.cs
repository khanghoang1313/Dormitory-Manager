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
    public partial class editTenacy : Form
    {
        string tenacyID;
        Models.TenacyMod Tmod = new Models.TenacyMod();
        Models.ServiceMod Smod = new Models.ServiceMod();
        Models.RoomMod Rmod = new Models.RoomMod();
        Models.StaffMod Stmod = new Models.StaffMod();
        Models.CustomerMod Cmod = new Models.CustomerMod();
        DataTable Sdt;
        public editTenacy(string TenacyID)
        {
            InitializeComponent();
            tenacyID = TenacyID;
        }
        private void loadTenacyinfo()
        {
            DataTable dt = Tmod.loadeditTenacy(tenacyID);
            txtTenacyID.Text = tenacyID;
            txtIDofStaff.Text = dt.Rows[0][0].ToString();
            txtIDofCus.Text = dt.Rows[0][1].ToString();
            cboRoomName.SelectedValue = dt.Rows[0][2].ToString();
            txtStaFName.Text = dt.Rows[0][10].ToString();
            txtStaLName.Text = dt.Rows[0][11].ToString();
            txtStaffName.Text = dt.Rows[0][10].ToString() + " " + dt.Rows[0][11].ToString();
            txtAddrStaff.Text = dt.Rows[0][13].ToString();
            txtIDStaff.Text = dt.Rows[0][12].ToString();
            txtCusFName.Text = dt.Rows[0][6].ToString();
            txtCusLName.Text = dt.Rows[0][7].ToString();
            txtAddrCus.Text = dt.Rows[0][9].ToString();
            txtCustomerName.Text = dt.Rows[0][6].ToString() + " " + dt.Rows[0][7].ToString();
            txtIDCus.Text = dt.Rows[0][8].ToString();
            dtpDate.Value = Convert.ToDateTime(dt.Rows[0][5].ToString());
            dtpStart.Value = Convert.ToDateTime(dt.Rows[0][19].ToString());
            dtpEnd.Value = Convert.ToDateTime(dt.Rows[0][20].ToString());
            string[] c = dt.Rows[0][3].ToString().Split(',');
            string[] n = dt.Rows[0][15].ToString().Split(',');
            string[] p = dt.Rows[0][16].ToString().Split(',');
            string[] u = dt.Rows[0][17].ToString().Split(',');
            for (int i = 0; i < c.Length-1; i++)
            {
                ListViewItem item = lsvService.Items.Add(c[i]);
                item.SubItems.Add(n[i]);
                item.SubItems.Add(p[i].Trim());
                item.SubItems.Add(u[i]);
            }
        }
        private void loadRoom()
        {
            cboRoomName.DataSource = Rmod.loadRoominEditTenacy();
            cboRoomName.DisplayMember = "TenPhong";
            cboRoomName.ValueMember = "MaPhong";
            DataTable dt = Tmod.loadeditTenacy(tenacyID);
            cboRoomName.SelectedValue = dt.Rows[0][2].ToString();
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
            dgvStaff.DataSource = Stmod.loadStaff();
        }
        private void editTenacy_Load(object sender, EventArgs e)
        {
            loadStaff();
            loadCustomer();
            loadService();
            loadRoom();
            loadTenacyinfo();
        }

        private string getRoomname()
        {
            string Result = "";
            DataTable dt = Rmod.loadRoom();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cboRoomName.SelectedValue.ToString() == dt.Rows[i][0].ToString())
                {
                    Result = dt.Rows[i][2].ToString();
                }
            }
            return Result.ToString();
        }
        private string getIDservice()
        {
            string result = "";
            for (int i = 0; i < lsvService.Items.Count; i++)
            {
                result += lsvService.Items[i].Text.ToString() + ",";
            }
            return result;
        }
        private string getDate(DateTimePicker o)
        {
            return o.Value.ToString("yyyy/MM/dd");
        }
        private string getSer(ListView a, int b)
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
            bool result = true;
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
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string listIDservice = getIDservice();

            if (check() == true)
            {
                if (MessageBox.Show("Bạn Muốn Lưu Hợp Đồng Này ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtIDofStaff.Text != null && txtIDofCus != null && lsvService.Items.Count > 0)
                    {
                        if (Tmod.editTenacy(tenacyID, cboRoomName.SelectedValue.ToString(), txtIDofStaff.Text, listIDservice, txtIDofCus.Text) == true)
                        {
                            if (Tmod.editTenacyinfo(tenacyID, getDate(dtpDate), txtCusFName.Text, txtCusLName.Text, txtIDCus.Text, txtAddrCus.Text, txtStaFName.Text, txtStaLName.Text, txtIDStaff.Text, txtAddrStaff.Text, getRoomname(), getSer(lsvService, 1), getSer(lsvService, 2), getSer(lsvService, 3), txtDeposits.Text, getDate(dtpStart), getDate(dtpEnd)) == true)
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

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            addStaff add = new addStaff();
            if (add.IsDisposed == false)
            {
                add.ShowDialog();
                dgvStaff.DataSource = null;
                loadStaff();
            }
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            txtIDofStaff.Text = null;
            txtStaffName.Text = null;
            txtIDStaff.Text = null;
            txtAddrStaff.Text = null;
        }

        private void simpleButton6_Click_1(object sender, EventArgs e)
        {
            addCustomerinfo add = new addCustomerinfo();
            if (add.IsDisposed == false)
            {
                add.ShowDialog();
                dgvCustomer.DataSource = null;
                loadCustomer();
            }
        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
            txtIDofCus.Text = null;
            txtCustomerName.Text = null;
            txtIDCus.Text = null;
            txtAddrCus.Text = null;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < Sdt.Rows.Count; i++)
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

        private void simpleButton2_Click_1(object sender, EventArgs e)
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

        private void dgvStaff_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvStaff.CurrentRow.Index;
            txtIDofStaff.Text = dgvStaff.Rows[index].Cells[0].Value.ToString();
            txtStaffName.Text = dgvStaff.Rows[index].Cells[1].Value.ToString() + " " + dgvStaff.Rows[index].Cells[2].Value.ToString();
            txtStaFName.Text = dgvStaff.Rows[index].Cells[1].Value.ToString();
            txtStaLName.Text = dgvStaff.Rows[index].Cells[2].Value.ToString();
            txtIDStaff.Text = dgvStaff.Rows[index].Cells[5].Value.ToString();
            txtAddrStaff.Text = dgvStaff.Rows[index].Cells[8].Value.ToString();
        }

        private void dgvCustomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvCustomer.CurrentRow.Index;
            txtIDofCus.Text = dgvCustomer.Rows[index].Cells[0].Value.ToString();
            txtCustomerName.Text = dgvCustomer.Rows[index].Cells[1].Value.ToString() + " " + dgvCustomer.Rows[index].Cells[2].Value.ToString();
            txtCusFName.Text = dgvCustomer.Rows[index].Cells[1].Value.ToString();
            txtCusLName.Text = dgvCustomer.Rows[index].Cells[2].Value.ToString();
            txtIDCus.Text = dgvCustomer.Rows[index].Cells[5].Value.ToString();
            txtAddrCus.Text = dgvCustomer.Rows[index].Cells[8].Value.ToString();
        }
    }
}
