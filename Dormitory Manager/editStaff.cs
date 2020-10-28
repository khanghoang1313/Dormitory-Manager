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
    public partial class editStaff : Form
    {
        string staID;
        Models.StaffMod mod = new Models.StaffMod();
        public editStaff(string StaID)
        {
            InitializeComponent();
            staID = StaID;
            load();
        }
        private void load()
        {
            DataTable dt = mod.loadStaffwithID(staID);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtFirstName.Text = dt.Rows[0][1].ToString();
                txtLastName.Text = dt.Rows[0][2].ToString();
                dtpBirth.Text = dt.Rows[0][3].ToString();
                string Sex = dt.Rows[0][4].ToString();
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
                txtID.Text = dt.Rows[0][5].ToString();
                txtPhone.Text = dt.Rows[0][6].ToString();
                txtMail.Text = dt.Rows[0][7].ToString();
                txtAddress.Text = dt.Rows[0][8].ToString();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string birth = dtpBirth.Value.ToString("yyyy/MM/dd");
            string Sex = "";
            if (robMale.Checked == true)
            {
                Sex = robMale.Text.ToString();
            }
            if (robFemale.Checked == true)
            {
                Sex = robFemale.Text.ToString();
            }
            if (robOther.Checked == true)
            {
                Sex = robOther.Text.ToString();
            }
            string id = txtID.Text;
            string phone = txtPhone.Text;
            string mail = txtMail.Text;
            string addr = txtAddress.Text;
            if (fname != "" && lname != "" && id != "" && addr != "" && mod.editStaff(staID, fname, lname, birth, Sex, id, phone, mail, addr))
            {
                Close();
            }

        }
    }
}
